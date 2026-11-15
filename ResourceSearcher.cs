using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using MeloongCore;
using MeloongCore.Extensions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PCLCS;

namespace PCL;

public class ResourceSearcher
{
	public class SearchRequest
	{
		public SearchResult Storage;

		public int TargetResultCount;

		public ResourceTypes Type;

		public string Tag;

		public ModLoaders ModLoaders;

		public string GameVersion;

		public string SearchText;

		public ResourcePlatforms Sources;

		public bool CanContinue
		{
			get
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				if (StringExtensions.StartsWithF(Tag, "/", false) || !EnumUtils.HasFlagF<ResourcePlatforms>(Sources, (ResourcePlatforms)1))
				{
					Storage.CurseForgeTotal = 0;
				}
				if (StringExtensions.EndsWithF(Tag, "/", false) || !EnumUtils.HasFlagF<ResourcePlatforms>(Sources, (ResourcePlatforms)2))
				{
					Storage.ModrinthTotal = 0;
				}
				if (Storage.CurseForgeTotal == -1 || Storage.ModrinthTotal == -1)
				{
					return true;
				}
				return Storage.CurseForgeOffset < Storage.CurseForgeTotal || Storage.ModrinthOffset < Storage.ModrinthTotal;
			}
		}

		public SearchRequest(ResourceTypes Type, SearchResult Storage, int TargetResultCount)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			Tag = "";
			ModLoaders = (ModLoaders)0;
			GameVersion = null;
			SearchText = null;
			Sources = (ResourcePlatforms)3;
			this.Type = Type;
			this.Storage = Storage;
			this.TargetResultCount = TargetResultCount;
		}

		public string GetCurseForgeAddress(string SearchText, bool IgnoreModLoaderFilter)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected I4, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Invalid comparison between Unknown and I4
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Invalid comparison between Unknown and I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			if (StringExtensions.StartsWithF(Tag, "/", false))
			{
				Storage.CurseForgeTotal = 0;
			}
			string text = $"https://api.curseforge.com/v1/mods/search?gameId=432&sortField=2&sortOrder=desc&pageSize={40}";
			ResourceTypes type = Type;
			switch (type - 1)
			{
			default:
				if ((int)type != 8)
				{
					if ((int)type == 16)
					{
						text += "&classId=6945";
					}
				}
				else
				{
					text += "&classId=6552";
				}
				break;
			case 0:
				text += "&classId=6";
				break;
			case 1:
				text += "&classId=4471";
				break;
			case 3:
				text += "&classId=12";
				break;
			case 2:
				break;
			}
			if (Operators.CompareString(Tag, "", TextCompare: false) != 0)
			{
				text = text + "&categoryId=" + StringExtensions.BeforeFirst(Tag, "/", false);
			}
			if ((int)ModLoaders != 0 && !IgnoreModLoaderFilter)
			{
				text = text + "&modLoaderType=" + Conversions.ToString(Resource.ToCurseForgeModLoaderType(EnumerableExtensions.Flags<ModLoaders>(ModLoaders).First()));
			}
			if (!string.IsNullOrEmpty(GameVersion))
			{
				text = text + "&gameVersion=" + GameVersion;
			}
			if (!string.IsNullOrEmpty(SearchText))
			{
				text = text + "&searchFilter=" + StringUtils.UrlEscape(SearchText);
			}
			if (Storage.CurseForgeOffset > 0)
			{
				text = text + "&index=" + Conversions.ToString(Storage.CurseForgeOffset);
			}
			return text;
		}

		public string GetModrinthAddress(string SearchText, bool IgnoreModLoaderFilter)
		{
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			if (StringExtensions.EndsWithF(Tag, "/", false))
			{
				Storage.ModrinthTotal = 0;
			}
			string text = $"https://api.modrinth.com/v2/search?limit={40}&index=relevance";
			if (!string.IsNullOrEmpty(SearchText))
			{
				text = text + "&query=" + StringUtils.UrlEscape(SearchText);
			}
			if (Storage.ModrinthOffset > 0)
			{
				text = text + "&offset=" + Conversions.ToString(Storage.ModrinthOffset);
			}
			List<string> list = new List<string>();
			list.Add($"[\"project_type:{StringExtensions.Lower(((Enum)Type/*cast due to constrained. prefix*/).ToString())}\"]");
			if (!string.IsNullOrEmpty(Tag))
			{
				list.Add(string.Format("[\"categories:'{0}'\"]", StringExtensions.AfterLast(Tag, "/", false)));
			}
			if ((int)ModLoaders != 0 && !IgnoreModLoaderFilter)
			{
				list.Add(string.Format("[\"categories:{0}\"]", EnumerableExtensions.Join((IEnumerable)(from f in EnumerableExtensions.Flags<ModLoaders>(ModLoaders)
					select StringExtensions.Lower(((Enum)f/*cast due to constrained. prefix*/).ToString())), "\",\"categories:")));
			}
			if (!string.IsNullOrEmpty(GameVersion))
			{
				list.Add($"[\"versions:'{GameVersion}'\"]");
			}
			return text + "&facets=[" + string.Join(",", list) + "]";
		}

		public override bool Equals(object obj)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			if (obj is SearchRequest searchRequest && Type == searchRequest.Type && TargetResultCount == searchRequest.TargetResultCount && Operators.CompareString(Tag, searchRequest.Tag, TextCompare: false) == 0 && ModLoaders == searchRequest.ModLoaders && Sources == searchRequest.Sources && Operators.CompareString(GameVersion, searchRequest.GameVersion, TextCompare: false) == 0)
			{
				return Operators.CompareString(SearchText, searchRequest.SearchText, TextCompare: false) == 0;
			}
			return false;
		}

		public static bool operator ==(SearchRequest left, SearchRequest right)
		{
			return EqualityComparer<SearchRequest>.Default.Equals(left, right);
		}

		public static bool operator !=(SearchRequest left, SearchRequest right)
		{
			return !(left == right);
		}

		public override int GetHashCode()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			return (Type, Tag, ModLoaders, GameVersion, SearchText, Sources).GetHashCode();
		}
	}

	public class SearchResult
	{
		public int CurseForgeOffset;

		public int CurseForgeTotal;

		public int ModrinthOffset;

		public int ModrinthTotal;

		public List<ResourceProject> Results;

		public string ErrorMessage;

		public SearchResult()
		{
			CurseForgeOffset = 0;
			CurseForgeTotal = -1;
			ModrinthOffset = 0;
			ModrinthTotal = -1;
			Results = new List<ResourceProject>();
			ErrorMessage = null;
		}
	}

	private const int RESULT_PAGE_SIZE = 40;

	private const string MSG_NO_CHINESE_RESULT = "无搜索结果，请尝试搜索其英文名称";

	[SpecialName]
	private static List<ModBase.SearchEntry<WikiEntry>> _0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init;

	[SpecialName]
	private static List<ModBase.SearchEntry<WikiEntry>> _0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init;

	public static ModLoader.LoaderTask<SearchRequest, int> GetLoader(Func<SearchRequest> InputDelegate)
	{
		return new ModLoader.LoaderTask<SearchRequest, int>("社区资源获取", Run, InputDelegate)
		{
			ReloadTimeout = 60000
		};
	}

	private static void Run(ModLoader.LoaderTask<SearchRequest, int> Task)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Invalid comparison between Unknown and I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Invalid comparison between Unknown and I4
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Invalid comparison between Unknown and I4
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Invalid comparison between Unknown and I4
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Invalid comparison between Unknown and I4
		SearchRequest input = Task.Input;
		SearchResult storage = input.Storage;
		if (storage.Results.Count >= input.TargetResultCount)
		{
			Logger.Info($"已有 {storage.Results.Count} 个结果，多于所需的 {input.TargetResultCount} 个结果，结束处理", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
			return;
		}
		if (!input.CanContinue)
		{
			if (!storage.Results.Any())
			{
				throw new Exception("没有符合条件的结果");
			}
			Logger.Info($"已有 {storage.Results.Count} 个结果，少于所需的 {input.TargetResultCount} 个结果，但无法继续获取，结束处理", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
			return;
		}
		string text = (input.SearchText ?? "").Trim();
		text = StringExtensions.Lower(text);
		Logger.Info($"工程列表搜索原始文本：{text}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
		text = Strings.StrConv(text, VbStrConv.SimplifiedChinese);
		bool flag = StringExtensions.RegexCheck(text, "[\\u4e00-\\u9fbb]", RegexOptions.None) && !string.IsNullOrEmpty(text) && ((int)input.Type == 1 || (int)input.Type == 16);
		string text2 = null;
		string text3 = null;
		List<string> list = new List<string>();
		if (flag)
		{
			VB_0024AnonymousDelegate_2<ModBase.SearchEntry<WikiEntry>, ResourcePlatforms, IEnumerable<string>> obj = [SpecialName] (ModBase.SearchEntry<WikiEntry> Result, ResourcePlatforms Source) =>
			{
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				List<string> list9 = new List<string>();
				if (Result.Item.Slugs.ContainsKey(Source))
				{
					list9.Add(Result.Item.Slugs[Source].Replace("-", " ").Replace("/", " "));
				}
				if (Result.Item.ChineseName != null)
				{
					list9.Add(StringExtensions.BeforeFirst(StringExtensions.AfterLast(Result.Item.ChineseName, " (", false).TrimEnd(')'), " - ", false).Replace("-", " ").Replace("/", " ")
						.Replace(":", " ")
						.Replace("(", " ")
						.Replace(")", ""));
				}
				list9 = (from w in list9.SelectMany([SpecialName] (string c) => StringExtensions.Split(c, " ", false))
					select StringExtensions.Lower(w.TrimStart('{').TrimEnd('}'))).Where([SpecialName] (string w) =>
				{
					if (w.Length <= 1)
					{
						return false;
					}
					if (new string[9] { "the", "of", "mod", "and", "forge", "fabric", "for", "quilt", "neoforge" }.Contains(w))
					{
						return false;
					}
					if (ModBase.Val(w) > 0.0)
					{
						return false;
					}
					return StringExtensions.IsAsciiOnly(w) ? true : false;
				}).Distinct().ToList();
				Func<string, bool> func = null;
				func = [SpecialName] (string s) => list9.Contains(s) || list9.Any([SpecialName] (string c) => s.StartsWith(c) && func(s.Substring(c.Length)));
				list9 = list9.Where([SpecialName] (string w) => !list9.Any([SpecialName] (string c) => c.Length < w.Length && w.StartsWith(c) && func(w.Substring(c.Length)))).ToList();
				return list9;
			};
			VB_0024AnonymousDelegate_3<ResourcePlatforms, IEnumerable<ModBase.SearchEntry<WikiEntry>>> obj2 = [SpecialName] [IteratorStateMachine(typeof(_Closure_0024__.VB_0024StateMachine___Lambda_0024__6_002D8))] (ResourcePlatforms Source) =>
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				foreach (WikiEntry item in WikiEntry.All.Value)
				{
					if (item.Slugs.ContainsKey(Source))
					{
						if (item.ChineseName != null)
						{
							yield return new ModBase.SearchEntry<WikiEntry>
							{
								Item = item,
								SearchSource = new List<ModBase.SearchSource>
								{
									new ModBase.SearchSource(StringExtensions.Split(Strings.StrConv(StringExtensions.BeforeFirst(item.ChineseName, " (", false), VbStrConv.SimplifiedChinese), '/', true)),
									new ModBase.SearchSource(Strings.StrConv(StringExtensions.AfterFirst(item.ChineseName, " (", false), VbStrConv.SimplifiedChinese) + item.Slugs[Source], 0.5)
								}
							};
						}
						else
						{
							yield return new ModBase.SearchEntry<WikiEntry>
							{
								Item = item,
								SearchSource = new List<ModBase.SearchSource>
								{
									new ModBase.SearchSource(item.Slugs[Source], 0.5)
								}
							};
						}
					}
				}
			};
			if (EnumUtils.HasFlagF<ResourcePlatforms>(input.Sources, (ResourcePlatforms)1))
			{
				if (_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init, ref lockTaken);
					if (_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init.State == 0)
					{
						_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init.State = 2;
						_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries = obj2((ResourcePlatforms)1).ToList();
					}
					else if (_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init.State = 1;
					if (lockTaken)
					{
						Monitor.Exit(_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries_0024Init);
					}
				}
				List<ModBase.SearchEntry<WikiEntry>> list2 = ModBase.Search(_0024STATIC_0024Run_0024011151286FC21283B48_0024CurseForgeSearchEntries, text, 100, 0.25);
				if (list2.Any())
				{
					ModBase.SearchEntry<WikiEntry> result = EnumerableExtensions.MaxBy<ModBase.SearchEntry<WikiEntry>, int>((IEnumerable<ModBase.SearchEntry<WikiEntry>>)(list2.First().AbsoluteRight ? list2.Where([SpecialName] (ModBase.SearchEntry<WikiEntry> s) => s.AbsoluteRight).ToList() : EnumerableExtensions.MaxByAll<ModBase.SearchEntry<WikiEntry>, double>((IEnumerable<ModBase.SearchEntry<WikiEntry>>)list2, (Func<ModBase.SearchEntry<WikiEntry>, double>)([SpecialName] (ModBase.SearchEntry<WikiEntry> s) => s.Similarity))), (Func<ModBase.SearchEntry<WikiEntry>, int>)([SpecialName] (ModBase.SearchEntry<WikiEntry> s) => s.Item.Popularity));
					text2 = EnumerableExtensions.Join((IEnumerable)obj(result, (ResourcePlatforms)1), " ");
					Logger.Warn($"中文搜索关键词（CurseForge）：{text2}", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
				}
			}
			if (EnumUtils.HasFlagF<ResourcePlatforms>(input.Sources, (ResourcePlatforms)2))
			{
				if (_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init == null)
				{
					Interlocked.CompareExchange(ref _0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init, new StaticLocalInitFlag(), null);
				}
				bool lockTaken2 = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init, ref lockTaken2);
					if (_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init.State == 0)
					{
						_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init.State = 2;
						_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries = obj2((ResourcePlatforms)2).ToList();
					}
					else if (_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init.State = 1;
					if (lockTaken2)
					{
						Monitor.Exit(_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries_0024Init);
					}
				}
				List<ModBase.SearchEntry<WikiEntry>> list3 = ModBase.Search(_0024STATIC_0024Run_0024011151286FC21283B48_0024ModrinthSearchEntries, text, 100, 0.25);
				if (list3.Any())
				{
					Dictionary<string, double> dictionary = new Dictionary<string, double>();
					foreach (ModBase.SearchEntry<WikiEntry> item2 in list3)
					{
						foreach (string item3 in obj(item2, (ResourcePlatforms)2))
						{
							if (!dictionary.ContainsKey(item3))
							{
								dictionary.Add(item3, 0.0);
							}
							double num = (item2.SearchSource.Any([SpecialName] (ModBase.SearchSource s) => s.Aliases.Contains(text)) ? 1000.0 : item2.Similarity);
							dictionary[item3] += num * (double)item2.Item.Popularity;
						}
					}
					text3 = EnumerableExtensions.MaxBy<KeyValuePair<string, double>, double>((IEnumerable<KeyValuePair<string, double>>)dictionary, (Func<KeyValuePair<string, double>, double>)([SpecialName] (KeyValuePair<string, double> w) => w.Value)).Key;
					Logger.Warn($"中文搜索关键词（Modrinth）：{text3}", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
					list = (from r in list3.Take(100)
						select r.Item.Slugs[(ResourcePlatforms)2]).ToList();
				}
			}
			if (string.IsNullOrEmpty(text2) && string.IsNullOrEmpty(text3) && !list.Any())
			{
				throw new Exception("无搜索结果，请尝试搜索其英文名称");
			}
		}
		Task.Progress = 0.05;
		List<ResourceProject> list4 = new List<ResourceProject>();
		ConcurrentBag<(Exception Ex, ResourcePlatforms Source)> concurrentBag;
		bool flag2;
		ConcurrentBag<ResourceProject> concurrentBag2;
		while (true)
		{
			List<ResourceProject> list5 = new List<ResourceProject>();
			List<Thread> list6 = new List<Thread>();
			concurrentBag = new ConcurrentBag<(Exception, ResourcePlatforms)>();
			flag2 = (int)input.ModLoaders == 1 && McVersion.VersionToDrop(input.GameVersion) < 140;
			concurrentBag2 = new ConcurrentBag<ResourceProject>();
			try
			{
				checked
				{
					if (EnumUtils.HasFlagF<ResourcePlatforms>(input.Sources, (ResourcePlatforms)1) && (storage.CurseForgeTotal <= -1 || storage.CurseForgeTotal > storage.CurseForgeOffset) && (!flag || (flag && !string.IsNullOrEmpty(text2))))
					{
						list6.Add(ModBase.RunInNewThread([SpecialName] () =>
						{
							//IL_0041: Unknown result type (might be due to invalid IL or missing references)
							//IL_0047: Expected Obj, but got Unknown
							//IL_0066: Unknown result type (might be due to invalid IL or missing references)
							//IL_006d: Expected Obj, but got Unknown
							//IL_007c: Unknown result type (might be due to invalid IL or missing references)
							//IL_0082: Invalid comparison between Unknown and I4
							//IL_009d: Unknown result type (might be due to invalid IL or missing references)
							//IL_00a4: Invalid comparison between Unknown and I4
							//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
							//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
							try
							{
								string curseForgeAddress = input.GetCurseForgeAddress(text2 ?? text, flag2);
								Logger.Info($"开始 CurseForge 搜索：{curseForgeAddress}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
								JObject val = (JObject)ModDownload.DlModRequest(curseForgeAddress);
								List<ResourceProject> list9 = new List<ResourceProject>();
								foreach (JObject item4 in (IEnumerable<JToken>)val["data"])
								{
									JObject data = item4;
									ResourceProject resourceProject = new ResourceProject(data);
									if (unchecked(((int)input.Type != 4 || !resourceProject.Tags.Contains("数据包")) && ((int)input.Type == 127 || EnumUtils.HasFlagF<ResourceTypes>(resourceProject.Types, input.Type))))
									{
										list9.Add(resourceProject);
									}
								}
								list9.ForEach([SpecialName] (ResourceProject p) =>
								{
									concurrentBag2.Add(p);
								});
								storage.CurseForgeOffset += ((IEnumerable<JToken>)val["data"]).Count();
								storage.CurseForgeTotal = val["pagination"][(object)"totalCount"].ToObject<int>();
								Logger.Info($"从 CurseForge 搜索到了 {list9.Count} 个工程（总计已获取 {storage.CurseForgeOffset} 个，共 {storage.CurseForgeTotal} 个）", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								Logger.Warn(ex2, "CurseForge 搜索失败", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
								storage.CurseForgeTotal = -1;
								concurrentBag.Add((ex2, (ResourcePlatforms)1));
								ProjectData.ClearProjectError();
							}
							if (Task.Progress < 0.75)
							{
								Task.Progress += 0.25;
							}
						}, "CurseForge Search"));
					}
					if (EnumUtils.HasFlagF<ResourcePlatforms>(input.Sources, (ResourcePlatforms)2) && (storage.ModrinthTotal <= -1 || storage.ModrinthTotal > storage.ModrinthOffset) && (!flag || (flag && !string.IsNullOrEmpty(text3))))
					{
						list6.Add(ModBase.RunInNewThread([SpecialName] () =>
						{
							//IL_0041: Unknown result type (might be due to invalid IL or missing references)
							//IL_0047: Expected Obj, but got Unknown
							//IL_0066: Unknown result type (might be due to invalid IL or missing references)
							//IL_006d: Expected Obj, but got Unknown
							try
							{
								string modrinthAddress = input.GetModrinthAddress(text3 ?? text, flag2);
								Logger.Info($"开始 Modrinth 搜索：{modrinthAddress}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
								JObject val = (JObject)ModDownload.DlModRequest(modrinthAddress);
								List<ResourceProject> list9 = new List<ResourceProject>();
								foreach (JObject item5 in (IEnumerable<JToken>)val["hits"])
								{
									JObject data = item5;
									list9.Add(new ResourceProject(data));
								}
								list9.ForEach([SpecialName] (ResourceProject p) =>
								{
									concurrentBag2.Add(p);
								});
								storage.ModrinthOffset += ((IEnumerable<JToken>)val["hits"]).Count();
								storage.ModrinthTotal = val["total_hits"].ToObject<int>();
								Logger.Info($"从 Modrinth 搜索到了 {list9.Count} 个工程（总计已获取 {storage.ModrinthOffset} 个，共 {storage.ModrinthTotal} 个）", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								Logger.Warn(ex2, "Modrinth 搜索失败", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
								storage.ModrinthTotal = -1;
								concurrentBag.Add((ex2, (ResourcePlatforms)2));
								ProjectData.ClearProjectError();
							}
							if (Task.Progress < 0.75)
							{
								Task.Progress += 0.25;
							}
						}, "Modrinth Search"));
					}
				}
				if (EnumUtils.HasFlagF<ResourcePlatforms>(input.Sources, (ResourcePlatforms)2) && (storage.ModrinthTotal <= -1 || storage.ModrinthTotal > storage.ModrinthOffset) && list.Any())
				{
					list6.Add(ModBase.RunInNewThread([SpecialName] () =>
					{
						//IL_0051: Unknown result type (might be due to invalid IL or missing references)
						//IL_0057: Expected Obj, but got Unknown
						//IL_0065: Unknown result type (might be due to invalid IL or missing references)
						//IL_006c: Invalid comparison between Unknown and I4
						//IL_0070: Unknown result type (might be due to invalid IL or missing references)
						//IL_007b: Unknown result type (might be due to invalid IL or missing references)
						//IL_00de: Unknown result type (might be due to invalid IL or missing references)
						//IL_018c: Unknown result type (might be due to invalid IL or missing references)
						//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
						//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
						//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							string text4 = string.Format("https://api.modrinth.com/v2/projects?ids=[\"{0}\"]", EnumerableExtensions.Join((IEnumerable)list, "\",\""));
							Logger.Info($"开始 Modrinth 直接获取：{text4}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
							List<ResourceProject> list9 = new List<ResourceProject>();
							foreach (JObject item6 in (IEnumerable<JToken>)ModDownload.DlModRequest(text4))
							{
								JObject val = item6;
								ResourceProject resourceProject = new ResourceProject(val);
								if (((int)input.Type == 127 || EnumUtils.HasFlagF<ResourceTypes>(resourceProject.Types, input.Type)) && (string.IsNullOrEmpty(input.Tag) || ((IEnumerable<JToken>)val["categories"]).Any([SpecialName] (JToken c) => Operators.CompareString(c.ToString(), StringExtensions.AfterLast(input.Tag, "/", false), TextCompare: false) == 0)) && ((int)input.ModLoaders == 0 || flag2 || EnumerableExtensions.Flags<ModLoaders>(resourceProject.ModLoaders).Intersect(EnumerableExtensions.Flags<ModLoaders>(input.ModLoaders)).Any()) && (string.IsNullOrEmpty(input.GameVersion) || resourceProject.UnsafeGameVersions.Any([SpecialName] (string d) => Operators.CompareString(d, input.GameVersion, TextCompare: false) == 0)))
								{
									list9.Add(resourceProject);
								}
							}
							if (list9.Any() && (int)input.ModLoaders != 0 && !flag2 && !string.IsNullOrEmpty(input.GameVersion))
							{
								string arg = EnumerableExtensions.Join((IEnumerable)list9.Select([SpecialName] (ResourceProject p) => p.Id), "\",\"project_id:");
								string arg2 = EnumerableExtensions.Join((IEnumerable)(from f in EnumerableExtensions.Flags<ModLoaders>(input.ModLoaders)
									select StringExtensions.Lower(((Enum)f/*cast due to constrained. prefix*/).ToString())), "\",\"categories:");
								string url = $"https://api.modrinth.com/v2/search?limit={list9.Count}&facets=" + $"[[\"project_id:{arg}\"],[\"categories:{arg2}\"],[\"versions:{input.GameVersion}\"]]";
								List<string> list10 = ((IEnumerable<JToken>)ModDownload.DlModRequest(url)[(object)"hits"]).Select([SpecialName] (JToken h) => h[(object)"project_id"].ToString()).ToList();
								EnumerableExtensions.KeepIf<ResourceProject>((ICollection<ResourceProject>)list9, (Func<ResourceProject, bool>)([SpecialName] (ResourceProject p) => list10.Contains(p.Id)));
							}
							list9.ForEach([SpecialName] (ResourceProject p) =>
							{
								concurrentBag2.Add(p);
							});
							Logger.Info($"从 Modrinth 直接获取到了 {list9.Count} 个工程", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
							list.Clear();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Logger.Warn(ex2, "Modrinth 直接获取失败", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
							concurrentBag.Add((ex2, (ResourcePlatforms)2));
							ProjectData.ClearProjectError();
						}
						if (Task.Progress < 0.75)
						{
							Task.Progress += 0.25;
						}
					}, "Modrinth Get"));
				}
				foreach (Thread item7 in list6)
				{
					item7.Join();
					if (Task.IsCanceled)
					{
						return;
					}
				}
				list5 = new List<ResourceProject>(concurrentBag2);
				if (flag2)
				{
					EnumerableExtensions.KeepIf<ResourceProject>((ICollection<ResourceProject>)list5, (Func<ResourceProject, bool>)([SpecialName] (ResourceProject p) =>
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0009: Unknown result type (might be due to invalid IL or missing references)
						return (int)p.ModLoaders == 0 || EnumUtils.HasFlagF<ModLoaders>(p.ModLoaders, (ModLoaders)1);
					}));
				}
				storage.ErrorMessage = null;
				if (!list5.Any())
				{
					if (concurrentBag.Any())
					{
						throw concurrentBag.First().Ex;
					}
					if (flag && (int)input.Type != 1 && (int)input.Type != 16)
					{
						throw new Exception("无搜索结果，请尝试搜索其英文名称");
					}
					if ((int)input.Sources == 1 && StringExtensions.StartsWithF(input.Tag, "/", false))
					{
						throw new Exception("CurseForge 不兼容所选的类型");
					}
					if ((int)input.Sources == 2 && StringExtensions.EndsWithF(input.Tag, "/", false))
					{
						throw new Exception("Modrinth 不兼容所选的类型");
					}
					throw new Exception("没有搜索结果");
				}
				if (concurrentBag.Any())
				{
					if (concurrentBag.Any([SpecialName] ((Exception Ex, ResourcePlatforms Source) e) =>
					{
						//IL_0001: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Invalid comparison between Unknown and I4
						return (int)e.Source == 1;
					}))
					{
						storage.ErrorMessage = string.Format("无法连接到 CurseForge，所以目前仅显示了来自 Modrinth 的内容，搜索结果可能不全。{0}请稍后再试，或使用 VPN 改善网络环境。", "\r\n");
					}
					else
					{
						storage.ErrorMessage = string.Format("无法连接到 Modrinth，所以目前仅显示了来自 CurseForge 的内容，搜索结果可能不全。{0}请稍后再试，或使用 VPN 改善网络环境。", "\r\n");
					}
				}
			}
			finally
			{
				foreach (Thread item8 in list6)
				{
					if (item8.IsAlive)
					{
						item8.Interrupt();
					}
				}
			}
			list5 = list5.Where([SpecialName] (ResourceProject x) =>
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Invalid comparison between Unknown and I4
				return (int)x.Platform == 1;
			}).Concat(list5.Where([SpecialName] (ResourceProject x) =>
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Invalid comparison between Unknown and I4
				return (int)x.Platform != 1;
			})).ToList();
			list5 = EnumerableExtensions.Distinct<ResourceProject>((IList<ResourceProject>)list5, (Func<ResourceProject, ResourceProject, bool>)([SpecialName] (ResourceProject a, ResourceProject b) => a.IsLike(b))).ToList();
			list5 = list5.Where([SpecialName] (ResourceProject r) => !list4.Any([SpecialName] (ResourceProject b) => r.IsLike(b)) && !storage.Results.Any([SpecialName] (ResourceProject b) => r.IsLike(b))).ToList();
			list4.AddRange(list5);
			Logger.Info($"去重、筛选后累计新增结果 {list4.Count} 个（目前已有结果 {storage.Results.Count} 个）", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
			checked
			{
				if (list4.Count + storage.Results.Count >= input.TargetResultCount)
				{
					break;
				}
				Logger.Info($"总结果数需求最少 {input.TargetResultCount} 个，仅获得了 {list4.Count + storage.Results.Count} 个", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
				if (input.CanContinue && !concurrentBag.Any())
				{
					Logger.Info("将继续尝试加载下一页", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
					continue;
				}
				Logger.Info("无法继续加载，将强制结束", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Modules\\Resource\\ResourceSearcher.vb");
				break;
			}
		}
		Dictionary<ResourceProject, double> dictionary2 = new Dictionary<ResourceProject, double>();
		VB_0024AnonymousDelegate_4<ResourceProject, double> obj3 = [SpecialName] (ResourceProject Project) =>
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Invalid comparison between Unknown and I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Invalid comparison between Unknown and I4
			ResourceTypes type = input.Type;
			if ((int)type <= 4)
			{
				if (type - 1 <= 1)
				{
					return ((int)Project.Platform == 1) ? 1 : 5;
				}
				if ((int)type == 4)
				{
					goto IL_004a;
				}
			}
			else
			{
				if ((int)type == 8)
				{
					goto IL_004a;
				}
				if ((int)type == 16)
				{
					return ((int)Project.Platform != 1) ? 1 : 10;
				}
			}
			return 1.0;
			IL_004a:
			return ((int)Project.Platform == 1) ? 1 : 4;
		};
		if (string.IsNullOrEmpty(text))
		{
			foreach (ResourceProject item9 in list4)
			{
				dictionary2[item9] = (double)item9.DownloadCount * obj3(item9);
			}
		}
		else
		{
			List<ModBase.SearchEntry<ResourceProject>> list7 = new List<ModBase.SearchEntry<ResourceProject>>();
			foreach (ResourceProject item10 in list4)
			{
				dictionary2[item10] = ((item10.WikiId > 0) ? 0.2 : 0.0) + Math.Log10((double)Math.Max(item10.DownloadCount, 1) * obj3(item10)) / 9.0;
				list7.Add(new ModBase.SearchEntry<ResourceProject>
				{
					Item = item10,
					SearchSource = new List<ModBase.SearchSource>
					{
						new ModBase.SearchSource(StringExtensions.Split(flag ? item10.TranslatedName : item10.RawName, '/', true)),
						new ModBase.SearchSource(item10.Description, 0.05)
					}
				});
			}
			List<ModBase.SearchEntry<ResourceProject>> list8 = ModBase.Search(list7, text, 10000, -1.0);
			foreach (ModBase.SearchEntry<ResourceProject> item11 in list8)
			{
				dictionary2[item11.Item] += (item11.AbsoluteRight ? 10.0 : item11.Similarity) / (list8.First().AbsoluteRight ? 10.0 : list8.First().Similarity);
			}
		}
		if (Task.IsCanceled)
		{
			throw new OperationCanceledException();
		}
		storage.Results.AddRange(from r in dictionary2
			orderby r.Value descending
			select r.Key);
	}
}
