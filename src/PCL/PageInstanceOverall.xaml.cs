using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using MeloongCore;
using MeloongCore.Extensions;
using MeloongCore.Wpf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PCL.My;

namespace PCL;

[DesignerGenerated]
public partial class PageInstanceOverall : MyPageRight, IComponentConnector
{
	private bool IsLoad;

	public MyListItem InstanceHeaderItem;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyScrollViewer _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMain")]
	private StackPanel _PanMain;

	[CompilerGenerated]
	[AccessedThroughProperty("PanDisplayItem")]
	private Grid _PanDisplayItem;

	[CompilerGenerated]
	[AccessedThroughProperty("PanDisplay")]
	private MyCard _PanDisplay;

	[CompilerGenerated]
	[AccessedThroughProperty("PanDisplayIcon")]
	private Grid _PanDisplayIcon;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboDisplayLogo")]
	private MyComboBox _ComboDisplayLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("ItemDisplayLogoCustom")]
	private MyComboBoxItem _ItemDisplayLogoCustom;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboDisplayType")]
	private MyComboBox _ComboDisplayType;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnDisplayRename")]
	private MyButton _BtnDisplayRename;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnDisplayDesc")]
	private MyButton _BtnDisplayDesc;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnDisplayStar")]
	private MyButton _BtnDisplayStar;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFolder")]
	private MyCard _PanFolder;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFolderVersion")]
	private MyButton _BtnFolderVersion;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFolderSaves")]
	private MyButton _BtnFolderSaves;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFolderMods")]
	private MyButton _BtnFolderMods;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFolderScreen")]
	private MyButton _BtnFolderScreen;

	[CompilerGenerated]
	[AccessedThroughProperty("PanManage")]
	private MyCard _PanManage;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnManageScript")]
	private MyButton _BtnManageScript;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnManageCheck")]
	private MyButton _BtnManageCheck;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnManageDelete")]
	private MyButton _BtnManageDelete;

	private void Hook_PanBack(MyScrollViewer value)
	{
		_PanBack = value;
		
	}


	private void Hook_PanMain(StackPanel value)
	{
		_PanMain = value;
		
	}


	private void Hook_PanDisplayItem(Grid value)
	{
		_PanDisplayItem = value;
		
	}


	private void Hook_PanDisplay(MyCard value)
	{
		_PanDisplay = value;
		
	}


	private void Hook_PanDisplayIcon(Grid value)
	{
		_PanDisplayIcon = value;
		
	}


	private void Hook_ComboDisplayLogo(MyComboBox value)
	{
		SelectionChangedEventHandler value2 = [SpecialName] (object a0, SelectionChangedEventArgs a1) =>
		{
			ComboDisplayLogo_SelectionChanged();
		};
		MyComboBox myComboBox = _ComboDisplayLogo;
		if (myComboBox != null)
		{
			myComboBox.SelectionChanged -= value2;
		}
		_ComboDisplayLogo = value;
		myComboBox = _ComboDisplayLogo;
		if (myComboBox != null)
		{
			myComboBox.SelectionChanged += value2;
		}
		
	}


	private void Hook_ItemDisplayLogoCustom(MyComboBoxItem value)
	{
		MouseButtonEventHandler value2 = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			ComboDisplayLogo_SelectionChanged();
		};
		MyComboBoxItem myComboBoxItem = _ItemDisplayLogoCustom;
		if (myComboBoxItem != null)
		{
			myComboBoxItem.PreviewMouseLeftButtonUp -= value2;
		}
		_ItemDisplayLogoCustom = value;
		myComboBoxItem = _ItemDisplayLogoCustom;
		if (myComboBoxItem != null)
		{
			myComboBoxItem.PreviewMouseLeftButtonUp += value2;
		}
		
	}


	private void Hook_ComboDisplayType(MyComboBox value)
	{
		SelectionChangedEventHandler value2 = ComboDisplayType_SelectionChanged;
		MyComboBox myComboBox = _ComboDisplayType;
		if (myComboBox != null)
		{
			myComboBox.SelectionChanged -= value2;
		}
		_ComboDisplayType = value;
		myComboBox = _ComboDisplayType;
		if (myComboBox != null)
		{
			myComboBox.SelectionChanged += value2;
		}
		
	}


	private void Hook_BtnDisplayRename(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnDisplayRename_Click;
		MyButton myButton = _BtnDisplayRename;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnDisplayRename = value;
		myButton = _BtnDisplayRename;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnDisplayDesc(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnDisplayDesc_Click;
		MyButton myButton = _BtnDisplayDesc;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnDisplayDesc = value;
		myButton = _BtnDisplayDesc;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnDisplayStar(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnDisplayStar_Click;
		MyButton myButton = _BtnDisplayStar;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnDisplayStar = value;
		myButton = _BtnDisplayStar;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_PanFolder(MyCard value)
	{
		_PanFolder = value;
		
	}


	private void Hook_BtnFolderVersion(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			BtnFolderVersion_Click();
		};
		MyButton myButton = _BtnFolderVersion;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnFolderVersion = value;
		myButton = _BtnFolderVersion;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnFolderSaves(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			BtnFolderSaves_Click();
		};
		MyButton myButton = _BtnFolderSaves;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnFolderSaves = value;
		myButton = _BtnFolderSaves;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnFolderMods(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			BtnFolderMods_Click();
		};
		MyButton myButton = _BtnFolderMods;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnFolderMods = value;
		myButton = _BtnFolderMods;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnFolderScreen(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnFolderScreen_Click;
		MyButton myButton = _BtnFolderScreen;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnFolderScreen = value;
		myButton = _BtnFolderScreen;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_PanManage(MyCard value)
	{
		_PanManage = value;
		
	}


	private void Hook_BtnManageScript(MyButton value)
	{
		MyButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			BtnManageScript_Click();
		};
		MyButton myButton = _BtnManageScript;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnManageScript = value;
		myButton = _BtnManageScript;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnManageCheck(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnManageCheck_Click;
		MyButton myButton = _BtnManageCheck;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnManageCheck = value;
		myButton = _BtnManageCheck;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	private void Hook_BtnManageDelete(MyButton value)
	{
		MyButton.ClickEventHandler obj = BtnManageDelete_Click;
		MyButton myButton = _BtnManageDelete;
		if (myButton != null)
		{
			myButton.Click -= obj;
		}
		_BtnManageDelete = value;
		myButton = _BtnManageDelete;
		if (myButton != null)
		{
			myButton.Click += obj;
		}
		
	}


	public PageInstanceOverall()
	{
		Loaded += PageSetupLaunch_Loaded;
		IsLoad = false;
		InitializeComponent();
			Hook_PanBack(PanBack);
			Hook_PanMain(PanMain);
			Hook_PanDisplayItem(PanDisplayItem);
			Hook_PanDisplay(PanDisplay);
			Hook_PanDisplayIcon(PanDisplayIcon);
			Hook_ComboDisplayLogo(ComboDisplayLogo);
			Hook_ItemDisplayLogoCustom(ItemDisplayLogoCustom);
			Hook_ComboDisplayType(ComboDisplayType);
			Hook_BtnDisplayRename(BtnDisplayRename);
			Hook_BtnDisplayDesc(BtnDisplayDesc);
			Hook_BtnDisplayStar(BtnDisplayStar);
			Hook_PanFolder(PanFolder);
			Hook_BtnFolderVersion(BtnFolderVersion);
			Hook_BtnFolderSaves(BtnFolderSaves);
			Hook_BtnFolderMods(BtnFolderMods);
			Hook_BtnFolderScreen(BtnFolderScreen);
			Hook_PanManage(PanManage);
			Hook_BtnManageScript(BtnManageScript);
			Hook_BtnManageCheck(BtnManageCheck);
			Hook_BtnManageDelete(BtnManageDelete);
	}

	private void PageSetupLaunch_Loaded(object sender, RoutedEventArgs e)
	{
		PanBack.ScrollToHome();
		Reload();
		if (!IsLoad)
		{
			IsLoad = true;
			PanDisplay.TriggerForceResize();
		}
	}

	private void Reload()
	{
		checked
		{
			ModAnimation.AniControlEnabled++;
			ComboDisplayType.SelectedIndex = Conversions.ToInteger(ModBase.ReadIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "DisplayType", Conversions.ToString(0)));
			BtnDisplayStar.Text = (PageInstanceLeft.Instance.IsStar ? "从收藏夹中移除" : "加入收藏夹");
			BtnFolderMods.Visibility = ((!PageInstanceLeft.Instance.Modable) ? Visibility.Collapsed : Visibility.Visible);
			PanDisplayItem.Children.Clear();
			InstanceHeaderItem = PageInstanceLeft.Instance.ToListItem().Init();
			InstanceHeaderItem.IsHitTestVisible = false;
			PanDisplayItem.Children.Add(InstanceHeaderItem);
			ModMain.FrmMain.PageNameRefresh();
			ComboDisplayLogo.SelectedIndex = 0;
			string text = ModBase.ReadIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "Logo");
			if (Conversions.ToBoolean(ModBase.ReadIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "LogoCustom", "False")))
			{
				foreach (MyComboBoxItem item in (IEnumerable)ComboDisplayLogo.Items)
				{
					if (Operators.ConditionalCompareObjectEqual(item.Tag, text, TextCompare: false) || (Operators.ConditionalCompareObjectEqual(item.Tag, "PCL\\Logo.png", TextCompare: false) && StringExtensions.EndsWithF(text, "PCL\\Logo.png", false)))
					{
						ComboDisplayLogo.SelectedItem = item;
						break;
					}
				}
			}
			ModAnimation.AniControlEnabled--;
		}
	}

	private void ComboDisplayType_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (!IsLoad || ModAnimation.AniControlEnabled != 0)
		{
			return;
		}
		if (ComboDisplayType.SelectedIndex != 1)
		{
			try
			{
				ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "DisplayType", Conversions.ToString(ComboDisplayType.SelectedIndex));
				PageInstanceLeft.Instance.DisplayType = (ModMinecraft.McInstanceCardType)Conversions.ToInteger(ModBase.ReadIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "DisplayType", Conversions.ToString(0)));
				ModMain.FrmInstanceLeft.RefreshModDisabled();
				ModBase.WriteIni(ModMinecraft.McFolderSelected + "PCL.ini", "InstanceCache", "");
				ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.Error(ex2, $"修改版本分类失败（{PageInstanceLeft.Instance.Name}）", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
				ProjectData.ClearProjectError();
			}
			Reload();
			return;
		}
		try
		{
			if (!Settings.Get<bool>("HintHide"))
			{
				if (ModMain.MyMsgBox("确认要从版本列表中隐藏该版本吗？隐藏该版本后，它将不再出现于 PCL 显示的版本列表中。\r\n此后，在版本列表页面按下 F11 才可以查看被隐藏的版本。", "隐藏版本提示", "确定", "取消") != 1)
				{
					ComboDisplayType.SelectedIndex = 0;
					return;
				}
				Settings.Set("HintHide", true);
			}
			ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "DisplayType", Conversions.ToString(1));
			ModBase.WriteIni(ModMinecraft.McFolderSelected + "PCL.ini", "InstanceCache", "");
			ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Logger.Error(ex4, $"隐藏版本 {PageInstanceLeft.Instance.Name} 失败", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnDisplayDesc_Click(object sender, EventArgs e)
	{
		try
		{
			string text = ModBase.ReadIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "CustomInfo");
			string text2 = ModMain.MyMsgBoxInput("更改描述", "修改版本的描述文本，留空则使用 PCL 的默认描述。", text, new Collection<ValidateBase>(), "默认描述");
			if (text2 != null && Operators.CompareString(text, text2, TextCompare: false) != 0)
			{
				ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "CustomInfo", text2);
			}
			PageInstanceLeft.Instance = new ModMinecraft.McInstance(PageInstanceLeft.Instance.Name).Load();
			Reload();
			ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, $"版本 {PageInstanceLeft.Instance.Name} 描述更改失败", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnDisplayRename_Click(object sender, EventArgs e)
	{
		try
		{
			if (ModMinecraft.McInstanceLock.IsLocked(PageInstanceLeft.Instance))
			{
				ModMain.Hint("该版本正在被修改，请稍后再重命名！", ModMain.HintType.Red);
				return;
			}
			string name = PageInstanceLeft.Instance.Name;
			string text = ModMain.MyMsgBoxInput("重命名版本", "", name, new Collection<ValidateBase>
			{
				new ValidateFolderName(ModMinecraft.McFolderSelected + "versions", UseMinecraftCharCheck: true, new List<string> { name })
			});
			if (!string.IsNullOrWhiteSpace(text))
			{
				ModMinecraft.McInstance instance = PageInstanceLeft.Instance.Rename(text);
				ModMain.Hint("重命名成功！", ModMain.HintType.Green);
				PageInstanceLeft.Instance = instance;
				if (!Information.IsNothing(ModMinecraft.McInstanceSelected) && ModMinecraft.McInstanceSelected.Equals(PageInstanceLeft.Instance))
				{
					ModBase.WriteIni(ModMinecraft.McFolderSelected + "PCL.ini", "Version", text);
				}
				Reload();
				ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "重命名版本失败", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void ComboDisplayLogo_SelectionChanged()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!IsLoad || ModAnimation.AniControlEnabled != 0)
		{
			return;
		}
		try
		{
			if (ComboDisplayLogo.SelectedItem == ItemDisplayLogoCustom)
			{
				string text = Dialogs.SelectFile("选择图片", false, (string)null, PCL.OneOfHelper.From<IEnumerable<(string[], string)>, string>((IEnumerable<(string[], string)>)new (string[], string)[1] { (new string[5] { "png", "jpeg", "jpg", "gif", "webp" }, "常用图片文件") })).FirstOrDefault();
				if (string.IsNullOrEmpty(text))
				{
					Reload();
					return;
				}
				FileUtils.Copy(text, PageInstanceLeft.Instance.PathVersion + "PCL\\Logo.png");
			}
			else
			{
				FileUtils.Delete(PageInstanceLeft.Instance.PathVersion + "PCL\\Logo.png", false);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, $"更改自定义版本图标失败（{PageInstanceLeft.Instance.Name}）", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = Conversions.ToString(NewLateBinding.LateGet(ComboDisplayLogo.SelectedItem, null, "Tag", new object[0], null, null, null));
			ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "Logo", text2);
			ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "LogoCustom", Conversions.ToString(Operators.CompareString(text2, "", TextCompare: false) != 0));
			ModBase.WriteIni(ModMinecraft.McFolderSelected + "PCL.ini", "InstanceCache", "");
			PageInstanceLeft.Instance = new ModMinecraft.McInstance(PageInstanceLeft.Instance.Name).Load();
			Reload();
			ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Logger.Error(ex4, $"更改版本图标失败（{PageInstanceLeft.Instance.Name}）", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnDisplayStar_Click(object sender, EventArgs e)
	{
		try
		{
			ModBase.WriteIni(PageInstanceLeft.Instance.PathVersion + "PCL\\Setup.ini", "IsStar", Conversions.ToString(!PageInstanceLeft.Instance.IsStar));
			PageInstanceLeft.Instance = new ModMinecraft.McInstance(PageInstanceLeft.Instance.Name).Load();
			Reload();
			ModMinecraft.McInstanceListForceRefresh = true;
			ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, $"版本 {PageInstanceLeft.Instance.Name} 收藏状态更改失败", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnFolderVersion_Click()
	{
		OpenInstanceFolder(PageInstanceLeft.Instance);
	}

	public static void OpenInstanceFolder(ModMinecraft.McInstance Instance)
	{
		ModBase.OpenExplorer(Instance.PathVersion);
	}

	private void BtnFolderSaves_Click()
	{
		string text = PageInstanceLeft.Instance.PathIndie + "saves\\";
		DirectoryUtils.Create(text);
		ModBase.OpenExplorer(text);
	}

	private void BtnFolderMods_Click()
	{
		string text = PageInstanceLeft.Instance.PathIndie + "mods\\";
		DirectoryUtils.Create(text);
		ModBase.OpenExplorer(text);
	}

	private void BtnFolderScreen_Click(object sender, MouseButtonEventArgs e)
	{
		string text = PageInstanceLeft.Instance.PathIndie + "screenshots\\";
		DirectoryUtils.Create(text);
		ModBase.OpenExplorer(text);
	}

	private void BtnManageScript_Click()
	{
		try
		{
			string text = Dialogs.SaveFile("选择脚本保存位置", "启动 " + PageInstanceLeft.Instance.Name + ".bat", (string)null, (IEnumerable<(string, string)>)new (string, string)[1] { ("bat", "批处理文件") });
			if (text == null)
			{
				return;
			}
			if (ModLaunch.McLaunchLoader.State == ModBase.LoadState.Loading)
			{
				ModMain.Hint("请在当前启动任务结束后再试！", ModMain.HintType.Red);
			}
			else if (ModLaunch.McLaunchStart(new ModLaunch.McLaunchOptions
			{
				SaveBatch = text,
				Instance = PageInstanceLeft.Instance
			}))
			{
				if (Settings.Get<ModLaunch.McLoginType>("LoginType") == ModLaunch.McLoginType.Legacy)
				{
					ModMain.Hint("正在导出启动脚本……");
				}
				else
				{
					ModMain.Hint("正在导出启动脚本……（注意，使用脚本启动可能会导致登录失效！）");
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, $"导出启动脚本失败（{PageInstanceLeft.Instance.Name}）", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnManageCheck_Click(object sender, EventArgs e)
	{
		try
		{
			if (ModMinecraft.McInstanceLock.IsLocked(PageInstanceLeft.Instance))
			{
				ModMain.Hint("该版本正在被修改，请稍后再补全文件！", ModMain.HintType.Red);
				return;
			}
			if (Conversions.ToBoolean(ModMinecraft.ShouldIgnoreFileCheck(PageInstanceLeft.Instance)))
			{
				ModMain.Hint("请先关闭 [版本设置 → 设置 → 高级启动选项 → 关闭文件校验]，然后再尝试补全文件！");
				return;
			}
			foreach (ModLoader.LoaderBase item in ModLoader.LoaderTaskbar)
			{
				if (Operators.CompareString(item.Name, PageInstanceLeft.Instance.Name + " 文件补全", TextCompare: false) == 0)
				{
					ModMain.Hint("正在处理中，请稍候！", ModMain.HintType.Red);
					return;
				}
			}
			ModLoader.LoaderCombo<string> loaderCombo = new ModLoader.LoaderCombo<string>(PageInstanceLeft.Instance.Name + " 文件补全", ModDownload.DlClientFix(PageInstanceLeft.Instance, CheckAssetsHash: true, DownloadAssetIndexInBackground: false));
			loaderCombo.OnStateChanged = [SpecialName] (ModLoader.LoaderBase a0) =>
			{
				switch (loaderCombo.State)
				{
				case ModBase.LoadState.Finished:
					ModMain.Hint(loaderCombo.Name + "成功！", ModMain.HintType.Green);
					break;
				case ModBase.LoadState.Failed:
					ModMain.Hint(loaderCombo.Name + "失败：" + ExceptionExtensions.GetDisplay(loaderCombo.Error, false), ModMain.HintType.Red);
					break;
				case ModBase.LoadState.Canceled:
					ModMain.Hint(loaderCombo.Name + "已取消！");
					break;
				}
			};
			loaderCombo.Start(PageInstanceLeft.Instance.Name);
			ModLoader.LoaderTaskbarAdd(loaderCombo);
			ModMain.FrmMain.BtnExtraDownload.ShowRefresh();
			ModMain.FrmMain.BtnExtraDownload.Ribble();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, $"尝试补全文件失败（{PageInstanceLeft.Instance.Name}）", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnManageDelete_Click(object sender, EventArgs e)
	{
		try
		{
			if (ModMinecraft.McInstanceLock.IsLocked(PageInstanceLeft.Instance))
			{
				ModMain.Hint("该版本正在被修改，请稍后再删除！", ModMain.HintType.Red);
				return;
			}
			bool shiftKeyDown = MyWpfExtension.Computer.Keyboard.ShiftKeyDown;
			bool flag = PageInstanceLeft.Instance.State != ModMinecraft.McInstance.McInstanceState.Error && Operators.CompareString(PageInstanceLeft.Instance.PathIndie, ModMinecraft.McFolderSelected, TextCompare: false) != 0;
			DirectoryInfo info = DirectoryUtils.GetInfo(PageInstanceLeft.Instance.PathIndie + "saves\\");
			List<string> list = ((flag && info.Exists) ? (from Save in info.EnumerateDirectories()
				orderby Save.LastWriteTime descending
				select $"{Save.Name}（上次修改：{StringUtils.FormatTimeSpan(Save.LastWriteTime - DateTime.Now, false)}）").ToList() : new List<string>());
			switch (ModMain.MyMsgBox(string.Format("你确定要{0}删除版本 {1} 吗？", shiftKeyDown ? "永久" : "", PageInstanceLeft.Instance.Name) + (flag ? ("\r\n该版本对应的存档、资源包、Mod 等文件也将被一并删除！" + (list.Any() ? ("\r\n\r\n这会删除以下存档：\r\n· " + EnumerableExtensions.Join((IEnumerable)list, "\r\n· ")) : "")) : ""), "版本删除确认", "确定", "取消", "", flag || shiftKeyDown))
			{
			case 1:
				PageInstanceLeft.Instance.ResetSettingsCache();
				DirectoryUtils.Delete(PageInstanceLeft.Instance.PathVersion, !shiftKeyDown);
				ModMain.Hint("已删除版本 " + PageInstanceLeft.Instance.Name + "！", ModMain.HintType.Green);
				break;
			case 2:
				return;
			}
			ModLoader.LoaderFolderRun(ModMinecraft.McInstanceListLoader, ModMinecraft.McFolderSelected, ModLoader.LoaderFolderRunType.ForceRun, 1, "versions\\");
			ModMain.FrmMain.PageBack();
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			Logger.Warn((Exception)ex2, $"删除版本 {PageInstanceLeft.Instance.Name} 被主动取消", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Logger.Error(ex4, $"删除版本 {PageInstanceLeft.Instance.Name} 失败", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageInstance\\PageInstanceOverall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

}
