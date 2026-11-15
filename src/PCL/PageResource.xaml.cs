using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using MeloongCore;
using Microsoft.VisualBasic.CompilerServices;
using PCLCS;

namespace PCL;

[ContentProperty("SearchTags")]
[DesignerGenerated]
public partial class PageResource : MyScrollViewer, IComponentConnector
{
	private string _TypeName;

	private string _TypeNameSpaced;

	private ResourceTypes _Type;

	public static ModMinecraft.McInstance TargetInstance = null;

	public static string TargetName = null;

	public ModLoader.LoaderTask<ResourceSearcher.SearchRequest, int> Loader;

	public ResourceSearcher.SearchResult Storage;

	public const int PAGE_SIZE = 40;

	public int Page;

	[CompilerGenerated]
	[AccessedThroughProperty("PanAlways")]
	private MyCard _PanAlways;

	[CompilerGenerated]
	[AccessedThroughProperty("TextSearchName")]
	private MyTextBox _TextSearchName;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboSearchSource")]
	private MyComboBox _ComboSearchSource;

	[CompilerGenerated]
	[AccessedThroughProperty("TextSearchVersion")]
	private MyComboBox _TextSearchVersion;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboSearchLoader")]
	private MyComboBox _ComboSearchLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboSearchTag")]
	private MyComboBox _ComboSearchTag;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnSearchRun")]
	private MyButton _BtnSearchRun;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnSearchReset")]
	private MyButton _BtnSearchReset;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnSearchInstallModPack")]
	private MyButton _BtnSearchInstallModPack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanContent")]
	private StackPanel _PanContent;

	[CompilerGenerated]
	[AccessedThroughProperty("HintError")]
	private MyHint _HintError;

	[CompilerGenerated]
	[AccessedThroughProperty("CardProjects")]
	private MyCard _CardProjects;

	[CompilerGenerated]
	[AccessedThroughProperty("PanProjects")]
	private StackPanel _PanProjects;

	[CompilerGenerated]
	[AccessedThroughProperty("CardPages")]
	private MyCard _CardPages;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnPageFirst")]
	private MyIconButton _BtnPageFirst;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnPageLeft")]
	private MyIconButton _BtnPageLeft;

	[CompilerGenerated]
	[AccessedThroughProperty("LabPage")]
	private TextBlock _LabPage;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnPageRight")]
	private MyIconButton _BtnPageRight;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLoad")]
	private MyCard _PanLoad;

	[CompilerGenerated]
	[AccessedThroughProperty("Load")]
	private MyLoading _Load;

	[SpecialName]
	private bool _0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init;

	public ItemCollection SearchTags => ComboSearchTag.Items;

	public string TypeName
	{
		get
		{
			return _TypeName;
		}
		set
		{
			if (Operators.CompareString(_TypeName, value, TextCompare: false) != 0)
			{
				_TypeName = value;
				Loader.Name = $"社区资源获取：{value}";
			}
		}
	}

	public string TypeNameSpaced
	{
		get
		{
			return _TypeNameSpaced;
		}
		set
		{
			if (Operators.CompareString(_TypeNameSpaced, value, TextCompare: false) != 0)
			{
				_TypeNameSpaced = value;
				PanAlways.Title = $"搜索{value}";
				Load.Text = $"正在获取{value}列表";
			}
		}
	}

	public ResourceTypes PageType
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _Type;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			if (_Type != value)
			{
				_Type = value;
				BtnSearchInstallModPack.Visibility = (((int)value != 2) ? Visibility.Collapsed : Visibility.Visible);
			}
		}
	}

	private void Hook_PanAlways(MyCard value)
	{
		_PanAlways = value;
		
	}


	private void Hook_TextSearchName(MyTextBox value)
	{
		KeyEventHandler value2 = EnterTrigger;
		MyTextBox myTextBox = _TextSearchName;
		if (myTextBox != null)
		{
			myTextBox.KeyDown -= value2;
		}
		_TextSearchName = value;
		myTextBox = _TextSearchName;
		if (myTextBox != null)
		{
			myTextBox.KeyDown += value2;
		}
		
	}


	private void Hook_ComboSearchSource(MyComboBox value)
	{
		_ComboSearchSource = value;
		
	}


	private void Hook_TextSearchVersion(MyComboBox value)
	{
		KeyEventHandler value2 = EnterTrigger;
		MyComboBox.TextChangedEventHandler obj = [SpecialName] (object a0, TextChangedEventArgs a1) =>
		{
			TextSearchVersion_TextChanged();
		};
		EventHandler value3 = [SpecialName] (object a0, EventArgs a1) =>
		{
			UpdateSearchLoaderVisibility();
		};
		MyComboBox myComboBox = _TextSearchVersion;
		if (myComboBox != null)
		{
			myComboBox.KeyDown -= value2;
			myComboBox.TextChanged -= obj;
			myComboBox.DropDownClosed -= value3;
		}
		_TextSearchVersion = value;
		myComboBox = _TextSearchVersion;
		if (myComboBox != null)
		{
			myComboBox.KeyDown += value2;
			myComboBox.TextChanged += obj;
			myComboBox.DropDownClosed += value3;
		}
		
	}


	private void Hook_ComboSearchLoader(MyComboBox value)
	{
		_ComboSearchLoader = value;
		
	}


	private void Hook_ComboSearchTag(MyComboBox value)
	{
		_ComboSearchTag = value;
		
	}


	private void Hook_BtnSearchRun(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			StartNewSearch();
		};
		MyButton myButton = _BtnSearchRun;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnSearchRun = value;
		myButton = _BtnSearchRun;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnSearchReset(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			ResetFilter();
		};
		MyButton myButton = _BtnSearchReset;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnSearchReset = value;
		myButton = _BtnSearchReset;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnSearchInstallModPack(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnSearchInstallModPack_Click;
		MyButton myButton = _BtnSearchInstallModPack;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnSearchInstallModPack = value;
		myButton = _BtnSearchInstallModPack;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_PanContent(StackPanel value)
	{
		_PanContent = value;
		
	}


	private void Hook_HintError(MyHint value)
	{
		_HintError = value;
		
	}


	private void Hook_CardProjects(MyCard value)
	{
		_CardProjects = value;
		
	}


	private void Hook_PanProjects(StackPanel value)
	{
		_PanProjects = value;
		
	}


	private void Hook_CardPages(MyCard value)
	{
		_CardPages = value;
		
	}


	private void Hook_BtnPageFirst(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = [SpecialName] (object a0, EventArgs a1) =>
		{
			BtnPageFirst_Click(RuntimeHelpers.GetObjectValue(a0), (RoutedEventArgs)a1);
		};
		MyIconButton myIconButton = _BtnPageFirst;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnPageFirst = value;
		myIconButton = _BtnPageFirst;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnPageLeft(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = [SpecialName] (object a0, EventArgs a1) =>
		{
			BtnPageLeft_Click(RuntimeHelpers.GetObjectValue(a0), (RoutedEventArgs)a1);
		};
		MyIconButton myIconButton = _BtnPageLeft;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnPageLeft = value;
		myIconButton = _BtnPageLeft;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_LabPage(TextBlock value)
	{
		_LabPage = value;
		
	}


	private void Hook_BtnPageRight(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = [SpecialName] (object a0, EventArgs a1) =>
		{
			BtnPageRight_Click(RuntimeHelpers.GetObjectValue(a0), (RoutedEventArgs)a1);
		};
		MyIconButton myIconButton = _BtnPageRight;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnPageRight = value;
		myIconButton = _BtnPageRight;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_PanLoad(MyCard value)
	{
		_PanLoad = value;
		
	}


	private void Hook_Load(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = Load_State;
		MyLoading myLoading = _Load;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
		}
		_Load = value;
		myLoading = _Load;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
		}
		
	}


	public PageResource()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Loaded += PageResource_Loaded;
		_TypeName = "";
		_TypeNameSpaced = "";
		_Type = (ResourceTypes)(-1);
		Loader = ResourceSearcher.GetLoader(LoaderInput);
		Storage = new ResourceSearcher.SearchResult();
		Page = 0;
		InitializeComponent();
			Hook_PanAlways(PanAlways);
			Hook_TextSearchName(TextSearchName);
			Hook_ComboSearchSource(ComboSearchSource);
			Hook_TextSearchVersion(TextSearchVersion);
			Hook_ComboSearchLoader(ComboSearchLoader);
			Hook_ComboSearchTag(ComboSearchTag);
			Hook_BtnSearchRun(BtnSearchRun);
			Hook_BtnSearchReset(BtnSearchReset);
			Hook_BtnSearchInstallModPack(BtnSearchInstallModPack);
			Hook_PanContent(PanContent);
			Hook_HintError(HintError);
			Hook_CardProjects(CardProjects);
			Hook_PanProjects(PanProjects);
			Hook_CardPages(CardPages);
			Hook_BtnPageFirst(BtnPageFirst);
			Hook_BtnPageLeft(BtnPageLeft);
			Hook_LabPage(LabPage);
			Hook_BtnPageRight(BtnPageRight);
			Hook_PanLoad(PanLoad);
			Hook_Load(Load);
	}

	private void PageResource_Loaded(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init, ref lockTaken);
			if (_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init.State == 0)
			{
				_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init.State = 2;
				_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded = false;
			}
			else if (_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded_0024Init);
			}
		}
		if ((object)TargetInstance != null)
		{
			ResetFilter();
			TextSearchVersion.Text = TargetInstance.Version.VanillaName;
			VB_0024AnonymousDelegate_12<string, MyComboBoxItem> obj = [SpecialName] (string Name) =>
			{
				foreach (MyComboBoxItem item in (IEnumerable)ComboSearchLoader.Items)
				{
					if (Operators.ConditionalCompareObjectEqual(item.Content, Name, TextCompare: false))
					{
						return item;
					}
				}
				return (MyComboBoxItem)ComboSearchLoader.Items[0];
			};
			if (EnumUtils.HasFlagF<ModLoaders>(TargetInstance.Version.ModLoaders, (ModLoaders)1))
			{
				ComboSearchLoader.SelectedItem = obj("Forge");
			}
			else if (EnumUtils.HasFlagF<ModLoaders>(TargetInstance.Version.ModLoaders, (ModLoaders)4))
			{
				ComboSearchLoader.SelectedItem = obj("Fabric");
			}
			else if (EnumUtils.HasFlagF<ModLoaders>(TargetInstance.Version.ModLoaders, (ModLoaders)16))
			{
				ComboSearchLoader.SelectedItem = obj("NeoForge");
			}
			TargetInstance = null;
			if (TargetName != null)
			{
				TextSearchName.Text = TargetName;
				TargetName = null;
			}
			if (_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded)
			{
				StartNewSearch();
			}
			ScrollToHome();
		}
		if (_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded)
		{
			return;
		}
		_0024STATIC_0024PageResource_Loaded_002420211C128119_0024IsFirstLoaded = true;
		((MyPageRight)Parent).PageLoaderInit(Load, PanLoad, PanContent, PanAlways, Loader, [SpecialName] (ModLoader.LoaderTask<ResourceSearcher.SearchRequest, int> a0) =>
		{
			Load_OnFinish();
		}, LoaderInput);
		if (ModDownload.AllDrops != null && ModDownload.AllDrops.First() > 250)
		{
			string text = McVersion.DropToVersion(ModDownload.AllDrops.First());
			if (Operators.CompareString(((MyComboBoxItem)TextSearchVersion.Items[1]).Content.ToString(), text, TextCompare: false) != 0)
			{
				TextSearchVersion.Items.Insert(1, new MyComboBoxItem
				{
					Content = text
				});
			}
		}
	}

	private ResourceSearcher.SearchRequest LoaderInput()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ResourceSearcher.SearchRequest searchRequest = new ResourceSearcher.SearchRequest(PageType, Storage, (Page + 1) * 40);
			string gameVersion;
			if (Operators.CompareString(TextSearchVersion.Text, "全部 (也可自行输入)", TextCompare: false) != 0)
			{
				gameVersion = ((TextSearchVersion.Text.Contains(".") || TextSearchVersion.Text.Contains("w")) ? TextSearchVersion.Text : null);
			}
			else
			{
				gameVersion = null;
			}
			searchRequest.SearchText = TextSearchName.Text;
			searchRequest.GameVersion = gameVersion;
			searchRequest.Tag = Conversions.ToString(NewLateBinding.LateGet(ComboSearchTag.SelectedItem, null, "Tag", new object[0], null, null, null));
			searchRequest.ModLoaders = (ModLoaders)(int)Math.Round((unchecked((int)PageType) == 1) ? ModBase.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ComboSearchLoader.SelectedItem, null, "Tag", new object[0], null, null, null))) : 0.0);
			searchRequest.Sources = (ResourcePlatforms)(int)Math.Round(ModBase.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ComboSearchSource.SelectedItem, null, "Tag", new object[0], null, null, null))));
			return searchRequest;
		}
	}

	private void Load_OnFinish()
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		checked
		{
			try
			{
				Logger.Info($"开始可视化{TypeNameSpaced}列表，已储藏 {Storage.Results.Count} 个结果，当前在第 {Page + 1} 页", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\PageResource.xaml.vb");
				PanProjects.Children.Clear();
				int num = Math.Min(Page * 40, Storage.Results.Count - 1);
				foreach (ResourceProject item in Storage.Results.GetRange(num, Math.Min(Storage.Results.Count - num, 40)))
				{
					PanProjects.Children.Add(item.ToResourceItem(Loader.Input.GameVersion == null, unchecked((int)Loader.Input.ModLoaders == 0 && ((int)PageType == 1 || (int)PageType == 2))));
				}
				CardPages.Visibility = ((Storage.Results.Count <= 40 && Storage.CurseForgeOffset >= Storage.CurseForgeTotal && Storage.ModrinthOffset >= Storage.ModrinthTotal) ? Visibility.Collapsed : Visibility.Visible);
				LabPage.Text = Conversions.ToString(Page + 1);
				BtnPageFirst.IsEnabled = Page > 1;
				BtnPageFirst.Opacity = ((Page > 1) ? 1.0 : 0.2);
				BtnPageLeft.IsEnabled = Page > 0;
				BtnPageLeft.Opacity = ((Page > 0) ? 1.0 : 0.2);
				bool flag = Storage.Results.Count > 40 * (Page + 1) || Storage.CurseForgeOffset < Storage.CurseForgeTotal || Storage.ModrinthOffset < Storage.ModrinthTotal;
				BtnPageRight.IsEnabled = flag;
				BtnPageRight.Opacity = (flag ? 1.0 : 0.2);
				if (Storage.ErrorMessage == null)
				{
					HintError.Visibility = Visibility.Collapsed;
				}
				else
				{
					HintError.Visibility = Visibility.Visible;
					HintError.Text = Storage.ErrorMessage;
				}
				ScrollToTop();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.Error(ex2, $"可视化{TypeNameSpaced}列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\PageResource.xaml.vb");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Load_State(object sender, MyLoading.MyLoadingState state, MyLoading.MyLoadingState oldState)
	{
		ModBase.LoadState state2 = Loader.State;
		if (state2 == ModBase.LoadState.Failed)
		{
			string text = "";
			if (Loader.Error != null)
			{
				text = Loader.Error.Message;
			}
			if (text.Contains("不是有效的 json 文件"))
			{
				Logger.Warn($"下载的{TypeNameSpaced}列表 json 文件损坏，已自动重试", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\PageResource.xaml.vb");
				((MyPageRight)Parent).PageLoaderRestart();
			}
		}
	}

	private void BtnPageFirst_Click(object sender, RoutedEventArgs e)
	{
		ChangePage(0);
	}

	private void BtnPageLeft_Click(object sender, RoutedEventArgs e)
	{
		ChangePage(checked(Page - 1));
	}

	private void BtnPageRight_Click(object sender, RoutedEventArgs e)
	{
		ChangePage(checked(Page + 1));
	}

	private void ChangePage(int NewPage)
	{
		CardPages.IsEnabled = false;
		Page = NewPage;
		ModMain.FrmMain.BackToTop();
		Logger.Info($"{TypeName}：切换到第 {checked(Page + 1)} 页", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\PageResource.xaml.vb");
		ModBase.RunInThread([SpecialName] () =>
		{
			Thread.Sleep(100);
			ModBase.RunInUi([SpecialName] () =>
			{
				CardPages.IsEnabled = true;
			});
			Loader.Start();
		});
	}

	private void StartNewSearch()
	{
		Page = 0;
		ModLoader.LoaderTask<ResourceSearcher.SearchRequest, int> loader = Loader;
		ResourceSearcher.SearchRequest Input = LoaderInput();
		if (loader.ShouldStart(ref Input))
		{
			Storage = new ResourceSearcher.SearchResult();
		}
		Loader.Start();
	}

	private void EnterTrigger(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			StartNewSearch();
		}
	}

	private void ResetFilter()
	{
		TextSearchName.Text = "";
		TextSearchVersion.Text = "全部 (也可自行输入)";
		TextSearchVersion.SelectedIndex = 0;
		ComboSearchSource.SelectedIndex = 0;
		ComboSearchTag.SelectedIndex = 0;
		ComboSearchLoader.SelectedIndex = 0;
		Loader.LastFinishedTime = 0L;
	}

	private void TextSearchVersion_TextChanged()
	{
		if (!TextSearchVersion.IsDropDownOpen)
		{
			UpdateSearchLoaderVisibility();
		}
	}

	private void UpdateSearchLoaderVisibility()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)PageType == 1 && (TextSearchVersion.Text.Contains(".") || TextSearchVersion.Text.Contains("w")))
		{
			ComboSearchLoader.Visibility = Visibility.Visible;
			Grid.SetColumnSpan(TextSearchVersion, 1);
		}
		else
		{
			ComboSearchLoader.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(TextSearchVersion, 2);
			ComboSearchLoader.SelectedIndex = 0;
		}
	}

	private void BtnSearchInstallModPack_Click(object sender, EventArgs e)
	{
		ModModpack.ModpackInstall();
	}

}
