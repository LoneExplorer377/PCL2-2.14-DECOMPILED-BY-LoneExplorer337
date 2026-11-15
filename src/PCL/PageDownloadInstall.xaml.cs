using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using MeloongCore;
using MeloongCore.Extensions;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PCLCS;

namespace PCL;

[DesignerGenerated]
public partial class PageDownloadInstall : MyPageRight, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	internal new sealed class _Closure_0024__
	{
		public static readonly _Closure_0024__ _0024I;

		public static Func<JObject, DateTime> _0024I35_002D0;

		public static Func<ModDownload.DlOptiFineListEntry, ModDownload.DlOptiFineListEntry, bool> _0024I41_002D0;

		public static Func<ModDownload.DlForgeVersionEntry, ModDownload.DlForgeVersionEntry> _0024I51_002D1;

		public static Func<ResourceVersion, DateTime> _0024I68_002D0;

		public static Func<ResourceVersion, DateTime> _0024I75_002D0;

		static _Closure_0024__()
		{
			_0024I = new _Closure_0024__();
		}

		[SpecialName]
		internal DateTime _Lambda_0024__35_002D0(JObject j)
		{
			return Extensions.Value<DateTime>((IEnumerable<JToken>)j["releaseTime"]);
		}

		[SpecialName]
		internal bool _Lambda_0024__41_002D0(ModDownload.DlOptiFineListEntry Left, ModDownload.DlOptiFineListEntry Right)
		{
			if (!Left.IsPreview && Right.IsPreview)
			{
				return true;
			}
			if (Left.IsPreview && !Right.IsPreview)
			{
				return false;
			}
			return McUtils.CompareVersionGE(Left.DisplayName, Right.DisplayName);
		}

		[SpecialName]
		internal ModDownload.DlForgeVersionEntry _Lambda_0024__51_002D1(ModDownload.DlForgeVersionEntry v)
		{
			return v;
		}

		[SpecialName]
		internal DateTime _Lambda_0024__68_002D0(ResourceVersion v)
		{
			return v.ReleaseDate;
		}

		[SpecialName]
		internal DateTime _Lambda_0024__75_002D0(ResourceVersion v)
		{
			return v.ReleaseDate;
		}
	}

	private bool IsLoad;

	public bool IsInSelectPage;

	public string VanillaName;

	public JObject VanillaData;

	public string VanillaIcon;

	public ModDownload.DlOptiFineListEntry SelectedOptiFine;

	public ModDownload.DlLiteLoaderListEntry SelectedLiteLoader;

	public ModDownload.DlForgeVersionEntry SelectedForge;

	public ModDownload.DlNeoForgeListEntry SelectedNeoForge;

	public string SelectedFabric;

	public ResourceVersion SelectedFabricApi;

	public ResourceVersion SelectedOptiFabric;

	public bool IsSelectNameEdited;

	public JArray MinecraftVersions;

	public static string VersionWaitingSelect = null;

	public bool AutoSelectedFabricApi;

	public bool AutoSelectedOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanAllBack")]
	private Grid _PanAllBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyScrollViewer _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanInner")]
	private Grid _PanInner;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMinecraft")]
	private StackPanel _PanMinecraft;

	[CompilerGenerated]
	[AccessedThroughProperty("PanSelect")]
	private StackPanel _PanSelect;

	[CompilerGenerated]
	[AccessedThroughProperty("CardSelectName")]
	private MyCard _CardSelectName;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnBack")]
	private MyIconButton _BtnBack;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgLogo")]
	private MyImage _ImgLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("TextSelectName")]
	private MyTextBox _TextSelectName;

	[CompilerGenerated]
	[AccessedThroughProperty("LabSelectName")]
	private TextBlock _LabSelectName;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnOriginalNameRestore")]
	private MyIconButton _BtnOriginalNameRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("HintSelectName")]
	private MyHint _HintSelectName;

	[CompilerGenerated]
	[AccessedThroughProperty("HintFabricAPI")]
	private MyHint _HintFabricAPI;

	[CompilerGenerated]
	[AccessedThroughProperty("HintOptiFabric")]
	private MyHint _HintOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("HintOptiFabricOld")]
	private MyHint _HintOptiFabricOld;

	[CompilerGenerated]
	[AccessedThroughProperty("HintModOptiFine")]
	private MyHint _HintModOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("CardMinecraft")]
	private MyCard _CardMinecraft;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMinecraftInfo")]
	private Grid _PanMinecraftInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgMinecraft")]
	private MyImage _ImgMinecraft;

	[CompilerGenerated]
	[AccessedThroughProperty("LabMinecraftVersion")]
	private TextBlock _LabMinecraftVersion;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMinecraftCompare")]
	private Grid _PanMinecraftCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgMinecraftOld")]
	private MyImage _ImgMinecraftOld;

	[CompilerGenerated]
	[AccessedThroughProperty("LabMinecraftOld")]
	private TextBlock _LabMinecraftOld;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgMinecraftNew")]
	private MyImage _ImgMinecraftNew;

	[CompilerGenerated]
	[AccessedThroughProperty("LabMinecraftNew")]
	private TextBlock _LabMinecraftNew;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnMinecraftRestore")]
	private MyIconButton _BtnMinecraftRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardForge")]
	private MyCard _CardForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanForge")]
	private StackPanel _PanForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanForgeInfo")]
	private Grid _PanForgeInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgForge")]
	private MyImage _ImgForge;

	[CompilerGenerated]
	[AccessedThroughProperty("LabForge")]
	private TextBlock _LabForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanForgeCompare")]
	private Grid _PanForgeCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabForgeOld")]
	private TextBlock _LabForgeOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnForgeClear")]
	private MyIconButton _BtnForgeClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnForgeRestore")]
	private MyIconButton _BtnForgeRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardNeoForge")]
	private MyCard _CardNeoForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanNeoForge")]
	private StackPanel _PanNeoForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanNeoForgeInfo")]
	private Grid _PanNeoForgeInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgNeoForge")]
	private MyImage _ImgNeoForge;

	[CompilerGenerated]
	[AccessedThroughProperty("LabNeoForge")]
	private TextBlock _LabNeoForge;

	[CompilerGenerated]
	[AccessedThroughProperty("PanNeoForgeCompare")]
	private Grid _PanNeoForgeCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabNeoForgeOld")]
	private TextBlock _LabNeoForgeOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnNeoForgeClear")]
	private MyIconButton _BtnNeoForgeClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnNeoForgeRestore")]
	private MyIconButton _BtnNeoForgeRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardFabric")]
	private MyCard _CardFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabric")]
	private StackPanel _PanFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabricInfo")]
	private Grid _PanFabricInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgFabric")]
	private MyImage _ImgFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("LabFabric")]
	private TextBlock _LabFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabricCompare")]
	private Grid _PanFabricCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabFabricOld")]
	private TextBlock _LabFabricOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFabricClear")]
	private MyIconButton _BtnFabricClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFabricRestore")]
	private MyIconButton _BtnFabricRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardFabricApi")]
	private MyCard _CardFabricApi;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabricApi")]
	private StackPanel _PanFabricApi;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabricApiInfo")]
	private Grid _PanFabricApiInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgFabricApi")]
	private MyImage _ImgFabricApi;

	[CompilerGenerated]
	[AccessedThroughProperty("LabFabricApi")]
	private TextBlock _LabFabricApi;

	[CompilerGenerated]
	[AccessedThroughProperty("PanFabricApiCompare")]
	private Grid _PanFabricApiCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabFabricApiOld")]
	private TextBlock _LabFabricApiOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFabricApiClear")]
	private MyIconButton _BtnFabricApiClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFabricApiRestore")]
	private MyIconButton _BtnFabricApiRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardOptiFine")]
	private MyCard _CardOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFine")]
	private StackPanel _PanOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFineInfo")]
	private Grid _PanOptiFineInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgOptiFine")]
	private MyImage _ImgOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("LabOptiFine")]
	private TextBlock _LabOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFineCompare")]
	private Grid _PanOptiFineCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabOptiFineOld")]
	private TextBlock _LabOptiFineOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnOptiFineClear")]
	private MyIconButton _BtnOptiFineClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnOptiFineRestore")]
	private MyIconButton _BtnOptiFineRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardOptiFabric")]
	private MyCard _CardOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFabric")]
	private StackPanel _PanOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFabricInfo")]
	private Grid _PanOptiFabricInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgOptiFabric")]
	private MyImage _ImgOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("LabOptiFabric")]
	private TextBlock _LabOptiFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("PanOptiFabricCompare")]
	private Grid _PanOptiFabricCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabOptiFabricOld")]
	private TextBlock _LabOptiFabricOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnOptiFabricClear")]
	private MyIconButton _BtnOptiFabricClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnOptiFabricRestore")]
	private MyIconButton _BtnOptiFabricRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("CardLiteLoader")]
	private MyCard _CardLiteLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLiteLoader")]
	private StackPanel _PanLiteLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLiteLoaderInfo")]
	private Grid _PanLiteLoaderInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ImgLiteLoader")]
	private MyImage _ImgLiteLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLiteLoader")]
	private TextBlock _LabLiteLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLiteLoaderCompare")]
	private Grid _PanLiteLoaderCompare;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLiteLoaderOld")]
	private TextBlock _LabLiteLoaderOld;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnLiteLoaderClear")]
	private MyIconButton _BtnLiteLoaderClear;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnLiteLoaderRestore")]
	private MyIconButton _BtnLiteLoaderRestore;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnStart")]
	private MyExtraTextButton _BtnStart;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLoad")]
	private MyCard _PanLoad;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadMinecraft")]
	private MyLoading _LoadMinecraft;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadOptiFine")]
	private MyLoading _LoadOptiFine;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadForge")]
	private MyLoading _LoadForge;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadNeoForge")]
	private MyLoading _LoadNeoForge;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadLiteLoader")]
	private MyLoading _LoadLiteLoader;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadFabric")]
	private MyLoading _LoadFabric;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadFabricApi")]
	private MyLoading _LoadFabricApi;

	[CompilerGenerated]
	[AccessedThroughProperty("LoadOptiFabric")]
	private MyLoading _LoadOptiFabric;

	[SpecialName]
	private bool _0024STATIC_0024ReloadSelected_00242001_0024Ongoing;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init;

	private int VanillaDrop => McVersion.VersionToDrop(VanillaName);

	private void Hook_PanAllBack(Grid value)
	{
		_PanAllBack = value;
		
	}


	private void Hook_PanBack(MyScrollViewer value)
	{
		_PanBack = value;
		
	}


	private void Hook_PanInner(Grid value)
	{
		_PanInner = value;
		
	}


	private void Hook_PanMinecraft(StackPanel value)
	{
		_PanMinecraft = value;
		
	}


	private void Hook_PanSelect(StackPanel value)
	{
		_PanSelect = value;
		
	}


	private void Hook_CardSelectName(MyCard value)
	{
		_CardSelectName = value;
		
	}


	private void Hook_BtnBack(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = [SpecialName] (object a0, EventArgs a1) =>
		{
			ExitSelectPage();
		};
		MyIconButton myIconButton = _BtnBack;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnBack = value;
		myIconButton = _BtnBack;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_ImgLogo(MyImage value)
	{
		_ImgLogo = value;
		
	}


	private void Hook_TextSelectName(MyTextBox value)
	{
		TextChangedEventHandler value2 = TextSelectName_TextChanged;
		MyTextBox.ValidateChangedEventHandler obj = TextSelectName_ValidateChanged;
		KeyEventHandler value3 = TextSelectName_KeyDown;
		MyTextBox myTextBox = _TextSelectName;
		if (myTextBox != null)
		{
			myTextBox.TextChanged -= value2;
			MyTextBox.ValidateChanged -= obj;
			myTextBox.KeyDown -= value3;
		}
		_TextSelectName = value;
		myTextBox = _TextSelectName;
		if (myTextBox != null)
		{
			myTextBox.TextChanged += value2;
			MyTextBox.ValidateChanged += obj;
			myTextBox.KeyDown += value3;
		}
		
	}


	private void Hook_LabSelectName(TextBlock value)
	{
		_LabSelectName = value;
		
	}


	private void Hook_BtnOriginalNameRestore(MyIconButton value)
	{
		_BtnOriginalNameRestore = value;
		
	}


	private void Hook_HintSelectName(MyHint value)
	{
		_HintSelectName = value;
		
	}


	private void Hook_HintFabricAPI(MyHint value)
	{
		_HintFabricAPI = value;
		
	}


	private void Hook_HintOptiFabric(MyHint value)
	{
		_HintOptiFabric = value;
		
	}


	private void Hook_HintOptiFabricOld(MyHint value)
	{
		_HintOptiFabricOld = value;
		
	}


	private void Hook_HintModOptiFine(MyHint value)
	{
		_HintModOptiFine = value;
		
	}


	private void Hook_CardMinecraft(MyCard value)
	{
		_CardMinecraft = value;
		
	}


	private void Hook_PanMinecraftInfo(Grid value)
	{
		_PanMinecraftInfo = value;
		
	}


	private void Hook_ImgMinecraft(MyImage value)
	{
		_ImgMinecraft = value;
		
	}


	private void Hook_LabMinecraftVersion(TextBlock value)
	{
		_LabMinecraftVersion = value;
		
	}


	private void Hook_PanMinecraftCompare(Grid value)
	{
		_PanMinecraftCompare = value;
		
	}


	private void Hook_ImgMinecraftOld(MyImage value)
	{
		_ImgMinecraftOld = value;
		
	}


	private void Hook_LabMinecraftOld(TextBlock value)
	{
		_LabMinecraftOld = value;
		
	}


	private void Hook_ImgMinecraftNew(MyImage value)
	{
		_ImgMinecraftNew = value;
		
	}


	private void Hook_LabMinecraftNew(TextBlock value)
	{
		_LabMinecraftNew = value;
		
	}


	private void Hook_BtnMinecraftRestore(MyIconButton value)
	{
		_BtnMinecraftRestore = value;
		
	}


	private void Hook_CardForge(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardForge_PreviewSwap;
		MyCard myCard = _CardForge;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardForge = value;
		myCard = _CardForge;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanForge(StackPanel value)
	{
		_PanForge = value;
		
	}


	private void Hook_PanForgeInfo(Grid value)
	{
		_PanForgeInfo = value;
		
	}


	private void Hook_ImgForge(MyImage value)
	{
		_ImgForge = value;
		
	}


	private void Hook_LabForge(TextBlock value)
	{
		_LabForge = value;
		
	}


	private void Hook_PanForgeCompare(Grid value)
	{
		_PanForgeCompare = value;
		
	}


	private void Hook_LabForgeOld(TextBlock value)
	{
		_LabForgeOld = value;
		
	}


	private void Hook_BtnForgeClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = Forge_Clear;
		MyIconButton myIconButton = _BtnForgeClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnForgeClear = value;
		myIconButton = _BtnForgeClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnForgeRestore(MyIconButton value)
	{
		_BtnForgeRestore = value;
		
	}


	private void Hook_CardNeoForge(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardNeoForge_PreviewSwap;
		MyCard myCard = _CardNeoForge;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardNeoForge = value;
		myCard = _CardNeoForge;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanNeoForge(StackPanel value)
	{
		_PanNeoForge = value;
		
	}


	private void Hook_PanNeoForgeInfo(Grid value)
	{
		_PanNeoForgeInfo = value;
		
	}


	private void Hook_ImgNeoForge(MyImage value)
	{
		_ImgNeoForge = value;
		
	}


	private void Hook_LabNeoForge(TextBlock value)
	{
		_LabNeoForge = value;
		
	}


	private void Hook_PanNeoForgeCompare(Grid value)
	{
		_PanNeoForgeCompare = value;
		
	}


	private void Hook_LabNeoForgeOld(TextBlock value)
	{
		_LabNeoForgeOld = value;
		
	}


	private void Hook_BtnNeoForgeClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = NeoForge_Clear;
		MyIconButton myIconButton = _BtnNeoForgeClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnNeoForgeClear = value;
		myIconButton = _BtnNeoForgeClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnNeoForgeRestore(MyIconButton value)
	{
		_BtnNeoForgeRestore = value;
		
	}


	private void Hook_CardFabric(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardFabric_PreviewSwap;
		MyCard myCard = _CardFabric;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardFabric = value;
		myCard = _CardFabric;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanFabric(StackPanel value)
	{
		_PanFabric = value;
		
	}


	private void Hook_PanFabricInfo(Grid value)
	{
		_PanFabricInfo = value;
		
	}


	private void Hook_ImgFabric(MyImage value)
	{
		_ImgFabric = value;
		
	}


	private void Hook_LabFabric(TextBlock value)
	{
		_LabFabric = value;
		
	}


	private void Hook_PanFabricCompare(Grid value)
	{
		_PanFabricCompare = value;
		
	}


	private void Hook_LabFabricOld(TextBlock value)
	{
		_LabFabricOld = value;
		
	}


	private void Hook_BtnFabricClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = Fabric_Clear;
		MyIconButton myIconButton = _BtnFabricClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnFabricClear = value;
		myIconButton = _BtnFabricClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnFabricRestore(MyIconButton value)
	{
		_BtnFabricRestore = value;
		
	}


	private void Hook_CardFabricApi(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardFabricApi_PreviewSwap;
		MyCard myCard = _CardFabricApi;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardFabricApi = value;
		myCard = _CardFabricApi;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanFabricApi(StackPanel value)
	{
		_PanFabricApi = value;
		
	}


	private void Hook_PanFabricApiInfo(Grid value)
	{
		_PanFabricApiInfo = value;
		
	}


	private void Hook_ImgFabricApi(MyImage value)
	{
		_ImgFabricApi = value;
		
	}


	private void Hook_LabFabricApi(TextBlock value)
	{
		_LabFabricApi = value;
		
	}


	private void Hook_PanFabricApiCompare(Grid value)
	{
		_PanFabricApiCompare = value;
		
	}


	private void Hook_LabFabricApiOld(TextBlock value)
	{
		_LabFabricApiOld = value;
		
	}


	private void Hook_BtnFabricApiClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = FabricApi_Clear;
		MyIconButton myIconButton = _BtnFabricApiClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnFabricApiClear = value;
		myIconButton = _BtnFabricApiClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnFabricApiRestore(MyIconButton value)
	{
		_BtnFabricApiRestore = value;
		
	}


	private void Hook_CardOptiFine(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardOptiFine_PreviewSwap;
		MyCard myCard = _CardOptiFine;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardOptiFine = value;
		myCard = _CardOptiFine;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanOptiFine(StackPanel value)
	{
		_PanOptiFine = value;
		
	}


	private void Hook_PanOptiFineInfo(Grid value)
	{
		_PanOptiFineInfo = value;
		
	}


	private void Hook_ImgOptiFine(MyImage value)
	{
		_ImgOptiFine = value;
		
	}


	private void Hook_LabOptiFine(TextBlock value)
	{
		_LabOptiFine = value;
		
	}


	private void Hook_PanOptiFineCompare(Grid value)
	{
		_PanOptiFineCompare = value;
		
	}


	private void Hook_LabOptiFineOld(TextBlock value)
	{
		_LabOptiFineOld = value;
		
	}


	private void Hook_BtnOptiFineClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = OptiFine_Clear;
		MyIconButton myIconButton = _BtnOptiFineClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnOptiFineClear = value;
		myIconButton = _BtnOptiFineClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnOptiFineRestore(MyIconButton value)
	{
		_BtnOptiFineRestore = value;
		
	}


	private void Hook_CardOptiFabric(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardOptiFabric_PreviewSwap;
		MyCard myCard = _CardOptiFabric;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardOptiFabric = value;
		myCard = _CardOptiFabric;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanOptiFabric(StackPanel value)
	{
		_PanOptiFabric = value;
		
	}


	private void Hook_PanOptiFabricInfo(Grid value)
	{
		_PanOptiFabricInfo = value;
		
	}


	private void Hook_ImgOptiFabric(MyImage value)
	{
		_ImgOptiFabric = value;
		
	}


	private void Hook_LabOptiFabric(TextBlock value)
	{
		_LabOptiFabric = value;
		
	}


	private void Hook_PanOptiFabricCompare(Grid value)
	{
		_PanOptiFabricCompare = value;
		
	}


	private void Hook_LabOptiFabricOld(TextBlock value)
	{
		_LabOptiFabricOld = value;
		
	}


	private void Hook_BtnOptiFabricClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = OptiFabric_Clear;
		MyIconButton myIconButton = _BtnOptiFabricClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnOptiFabricClear = value;
		myIconButton = _BtnOptiFabricClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnOptiFabricRestore(MyIconButton value)
	{
		_BtnOptiFabricRestore = value;
		
	}


	private void Hook_CardLiteLoader(MyCard value)
	{
		MyCard.SwapEventHandler obj = [SpecialName] (object a0, ModBase.RouteEventArgs a1) =>
		{
			ReloadSelected();
		};
		MyCard.PreviewSwapEventHandler obj2 = CardLiteLoader_PreviewSwap;
		MyCard myCard = _CardLiteLoader;
		if (myCard != null)
		{
			myCard.Swap -= obj;
			myCard.PreviewSwap -= obj2;
		}
		_CardLiteLoader = value;
		myCard = _CardLiteLoader;
		if (myCard != null)
		{
			myCard.Swap += obj;
			myCard.PreviewSwap += obj2;
		}
		
	}


	private void Hook_PanLiteLoader(StackPanel value)
	{
		_PanLiteLoader = value;
		
	}


	private void Hook_PanLiteLoaderInfo(Grid value)
	{
		_PanLiteLoaderInfo = value;
		
	}


	private void Hook_ImgLiteLoader(MyImage value)
	{
		_ImgLiteLoader = value;
		
	}


	private void Hook_LabLiteLoader(TextBlock value)
	{
		_LabLiteLoader = value;
		
	}


	private void Hook_PanLiteLoaderCompare(Grid value)
	{
		_PanLiteLoaderCompare = value;
		
	}


	private void Hook_LabLiteLoaderOld(TextBlock value)
	{
		_LabLiteLoaderOld = value;
		
	}


	private void Hook_BtnLiteLoaderClear(MyIconButton value)
	{
		MyIconButton.ClickEventHandler obj = LiteLoader_Clear;
		MyIconButton myIconButton = _BtnLiteLoaderClear;
		if (myIconButton != null)
		{
			myIconButton.Click -= obj;
		}
		_BtnLiteLoaderClear = value;
		myIconButton = _BtnLiteLoaderClear;
		if (myIconButton != null)
		{
			myIconButton.Click += obj;
		}
		
	}


	private void Hook_BtnLiteLoaderRestore(MyIconButton value)
	{
		_BtnLiteLoaderRestore = value;
		
	}


	private void Hook_BtnStart(MyExtraTextButton value)
	{
		MyExtraTextButton.ClickEventHandler obj = [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			BtnStart_Click();
		};
		MyExtraTextButton myExtraTextButton = _BtnStart;
		if (myExtraTextButton != null)
		{
			myExtraTextButton.Click -= obj;
		}
		_BtnStart = value;
		myExtraTextButton = _BtnStart;
		if (myExtraTextButton != null)
		{
			myExtraTextButton.Click += obj;
		}
		
	}


	private void Hook_PanLoad(MyCard value)
	{
		_PanLoad = value;
		
	}


	private void Hook_LoadMinecraft(MyLoading value)
	{
		_LoadMinecraft = value;
		
	}


	private void Hook_LoadOptiFine(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			OptiFine_Loaded();
		};
		MyLoading myLoading = _LoadOptiFine;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadOptiFine = value;
		myLoading = _LoadOptiFine;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadForge(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			Forge_Loaded();
		};
		MyLoading myLoading = _LoadForge;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadForge = value;
		myLoading = _LoadForge;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadNeoForge(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			NeoForge_Loaded();
		};
		MyLoading myLoading = _LoadNeoForge;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadNeoForge = value;
		myLoading = _LoadNeoForge;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadLiteLoader(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			LiteLoader_Loaded();
		};
		MyLoading myLoading = _LoadLiteLoader;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadLiteLoader = value;
		myLoading = _LoadLiteLoader;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadFabric(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			Fabric_Loaded();
		};
		MyLoading myLoading = _LoadFabric;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadFabric = value;
		myLoading = _LoadFabric;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadFabricApi(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			FabricApi_Loaded();
		};
		MyLoading myLoading = _LoadFabricApi;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadFabricApi = value;
		myLoading = _LoadFabricApi;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	private void Hook_LoadOptiFabric(MyLoading value)
	{
		MyLoading.StateChangedEventHandler obj = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			ReloadSelected();
		};
		MyLoading.StateChangedEventHandler obj2 = [SpecialName] (object a0, MyLoading.MyLoadingState a1, MyLoading.MyLoadingState a2) =>
		{
			OptiFabric_Loaded();
		};
		MyLoading myLoading = _LoadOptiFabric;
		if (myLoading != null)
		{
			myLoading.StateChanged -= obj;
			myLoading.StateChanged -= obj2;
		}
		_LoadOptiFabric = value;
		myLoading = _LoadOptiFabric;
		if (myLoading != null)
		{
			myLoading.StateChanged += obj;
			myLoading.StateChanged += obj2;
		}
		
	}


	public PageDownloadInstall()
	{
		Initialized += [SpecialName] (object a0, EventArgs a1) =>
		{
			LoaderInit();
		};
		Loaded += [SpecialName] (object a0, RoutedEventArgs a1) =>
		{
			Init();
		};
		IsLoad = false;
		IsInSelectPage = false;
		SelectedOptiFine = null;
		SelectedLiteLoader = null;
		SelectedForge = null;
		SelectedNeoForge = null;
		SelectedFabric = null;
		SelectedFabricApi = null;
		SelectedOptiFabric = null;
		IsSelectNameEdited = false;
		AutoSelectedFabricApi = false;
		AutoSelectedOptiFabric = false;
		InitializeComponent();
			Hook_PanAllBack(PanAllBack);
			Hook_PanBack(PanBack);
			Hook_PanInner(PanInner);
			Hook_PanMinecraft(PanMinecraft);
			Hook_PanSelect(PanSelect);
			Hook_CardSelectName(CardSelectName);
			Hook_BtnBack(BtnBack);
			Hook_ImgLogo(ImgLogo);
			Hook_TextSelectName(TextSelectName);
			Hook_LabSelectName(LabSelectName);
			Hook_BtnOriginalNameRestore(BtnOriginalNameRestore);
			Hook_HintSelectName(HintSelectName);
			Hook_HintFabricAPI(HintFabricAPI);
			Hook_HintOptiFabric(HintOptiFabric);
			Hook_HintOptiFabricOld(HintOptiFabricOld);
			Hook_HintModOptiFine(HintModOptiFine);
			Hook_CardMinecraft(CardMinecraft);
			Hook_PanMinecraftInfo(PanMinecraftInfo);
			Hook_ImgMinecraft(ImgMinecraft);
			Hook_LabMinecraftVersion(LabMinecraftVersion);
			Hook_PanMinecraftCompare(PanMinecraftCompare);
			Hook_ImgMinecraftOld(ImgMinecraftOld);
			Hook_LabMinecraftOld(LabMinecraftOld);
			Hook_ImgMinecraftNew(ImgMinecraftNew);
			Hook_LabMinecraftNew(LabMinecraftNew);
			Hook_BtnMinecraftRestore(BtnMinecraftRestore);
			Hook_CardForge(CardForge);
			Hook_PanForge(PanForge);
			Hook_PanForgeInfo(PanForgeInfo);
			Hook_ImgForge(ImgForge);
			Hook_LabForge(LabForge);
			Hook_PanForgeCompare(PanForgeCompare);
			Hook_LabForgeOld(LabForgeOld);
			Hook_BtnForgeClear(BtnForgeClear);
			Hook_BtnForgeRestore(BtnForgeRestore);
			Hook_CardNeoForge(CardNeoForge);
			Hook_PanNeoForge(PanNeoForge);
			Hook_PanNeoForgeInfo(PanNeoForgeInfo);
			Hook_ImgNeoForge(ImgNeoForge);
			Hook_LabNeoForge(LabNeoForge);
			Hook_PanNeoForgeCompare(PanNeoForgeCompare);
			Hook_LabNeoForgeOld(LabNeoForgeOld);
			Hook_BtnNeoForgeClear(BtnNeoForgeClear);
			Hook_BtnNeoForgeRestore(BtnNeoForgeRestore);
			Hook_CardFabric(CardFabric);
			Hook_PanFabric(PanFabric);
			Hook_PanFabricInfo(PanFabricInfo);
			Hook_ImgFabric(ImgFabric);
			Hook_LabFabric(LabFabric);
			Hook_PanFabricCompare(PanFabricCompare);
			Hook_LabFabricOld(LabFabricOld);
			Hook_BtnFabricClear(BtnFabricClear);
			Hook_BtnFabricRestore(BtnFabricRestore);
			Hook_CardFabricApi(CardFabricApi);
			Hook_PanFabricApi(PanFabricApi);
			Hook_PanFabricApiInfo(PanFabricApiInfo);
			Hook_ImgFabricApi(ImgFabricApi);
			Hook_LabFabricApi(LabFabricApi);
			Hook_PanFabricApiCompare(PanFabricApiCompare);
			Hook_LabFabricApiOld(LabFabricApiOld);
			Hook_BtnFabricApiClear(BtnFabricApiClear);
			Hook_BtnFabricApiRestore(BtnFabricApiRestore);
			Hook_CardOptiFine(CardOptiFine);
			Hook_PanOptiFine(PanOptiFine);
			Hook_PanOptiFineInfo(PanOptiFineInfo);
			Hook_ImgOptiFine(ImgOptiFine);
			Hook_LabOptiFine(LabOptiFine);
			Hook_PanOptiFineCompare(PanOptiFineCompare);
			Hook_LabOptiFineOld(LabOptiFineOld);
			Hook_BtnOptiFineClear(BtnOptiFineClear);
			Hook_BtnOptiFineRestore(BtnOptiFineRestore);
			Hook_CardOptiFabric(CardOptiFabric);
			Hook_PanOptiFabric(PanOptiFabric);
			Hook_PanOptiFabricInfo(PanOptiFabricInfo);
			Hook_ImgOptiFabric(ImgOptiFabric);
			Hook_LabOptiFabric(LabOptiFabric);
			Hook_PanOptiFabricCompare(PanOptiFabricCompare);
			Hook_LabOptiFabricOld(LabOptiFabricOld);
			Hook_BtnOptiFabricClear(BtnOptiFabricClear);
			Hook_BtnOptiFabricRestore(BtnOptiFabricRestore);
			Hook_CardLiteLoader(CardLiteLoader);
			Hook_PanLiteLoader(PanLiteLoader);
			Hook_PanLiteLoaderInfo(PanLiteLoaderInfo);
			Hook_ImgLiteLoader(ImgLiteLoader);
			Hook_LabLiteLoader(LabLiteLoader);
			Hook_PanLiteLoaderCompare(PanLiteLoaderCompare);
			Hook_LabLiteLoaderOld(LabLiteLoaderOld);
			Hook_BtnLiteLoaderClear(BtnLiteLoaderClear);
			Hook_BtnLiteLoaderRestore(BtnLiteLoaderRestore);
			Hook_BtnStart(BtnStart);
			Hook_PanLoad(PanLoad);
			Hook_LoadMinecraft(LoadMinecraft);
			Hook_LoadOptiFine(LoadOptiFine);
			Hook_LoadForge(LoadForge);
			Hook_LoadNeoForge(LoadNeoForge);
			Hook_LoadLiteLoader(LoadLiteLoader);
			Hook_LoadFabric(LoadFabric);
			Hook_LoadFabricApi(LoadFabricApi);
			Hook_LoadOptiFabric(LoadOptiFabric);
	}

	public void ControlInit()
	{
		DisabledPageAnimControls.Add(BtnStart);
		LoadOptiFine.State = ModDownload.DlOptiFineListLoader;
		LoadLiteLoader.State = ModDownload.DlLiteLoaderListLoader;
		LoadFabric.State = ModDownload.DlFabricListLoader;
		LoadFabricApi.State = ModDownload.DlFabricApiLoader;
		LoadNeoForge.State = ModDownload.DlNeoForgeListLoader;
		LoadOptiFabric.State = ModDownload.DlOptiFabricLoader;
		ModDownloadLib.McDownloadForgeRecommendedRefresh();
	}

	public virtual void LoaderInit()
	{
		ControlInit();
		PageLoaderInit(LoadMinecraft, PanLoad, PanAllBack, null, ModDownload.DlClientListLoader, [SpecialName] (ModLoader.LoaderTask<string, ModDownload.DlClientListResult> a0) =>
		{
			LoadMinecraft_OnFinish();
		});
	}

	public virtual void Init()
	{
		if (IsLoad)
		{
			IsSelectNameEdited = false;
			ExitSelectPage();
			if (ModDownload.DlClientListLoader.State == ModBase.LoadState.Finished)
			{
				TrySelectWaitingVersion();
			}
		}
		IsLoad = true;
		PanBack.ScrollToHome();
		ModDownload.DlOptiFineListLoader.Start();
		ModDownload.DlLiteLoaderListLoader.Start();
		ModDownload.DlFabricListLoader.Start();
		ModDownload.DlNeoForgeListLoader.Start();
		TextSelectName.ValidateRules = new Collection<ValidateBase>
		{
			new ValidateFolderName(ModMinecraft.McFolderSelected + "versions")
		};
		TextSelectName.Validate();
		ReloadSelected();
	}

	public void PrepareSelectPage()
	{
		IsInSelectPage = true;
		PanInner.Margin = new Thickness(25.0, 10.0, 25.0, 40.0);
		PanSelect.Visibility = Visibility.Visible;
		PanSelect.IsHitTestVisible = true;
		PanMinecraft.IsHitTestVisible = false;
		PanBack.IsHitTestVisible = false;
		PanBack.ScrollToHome();
		DisabledPageAnimControls.Remove(BtnStart);
		BtnStart.Show = true;
		MyCard[] array = new MyCard[7] { CardOptiFine, CardLiteLoader, CardForge, CardNeoForge, CardFabric, CardFabricApi, CardOptiFabric };
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			array[i].IsSwapped = true;
		}
		foreach (FrameworkElement allAnimControl in GetAllAnimControls(PanSelect))
		{
			allAnimControl.Opacity = 1.0;
			if (allAnimControl.RenderTransform == null || allAnimControl.RenderTransform is TranslateTransform)
			{
				allAnimControl.RenderTransform = new TranslateTransform();
			}
		}
	}

	private void EnterSelectPage()
	{
		if (!IsInSelectPage)
		{
			AutoSelectedFabricApi = false;
			AutoSelectedOptiFabric = false;
			PrepareSelectPage();
			if (McVersion.IsStandardFormat(VanillaName))
			{
				ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>> loaderTask = new ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>>("DlForgeVersion " + VanillaName, ModDownload.DlForgeVersionMain);
				LoadForge.State = loaderTask;
				loaderTask.Start(VanillaName);
			}
			ModDownload.DlFabricApiLoader.Start();
			ModDownload.DlOptiFabricLoader.Start();
			ModAnimation.AniStart(new ModAnimation.AniData[6]
			{
				ModAnimation.AaOpacity(PanMinecraft, 0.0 - PanMinecraft.Opacity, 70, 10),
				ModAnimation.AaTranslateX(PanMinecraft, -50.0 - ((TranslateTransform)PanMinecraft.RenderTransform).X, 90, 10),
				ModAnimation.AaCode([SpecialName] () =>
				{
					PanBack.ScrollToHome();
					ReloadComponentLists();
					PanMinecraft.Visibility = Visibility.Collapsed;
				}, 0, After: true),
				ModAnimation.AaOpacity(PanSelect, 1.0 - PanSelect.Opacity, 70, 100),
				ModAnimation.AaTranslateX(PanSelect, 0.0 - ((TranslateTransform)PanSelect.RenderTransform).X, 160, 100, new ModAnimation.AniEaseOutFluent(ModAnimation.AniEasePower.ExtraStrong)),
				ModAnimation.AaCode([SpecialName] () =>
				{
					PanBack.IsHitTestVisible = true;
				}, 0, After: true)
			}, "FrmDownloadInstall SelectPageSwitch", RefreshTime: true);
		}
	}

	public void ReloadComponentLists()
	{
		TextSelectName.Validate();
		OptiFine_Loaded();
		LiteLoader_Loaded();
		Forge_Loaded();
		NeoForge_Loaded();
		Fabric_Loaded();
		FabricApi_Loaded();
		OptiFabric_Loaded();
		ReloadSelected();
	}

	public void ExitSelectPage()
	{
		if (IsInSelectPage)
		{
			IsInSelectPage = false;
			PanInner.Margin = new Thickness(25.0, 10.0, 25.0, 25.0);
			DisabledPageAnimControls.Add(BtnStart);
			BtnStart.Show = false;
			ClearSelected();
			PanMinecraft.Visibility = Visibility.Visible;
			PanSelect.IsHitTestVisible = false;
			PanMinecraft.IsHitTestVisible = true;
			PanBack.IsHitTestVisible = false;
			PanBack.ScrollToHome();
			ModAnimation.AniStart(new ModAnimation.AniData[6]
			{
				ModAnimation.AaOpacity(PanSelect, 0.0 - PanSelect.Opacity, 70, 10),
				ModAnimation.AaTranslateX(PanSelect, 50.0 - ((TranslateTransform)PanSelect.RenderTransform).X, 90, 10),
				ModAnimation.AaCode([SpecialName] () =>
				{
					PanBack.ScrollToHome();
				}, 0, After: true),
				ModAnimation.AaOpacity(PanMinecraft, 1.0 - PanMinecraft.Opacity, 70, 100),
				ModAnimation.AaTranslateX(PanMinecraft, 0.0 - ((TranslateTransform)PanMinecraft.RenderTransform).X, 160, 100, new ModAnimation.AniEaseOutFluent(ModAnimation.AniEasePower.ExtraStrong)),
				ModAnimation.AaCode([SpecialName] () =>
				{
					PanSelect.Visibility = Visibility.Collapsed;
					PanBack.IsHitTestVisible = true;
				}, 0, After: true)
			}, "FrmDownloadInstall SelectPageSwitch");
		}
	}

	public virtual void MinecraftSelected(MyListItem sender, MouseButtonEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		VanillaName = sender.Title;
		VanillaData = (JObject)sender.Tag;
		VanillaIcon = sender.Logo;
		LabMinecraftVersion.Text = VanillaName;
		EnterSelectPage();
	}

	public virtual void ReloadSelected()
	{
		if (_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init, ref lockTaken);
			if (_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init.State == 0)
			{
				_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init.State = 2;
				_0024STATIC_0024ReloadSelected_00242001_0024Ongoing = false;
			}
			else if (_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024ReloadSelected_00242001_0024Ongoing_0024Init);
			}
		}
		if (VanillaName == null || _0024STATIC_0024ReloadSelected_00242001_0024Ongoing)
		{
			return;
		}
		_0024STATIC_0024ReloadSelected_00242001_0024Ongoing = true;
		SelectNameUpdate();
		ImgLogo.Source = GetSelectLogo();
		ImgMinecraft.Source = VanillaIcon;
		string text = LoadOptiFineGetError();
		CardOptiFine.MainSwap.Visibility = ((text != null) ? Visibility.Collapsed : Visibility.Visible);
		if (text != null)
		{
			CardOptiFine.IsSwapped = true;
		}
		SetPanelVisibility(PanOptiFineInfo, CardOptiFine.IsSwapped);
		if (SelectedOptiFine == null)
		{
			BtnOptiFineClear.Visibility = Visibility.Collapsed;
			ImgOptiFine.Visibility = Visibility.Collapsed;
			LabOptiFine.Text = text ?? "可以添加";
			LabOptiFine.Foreground = ModSecret.ColorGray4;
		}
		else
		{
			BtnOptiFineClear.Visibility = Visibility.Visible;
			ImgOptiFine.Visibility = Visibility.Visible;
			LabOptiFine.Text = SelectedOptiFine.DisplayName.Replace(VanillaName + " ", "");
			LabOptiFine.Foreground = ModSecret.ColorGray1;
		}
		if (VanillaDrop >= 130)
		{
			CardLiteLoader.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardLiteLoader.Visibility = Visibility.Visible;
			string text2 = LoadLiteLoaderGetError();
			CardLiteLoader.MainSwap.Visibility = ((text2 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text2 != null)
			{
				CardLiteLoader.IsSwapped = true;
			}
			SetPanelVisibility(PanLiteLoaderInfo, CardLiteLoader.IsSwapped);
			if (SelectedLiteLoader == null)
			{
				BtnLiteLoaderClear.Visibility = Visibility.Collapsed;
				ImgLiteLoader.Visibility = Visibility.Collapsed;
				LabLiteLoader.Text = text2 ?? "可以添加";
				LabLiteLoader.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnLiteLoaderClear.Visibility = Visibility.Visible;
				ImgLiteLoader.Visibility = Visibility.Visible;
				LabLiteLoader.Text = SelectedLiteLoader.Inherit;
				LabLiteLoader.Foreground = ModSecret.ColorGray1;
			}
		}
		if (!McVersion.IsStandardFormat(VanillaName))
		{
			CardForge.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardForge.Visibility = Visibility.Visible;
			string text3 = LoadForgeGetError();
			CardForge.MainSwap.Visibility = ((text3 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text3 != null)
			{
				CardForge.IsSwapped = true;
			}
			SetPanelVisibility(PanForgeInfo, CardForge.IsSwapped);
			if (SelectedForge == null)
			{
				BtnForgeClear.Visibility = Visibility.Collapsed;
				ImgForge.Visibility = Visibility.Collapsed;
				LabForge.Text = text3 ?? "可以添加";
				LabForge.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnForgeClear.Visibility = Visibility.Visible;
				ImgForge.Visibility = Visibility.Visible;
				LabForge.Text = SelectedForge.VersionName;
				LabForge.Foreground = ModSecret.ColorGray1;
			}
		}
		if (DateTime.Compare(VanillaData["releaseTime"].ToObject<DateTime>(), new DateTime(2023, 6, 11)) < 0)
		{
			CardNeoForge.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardNeoForge.Visibility = Visibility.Visible;
			string text4 = LoadNeoForgeGetError();
			CardNeoForge.MainSwap.Visibility = ((text4 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text4 != null)
			{
				CardNeoForge.IsSwapped = true;
			}
			SetPanelVisibility(PanNeoForgeInfo, CardNeoForge.IsSwapped);
			if (SelectedNeoForge == null)
			{
				BtnNeoForgeClear.Visibility = Visibility.Collapsed;
				ImgNeoForge.Visibility = Visibility.Collapsed;
				LabNeoForge.Text = text4 ?? "可以添加";
				LabNeoForge.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnNeoForgeClear.Visibility = Visibility.Visible;
				ImgNeoForge.Visibility = Visibility.Visible;
				LabNeoForge.Text = SelectedNeoForge.VersionName;
				LabNeoForge.Foreground = ModSecret.ColorGray1;
			}
		}
		if (VanillaDrop <= 130)
		{
			CardFabric.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardFabric.Visibility = Visibility.Visible;
			string text5 = LoadFabricGetError();
			CardFabric.MainSwap.Visibility = ((text5 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text5 != null)
			{
				CardFabric.IsSwapped = true;
			}
			SetPanelVisibility(PanFabricInfo, CardFabric.IsSwapped);
			if (SelectedFabric == null)
			{
				BtnFabricClear.Visibility = Visibility.Collapsed;
				ImgFabric.Visibility = Visibility.Collapsed;
				LabFabric.Text = text5 ?? "可以添加";
				LabFabric.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnFabricClear.Visibility = Visibility.Visible;
				ImgFabric.Visibility = Visibility.Visible;
				LabFabric.Text = SelectedFabric.Replace("+build", "");
				LabFabric.Foreground = ModSecret.ColorGray1;
			}
		}
		if (SelectedFabric == null)
		{
			CardFabricApi.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardFabricApi.Visibility = Visibility.Visible;
			string text6 = LoadFabricApiGetError();
			CardFabricApi.MainSwap.Visibility = ((text6 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text6 != null || SelectedFabric == null)
			{
				CardFabricApi.IsSwapped = true;
			}
			SetPanelVisibility(PanFabricApiInfo, CardFabricApi.IsSwapped);
			if (SelectedFabricApi == null)
			{
				BtnFabricApiClear.Visibility = Visibility.Collapsed;
				ImgFabricApi.Visibility = Visibility.Collapsed;
				LabFabricApi.Text = text6 ?? "可以添加";
				LabFabricApi.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnFabricApiClear.Visibility = Visibility.Visible;
				ImgFabricApi.Visibility = Visibility.Visible;
				LabFabricApi.Text = StringExtensions.Split(StringExtensions.Split(SelectedFabricApi.Display, "]", false)[1].Replace("Fabric API ", "").Replace(" build ", "."), "+", false).First().Trim();
				LabFabricApi.Foreground = ModSecret.ColorGray1;
			}
		}
		if (SelectedFabric == null || SelectedOptiFine == null)
		{
			CardOptiFabric.Visibility = Visibility.Collapsed;
		}
		else
		{
			CardOptiFabric.Visibility = Visibility.Visible;
			string text7 = LoadOptiFabricGetError();
			CardOptiFabric.MainSwap.Visibility = ((text7 != null) ? Visibility.Collapsed : Visibility.Visible);
			if (text7 != null || SelectedFabric == null)
			{
				CardOptiFabric.IsSwapped = true;
			}
			SetPanelVisibility(PanOptiFabricInfo, CardOptiFabric.IsSwapped);
			if (SelectedOptiFabric == null)
			{
				BtnOptiFabricClear.Visibility = Visibility.Collapsed;
				ImgOptiFabric.Visibility = Visibility.Collapsed;
				LabOptiFabric.Text = text7 ?? "可以添加";
				LabOptiFabric.Foreground = ModSecret.ColorGray4;
			}
			else
			{
				BtnOptiFabricClear.Visibility = Visibility.Visible;
				ImgOptiFabric.Visibility = Visibility.Visible;
				LabOptiFabric.Text = StringExtensions.Lower(SelectedOptiFabric.Display).Replace("optifabric-", "").Replace(".jar", "")
					.Trim()
					.TrimStart('v');
				LabOptiFabric.Foreground = ModSecret.ColorGray1;
			}
		}
		if (SelectedFabric != null && SelectedFabricApi == null)
		{
			HintFabricAPI.Visibility = Visibility.Visible;
		}
		else
		{
			HintFabricAPI.Visibility = Visibility.Collapsed;
		}
		if (SelectedFabric != null && SelectedOptiFine != null && SelectedOptiFabric == null)
		{
			if (VanillaDrop >= 140 && VanillaDrop <= 150)
			{
				HintOptiFabric.Visibility = Visibility.Collapsed;
				HintOptiFabricOld.Visibility = Visibility.Visible;
			}
			else
			{
				HintOptiFabric.Visibility = Visibility.Visible;
				HintOptiFabricOld.Visibility = Visibility.Collapsed;
			}
		}
		else
		{
			HintOptiFabric.Visibility = Visibility.Collapsed;
			HintOptiFabricOld.Visibility = Visibility.Collapsed;
		}
		if (VanillaDrop >= 160 && SelectedOptiFine != null && (SelectedForge != null || SelectedFabric != null))
		{
			HintModOptiFine.Visibility = Visibility.Visible;
		}
		else
		{
			HintModOptiFine.Visibility = Visibility.Collapsed;
		}
		_0024STATIC_0024ReloadSelected_00242001_0024Ongoing = false;
	}

	public void ClearSelected()
	{
		VanillaName = null;
		VanillaData = null;
		VanillaIcon = null;
		SelectedOptiFine = null;
		SelectedLiteLoader = null;
		SelectedForge = null;
		SelectedNeoForge = null;
		SelectedFabric = null;
		SelectedFabricApi = null;
		SelectedOptiFabric = null;
		MyIconButton[] array = new MyIconButton[7] { BtnOptiFineClear, BtnLiteLoaderClear, BtnForgeClear, BtnNeoForgeClear, BtnFabricClear, BtnFabricApiClear, BtnOptiFabricClear };
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			array[i].Visibility = Visibility.Collapsed;
		}
	}

	private void SetPanelVisibility(Grid Panel, bool IsVisible)
	{
		if (!Operators.ConditionalCompareObjectEqual(Panel.Tag, IsVisible.ToString(), TextCompare: false))
		{
			Panel.Tag = IsVisible.ToString();
			if (IsVisible)
			{
				ModAnimation.AniStart(new ModAnimation.AniData[2]
				{
					ModAnimation.AaTranslateY(Panel, 0.0 - ((TranslateTransform)Panel.RenderTransform).Y, 150, 0, new ModAnimation.AniEaseOutFluent()),
					ModAnimation.AaOpacity(Panel, 1.0 - Panel.Opacity, 60)
				}, "PageDownloadInstall Visibility " + Panel.Name);
			}
			else
			{
				ModAnimation.AniStart(new ModAnimation.AniData[2]
				{
					ModAnimation.AaTranslateY(Panel, 6.0 - ((TranslateTransform)Panel.RenderTransform).Y, 60),
					ModAnimation.AaOpacity(Panel, 0.0 - Panel.Opacity, 60)
				}, "PageDownloadInstall Visibility " + Panel.Name);
			}
		}
	}

	public virtual string GetSelectLogo()
	{
		if (SelectedFabric != null)
		{
			return "pack://application:,,,/images/Blocks/Fabric.png";
		}
		if (SelectedForge != null)
		{
			return "pack://application:,,,/images/Blocks/Anvil.png";
		}
		if (SelectedNeoForge != null)
		{
			return "pack://application:,,,/images/Blocks/NeoForge.png";
		}
		if (SelectedLiteLoader != null)
		{
			return "pack://application:,,,/images/Blocks/Egg.png";
		}
		if (SelectedOptiFine != null)
		{
			return "pack://application:,,,/images/Blocks/GrassPath.png";
		}
		return VanillaIcon;
	}

	public string GetSelectName()
	{
		string text = VanillaName;
		if (SelectedFabric != null)
		{
			text = text + "-Fabric " + StringExtensions.BeforeFirst(SelectedFabric, "+", false);
		}
		if (SelectedForge != null)
		{
			text = text + "-Forge_" + SelectedForge.VersionName;
		}
		if (SelectedNeoForge != null)
		{
			text = text + "-NeoForge_" + StringExtensions.BeforeFirst(SelectedNeoForge.VersionName, "+", false);
		}
		if (SelectedLiteLoader != null)
		{
			text += "-LiteLoader";
		}
		if (SelectedOptiFine != null)
		{
			text = text + "-OptiFine_" + SelectedOptiFine.DisplayName.Replace(VanillaName + " ", "").Replace(" ", "_");
		}
		return text;
	}

	private void SelectNameUpdate()
	{
		if (!IsSelectNameEdited)
		{
			TextSelectName.Text = GetSelectName();
			IsSelectNameEdited = false;
		}
	}

	private void TextSelectName_TextChanged(object sender, TextChangedEventArgs e)
	{
		IsSelectNameEdited = true;
	}

	private void TextSelectName_ValidateChanged(object sender, EventArgs e)
	{
		BtnStart.IsEnabled = TextSelectName.IsValidated;
		HintSelectName.Text = TextSelectName.ValidateResult;
		HintSelectName.Visibility = (TextSelectName.IsValidated ? Visibility.Collapsed : Visibility.Visible);
	}

	private void LoadMinecraft_OnFinish()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		MinecraftVersions = (JArray)ModDownload.DlClientListLoader.Output.Value["versions"].DeepClone();
		ShowMinecraftVersionList();
		TrySelectWaitingVersion();
	}

	public virtual void ShowMinecraftVersionList()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		ExitSelectPage();
		try
		{
			Dictionary<string, List<JObject>> dictionary = new Dictionary<string, List<JObject>>
			{
				{
					"正式版",
					new List<JObject>()
				},
				{
					"预览版",
					new List<JObject>()
				},
				{
					"远古版",
					new List<JObject>()
				},
				{
					"愚人节版",
					new List<JObject>()
				}
			};
			foreach (JObject minecraftVersion in MinecraftVersions)
			{
				JObject val = minecraftVersion;
				string key;
				switch ((string)val["type"])
				{
				case "release":
					key = "正式版";
					break;
				case "snapshot":
					key = "预览版";
					if (StringExtensions.StartsWithF(val["id"].ToString(), "1.", false) && !StringExtensions.Lower(val["id"].ToString()).Contains("combat") && !StringExtensions.Lower(val["id"].ToString()).Contains("rc") && !StringExtensions.Lower(val["id"].ToString()).Contains("experimental") && !StringExtensions.Lower(val["id"].ToString()).Contains("pre"))
					{
						key = "正式版";
						val["type"] = (JToken)("release");
					}
					switch (StringExtensions.Lower(val["id"].ToString()))
					{
					case "20w14infinite":
					case "20w14∞":
						key = "愚人节版";
						val["id"] = (JToken)("20w14∞");
						val["type"] = (JToken)("special");
						val.Add("lore", (JToken)(ModMinecraft.GetMcFoolName((string)val["id"])));
						break;
					case "3d shareware v1.34":
					case "1.rv-pre1":
					case "15w14a":
					case "2.0":
					case "22w13oneblockatatime":
					case "23w13a_or_b":
					case "24w14potato":
					case "25w14craftmine":
					case "26w14a":
						key = "愚人节版";
						val["type"] = (JToken)("special");
						val.Add("lore", (JToken)(ModMinecraft.GetMcFoolName((string)val["id"])));
						break;
					default:
					{
						DateTime dateTime = Extensions.Value<DateTime>((IEnumerable<JToken>)val["releaseTime"]).ToUniversalTime().AddHours(2.0);
						if (dateTime.Month == 4 && dateTime.Day == 1)
						{
							key = "愚人节版";
							val["type"] = (JToken)("special");
						}
						break;
					}
					}
					break;
				case "special":
					key = "愚人节版";
					break;
				default:
					key = "远古版";
					break;
				}
				dictionary[key].Add(val);
			}
			foreach (KeyValuePair<string, List<JObject>> item in dictionary.ToList())
			{
				dictionary[item.Key] = item.Value.OrderByDescending((_Closure_0024__._0024I35_002D0 == null) ? (_Closure_0024__._0024I35_002D0 = [SpecialName] (JObject j) => Extensions.Value<DateTime>((IEnumerable<JToken>)j["releaseTime"])) : _Closure_0024__._0024I35_002D0).ToList();
			}
			PanMinecraft.Children.Clear();
			MyCard myCard = new MyCard
			{
				Title = "最新版本",
				Margin = new Thickness(0.0, 15.0, 0.0, 15.0)
			};
			List<JObject> list = new List<JObject>();
			JObject val2 = (JObject)((JToken)dictionary["正式版"][0]).DeepClone();
			val2["lore"] = (JToken)("最新正式版，发布于 " + Extensions.Value<DateTime>((IEnumerable<JToken>)val2["releaseTime"]).ToString("yyyy'/'MM'/'dd HH':'mm"));
			list.Add(val2);
			if (DateTime.Compare(Extensions.Value<DateTime>((IEnumerable<JToken>)dictionary["正式版"][0]["releaseTime"]), Extensions.Value<DateTime>((IEnumerable<JToken>)dictionary["预览版"][0]["releaseTime"])) < 0)
			{
				JObject val3 = (JObject)((JToken)dictionary["预览版"][0]).DeepClone();
				val3["lore"] = (JToken)("最新预览版，发布于 " + Extensions.Value<DateTime>((IEnumerable<JToken>)val3["releaseTime"]).ToString("yyyy'/'MM'/'dd HH':'mm"));
				list.Add(val3);
			}
			StackPanel stackPanel = new StackPanel
			{
				Margin = new Thickness(20.0, 40.0, 18.0, 0.0),
				VerticalAlignment = VerticalAlignment.Top,
				RenderTransform = new TranslateTransform(0.0, 0.0)
			};
			myCard.Children.Add(stackPanel);
			myCard.SwapControl = stackPanel;
			myCard.SetContentBuilder(list, [SpecialName] (JObject Version) => ModDownloadLib.McDownloadListItem(Version, [SpecialName] (object sender, MouseButtonEventArgs e) =>
			{
				MinecraftSelected((MyListItem)sender, e);
			}, IsSaveOnly: false));
			myCard.BuildContent();
			PanMinecraft.Children.Insert(0, myCard);
			foreach (KeyValuePair<string, List<JObject>> item2 in dictionary)
			{
				if (!item2.Value.Any())
				{
					continue;
				}
				MyCard myCard2 = new MyCard
				{
					Title = item2.Key,
					Margin = new Thickness(0.0, 0.0, 0.0, 15.0)
				};
				StackPanel stackPanel2 = new StackPanel
				{
					Margin = new Thickness(20.0, 40.0, 18.0, 0.0),
					VerticalAlignment = VerticalAlignment.Top,
					RenderTransform = new TranslateTransform(0.0, 0.0)
				};
				myCard2.Children.Add(stackPanel2);
				myCard2.SwapControl = stackPanel2;
				myCard2.SetContentBuilder(item2.Value, [SpecialName] (JObject Version) => ModDownloadLib.McDownloadListItem(Version, [SpecialName] (object sender, MouseButtonEventArgs e) =>
				{
					MinecraftSelected((MyListItem)sender, e);
				}, IsSaveOnly: false));
				myCard2.IsSwapped = true;
				PanMinecraft.Children.Add(myCard2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void TrySelectWaitingVersion()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		if (VersionWaitingSelect == null)
		{
			return;
		}
		foreach (JObject minecraftVersion in MinecraftVersions)
		{
			JObject val = minecraftVersion;
			if (Operators.CompareString(val["id"].ToString(), VersionWaitingSelect, TextCompare: false) == 0)
			{
				Logger.Info($"自动选择 MC 版本：{VersionWaitingSelect}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
				MinecraftSelected(ModDownloadLib.McDownloadListItem(val, null, IsSaveOnly: false).Init(), null);
				VersionWaitingSelect = null;
				break;
			}
		}
	}

	public string LoadOptiFineGetError()
	{
		if (SelectedNeoForge != null)
		{
			return "与 NeoForge 不兼容";
		}
		if (SelectedForge != null && McUtils.CompareVersionGE(VanillaName, "1.13") && McUtils.CompareVersionGE("1.14.3", VanillaName))
		{
			return "与 Forge 不兼容";
		}
		if (SelectedFabric != null && McUtils.CompareVersion(VanillaName, "1.20.4") > 0)
		{
			return "与 Fabric 不兼容";
		}
		if (GetLoaderError(LoadOptiFine) != null)
		{
			return GetLoaderError(LoadOptiFine);
		}
		bool flag = false;
		bool flag2 = false;
		foreach (ModDownload.DlOptiFineListEntry item in ModDownload.DlOptiFineListLoader.Output.Value)
		{
			if (StringExtensions.StartsWithF(item.DisplayName, VanillaName + " ", false))
			{
				flag = true;
				if (SelectedForge == null)
				{
					return null;
				}
				if (IsOptiFineSuitForForge(item, SelectedForge))
				{
					return null;
				}
				if (item.RequiredForgeVersion != null)
				{
					flag2 = true;
				}
			}
		}
		if (!flag)
		{
			return "无";
		}
		if (flag2)
		{
			return "仅兼容特定版本的 Forge";
		}
		return "与 Forge 不兼容";
	}

	public static bool IsOptiFineSuitForForge(ModDownload.DlOptiFineListEntry OptiFine, ModDownload.DlForgeVersionEntry Forge)
	{
		if (Operators.CompareString(Forge.Inherit, OptiFine.Inherit, TextCompare: false) != 0)
		{
			return false;
		}
		if (OptiFine.RequiredForgeVersion == null)
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(OptiFine.RequiredForgeVersion))
		{
			return true;
		}
		if (OptiFine.RequiredForgeVersion.Contains("."))
		{
			return McUtils.CompareVersion(Forge.Version.ToString(), OptiFine.RequiredForgeVersion) == 0;
		}
		return (double)Forge.Version.Revision == Conversions.ToDouble(OptiFine.RequiredForgeVersion);
	}

	private void CardOptiFine_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadOptiFineGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void OptiFine_Loaded()
	{
		try
		{
			if (ModDownload.DlOptiFineListLoader.State != ModBase.LoadState.Finished)
			{
				return;
			}
			List<ModDownload.DlOptiFineListEntry> list = new List<ModDownload.DlOptiFineListEntry>();
			foreach (ModDownload.DlOptiFineListEntry item in ModDownload.DlOptiFineListLoader.Output.Value)
			{
				if ((SelectedForge == null || IsOptiFineSuitForForge(item, SelectedForge)) && StringExtensions.StartsWithF(item.DisplayName, VanillaName + " ", false))
				{
					list.Add(item);
				}
			}
			if (!list.Any())
			{
				return;
			}
			list = ModBase.SortByComparison(list, [SpecialName] (ModDownload.DlOptiFineListEntry Left, ModDownload.DlOptiFineListEntry Right) =>
			{
				if (!Left.IsPreview && Right.IsPreview)
				{
					return true;
				}
				return (!Left.IsPreview || Right.IsPreview) && McUtils.CompareVersionGE(Left.DisplayName, Right.DisplayName);
			});
			PanOptiFine.Children.Clear();
			foreach (ModDownload.DlOptiFineListEntry item2 in list)
			{
				PanOptiFine.Children.Add(ModDownloadLib.OptiFineDownloadListItem(item2, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					OptiFine_Selected((MyListItem)a0, a1);
				}, IsSaveOnly: false));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 OptiFine 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void OptiFine_Selected(MyListItem sender, EventArgs e)
	{
		SelectedOptiFine = (ModDownload.DlOptiFineListEntry)sender.Tag;
		if (SelectedForge != null && !IsOptiFineSuitForForge(SelectedOptiFine, SelectedForge))
		{
			SelectedForge = null;
		}
		OptiFabric_Loaded();
		Forge_Loaded();
		NeoForge_Loaded();
		CardOptiFine.IsSwapped = true;
		ReloadSelected();
	}

	private void OptiFine_Clear(object sender, EventArgs e)
	{
		SelectedOptiFine = null;
		SelectedOptiFabric = null;
		BtnOptiFabricClear.Visibility = Visibility.Collapsed;
		AutoSelectedOptiFabric = false;
		CardOptiFine.IsSwapped = true;
		Forge_Loaded();
		NeoForge_Loaded();
		ReloadSelected();
	}

	public string LoadLiteLoaderGetError()
	{
		if (GetLoaderError(LoadLiteLoader) != null)
		{
			return GetLoaderError(LoadLiteLoader);
		}
		return ModDownload.DlLiteLoaderListLoader.Output.Value.Any([SpecialName] (ModDownload.DlLiteLoaderListEntry v) => Operators.CompareString(v.Inherit, VanillaName, TextCompare: false) == 0) ? null : "无";
	}

	private void CardLiteLoader_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadLiteLoaderGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void LiteLoader_Loaded()
	{
		try
		{
			if (ModDownload.DlLiteLoaderListLoader.State != ModBase.LoadState.Finished)
			{
				return;
			}
			List<ModDownload.DlLiteLoaderListEntry> list = new List<ModDownload.DlLiteLoaderListEntry>();
			foreach (ModDownload.DlLiteLoaderListEntry item in ModDownload.DlLiteLoaderListLoader.Output.Value)
			{
				if (Operators.CompareString(item.Inherit, VanillaName, TextCompare: false) == 0)
				{
					list.Add(item);
				}
			}
			if (!list.Any())
			{
				return;
			}
			PanLiteLoader.Children.Clear();
			foreach (ModDownload.DlLiteLoaderListEntry item2 in list)
			{
				PanLiteLoader.Children.Add(ModDownloadLib.LiteLoaderDownloadListItem(item2, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					LiteLoader_Selected((MyListItem)a0, a1);
				}, IsSaveOnly: false));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 LiteLoader 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void LiteLoader_Selected(MyListItem sender, EventArgs e)
	{
		SelectedLiteLoader = (ModDownload.DlLiteLoaderListEntry)sender.Tag;
		CardLiteLoader.IsSwapped = true;
		ReloadSelected();
	}

	private void LiteLoader_Clear(object sender, EventArgs e)
	{
		SelectedLiteLoader = null;
		CardLiteLoader.IsSwapped = true;
		ReloadSelected();
	}

	public string LoadForgeGetError()
	{
		if (McUtils.CompareVersionGE("1.5.1", VanillaName) && McUtils.CompareVersionGE(VanillaName, "1.1"))
		{
			return "无";
		}
		if (GetLoaderError(LoadForge) != null)
		{
			return GetLoaderError(LoadForge);
		}
		ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>> loaderTask = (ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>>)LoadForge.State;
		if (Operators.CompareString(VanillaName, loaderTask.Input, TextCompare: false) != 0)
		{
			return "获取中……";
		}
		foreach (ModDownload.DlForgeVersionEntry item in loaderTask.Output)
		{
			if (Operators.CompareString(item.Category, "universal", TextCompare: false) != 0 && Operators.CompareString(item.Category, "client", TextCompare: false) != 0)
			{
				if (SelectedNeoForge != null)
				{
					return "与 NeoForge 不兼容";
				}
				if (SelectedFabric != null)
				{
					return "与 Fabric 不兼容";
				}
				if (SelectedOptiFine != null && McUtils.CompareVersionGE(VanillaName, "1.13") && McUtils.CompareVersionGE("1.14.3", VanillaName))
				{
					return "与 OptiFine 不兼容";
				}
				if (SelectedOptiFine == null || IsOptiFineSuitForForge(SelectedOptiFine, item))
				{
					return null;
				}
			}
		}
		return "与 OptiFine 不兼容";
	}

	private void CardForge_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadForgeGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void Forge_Loaded()
	{
		try
		{
			if (!LoadForge.State.IsLoader)
			{
				return;
			}
			ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>> loaderTask = (ModLoader.LoaderTask<string, List<ModDownload.DlForgeVersionEntry>>)LoadForge.State;
			if (Operators.CompareString(VanillaName, loaderTask.Input, TextCompare: false) != 0 || loaderTask.State != ModBase.LoadState.Finished)
			{
				return;
			}
			List<ModDownload.DlForgeVersionEntry> source = loaderTask.Output.ToList();
			if (!loaderTask.Output.Any())
			{
				return;
			}
			PanForge.Children.Clear();
			source = (from v in source.Where([SpecialName] (ModDownload.DlForgeVersionEntry v) =>
				{
					if (Operators.CompareString(v.Category, "universal", TextCompare: false) == 0 || Operators.CompareString(v.Category, "client", TextCompare: false) == 0)
					{
						return false;
					}
					return (SelectedOptiFine == null || IsOptiFineSuitForForge(SelectedOptiFine, v)) ? true : false;
				})
				orderby v descending
				select v).ToList();
			ModDownloadLib.ForgeDownloadListItemPreload(PanForge, source, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
			{
				Forge_Selected((MyListItem)a0, a1);
			}, IsSaveOnly: false);
			foreach (ModDownload.DlForgeVersionEntry item in source)
			{
				PanForge.Children.Add(ModDownloadLib.ForgeDownloadListItem(item, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					Forge_Selected((MyListItem)a0, a1);
				}, IsSaveOnly: false));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 Forge 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void Forge_Selected(MyListItem sender, EventArgs e)
	{
		SelectedForge = (ModDownload.DlForgeVersionEntry)sender.Tag;
		CardForge.IsSwapped = true;
		if (SelectedOptiFine != null && !IsOptiFineSuitForForge(SelectedOptiFine, SelectedForge))
		{
			SelectedOptiFine = null;
		}
		OptiFine_Loaded();
		ReloadSelected();
	}

	private void Forge_Clear(object sender, EventArgs e)
	{
		SelectedForge = null;
		CardForge.IsSwapped = true;
		OptiFine_Loaded();
		ReloadSelected();
	}

	public string LoadNeoForgeGetError()
	{
		if (SelectedOptiFine != null)
		{
			return "与 OptiFine 不兼容";
		}
		if (SelectedForge != null)
		{
			return "与 Forge 不兼容";
		}
		if (SelectedFabric != null)
		{
			return "与 Fabric 不兼容";
		}
		if (GetLoaderError(LoadNeoForge) != null)
		{
			return GetLoaderError(LoadNeoForge);
		}
		return ModDownload.DlNeoForgeListLoader.Output.Value.Any([SpecialName] (ModDownload.DlNeoForgeListEntry v) => Operators.CompareString(v.Inherit, VanillaName, TextCompare: false) == 0) ? null : "无";
	}

	private void CardNeoForge_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadNeoForgeGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void NeoForge_Loaded()
	{
		try
		{
			if (ModDownload.DlNeoForgeListLoader.State != ModBase.LoadState.Finished)
			{
				return;
			}
			List<ModDownload.DlNeoForgeListEntry> list = ModDownload.DlNeoForgeListLoader.Output.Value.Where([SpecialName] (ModDownload.DlNeoForgeListEntry v) => Operators.CompareString(v.Inherit, VanillaName, TextCompare: false) == 0).ToList();
			if (!list.Any())
			{
				return;
			}
			PanNeoForge.Children.Clear();
			ModDownloadLib.NeoForgeDownloadListItemPreload(PanNeoForge, list, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
			{
				NeoForge_Selected((MyListItem)a0, a1);
			}, IsSaveOnly: false);
			foreach (ModDownload.DlNeoForgeListEntry item in list)
			{
				PanNeoForge.Children.Add(ModDownloadLib.NeoForgeDownloadListItem(item, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					NeoForge_Selected((MyListItem)a0, a1);
				}, IsSaveOnly: false));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 NeoForge 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void NeoForge_Selected(MyListItem sender, EventArgs e)
	{
		SelectedNeoForge = (ModDownload.DlNeoForgeListEntry)sender.Tag;
		CardNeoForge.IsSwapped = true;
		OptiFine_Loaded();
		ReloadSelected();
	}

	private void NeoForge_Clear(object sender, EventArgs e)
	{
		SelectedNeoForge = null;
		CardNeoForge.IsSwapped = true;
		OptiFine_Loaded();
		ReloadSelected();
	}

	public string LoadFabricGetError()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (SelectedOptiFine != null && McUtils.CompareVersionGE(VanillaName, "1.20.5"))
		{
			return "与 OptiFine 不兼容";
		}
		if (GetLoaderError(LoadFabric) != null)
		{
			return GetLoaderError(LoadFabric);
		}
		foreach (JObject item in (IEnumerable<JToken>)ModDownload.DlFabricListLoader.Output.Value["game"])
		{
			if (Operators.CompareString(item["version"].ToString(), VanillaName.Replace("∞", "infinite").Replace("Combat Test 7c", "1.16_combat-3"), TextCompare: false) == 0)
			{
				if (SelectedForge != null)
				{
					return "与 Forge 不兼容";
				}
				if (SelectedNeoForge != null)
				{
					return "与 NeoForge 不兼容";
				}
				return null;
			}
		}
		return "无";
	}

	private void CardFabric_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadFabricGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void Fabric_Loaded()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		try
		{
			if (ModDownload.DlFabricListLoader.State != ModBase.LoadState.Finished)
			{
				return;
			}
			JArray source = (JArray)ModDownload.DlFabricListLoader.Output.Value["loader"];
			if (!((IEnumerable<JToken>)source).Any())
			{
				return;
			}
			PanFabric.Children.Clear();
			CardFabric.SwapControl = PanFabric;
			CardFabric.SetContentBuilder(((IEnumerable)source).OfType<JObject>(), [SpecialName] (JObject Version) => ModDownloadLib.FabricDownloadListItem(Version, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
			{
				Fabric_Selected((MyListItem)a0, a1);
			}));
			if (!CardFabric.IsSwapped)
			{
				CardFabric.BuildContent();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 Fabric 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	public void Fabric_Selected(MyListItem sender, EventArgs e)
	{
		SelectedFabric = NewLateBinding.LateIndexGet(sender.Tag, new object[1] { "version" }, null).ToString();
		FabricApi_Loaded();
		OptiFabric_Loaded();
		CardFabric.IsSwapped = true;
		ReloadSelected();
	}

	private void Fabric_Clear(object sender, EventArgs e)
	{
		SelectedFabric = null;
		SelectedFabricApi = null;
		BtnFabricApiClear.Visibility = Visibility.Collapsed;
		AutoSelectedFabricApi = false;
		SelectedOptiFabric = null;
		BtnOptiFabricClear.Visibility = Visibility.Collapsed;
		AutoSelectedOptiFabric = false;
		CardFabric.IsSwapped = true;
		ReloadSelected();
	}

	public static bool IsFabricApiCompatible(ResourceVersion FabricApi, string MinecraftVersion)
	{
		string text = FabricApi.Display;
		checked
		{
			bool result;
			try
			{
				if (text == null || MinecraftVersion == null)
				{
					result = false;
				}
				else
				{
					text = StringExtensions.Lower(text);
					string text2 = StringExtensions.Lower(MinecraftVersion.Replace("∞", "infinite").Replace("Combat Test 7c", "1.16_combat-3"));
					if (StringExtensions.StartsWithF(text, "[" + text2 + "]", false))
					{
						result = true;
					}
					else if (!text.Contains("/") || !text.Contains("]"))
					{
						result = false;
					}
					else
					{
						string[] array = StringExtensions.Split(StringExtensions.BeforeFirst(text, "]", false).TrimStart('['), "/", false);
						int num = 0;
						while (true)
						{
							if (num < array.Length)
							{
								if (Operators.CompareString(array[num], text2, TextCompare: false) == 0)
								{
									result = true;
									break;
								}
								num++;
								continue;
							}
							List<string> list = StringExtensions.RegexSearch(StringExtensions.BeforeFirst(text, "]", false), "[a-z/]+|[0-9/]+", RegexOptions.None).ToList();
							List<string> list2 = StringExtensions.RegexSearch(StringExtensions.BeforeFirst(text2, "]", false), "[a-z/]+|[0-9/]+", RegexOptions.None).ToList();
							int num2 = 0;
							while (true)
							{
								if (list.Count - 1 < num2 && list2.Count - 1 < num2)
								{
									result = true;
									break;
								}
								string text3 = ((list.Count - 1 < num2) ? "-1" : list[num2]);
								string text4 = ((list2.Count - 1 < num2) ? "-1" : list2[num2]);
								if (!text3.Contains("/"))
								{
									if (Operators.CompareString(text3, text4, TextCompare: false) != 0)
									{
										result = false;
										break;
									}
								}
								else if (!text3.Contains(text4))
								{
									result = false;
									break;
								}
								num2++;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Logger.Warn(ex2, $"判断 Fabric API 版本适配性出错（{text}, {MinecraftVersion}）", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public string LoadFabricApiGetError()
	{
		if (GetLoaderError(LoadFabricApi) != null)
		{
			return GetLoaderError(LoadFabricApi);
		}
		if (ModDownload.DlFabricApiLoader.Output == null)
		{
			return (SelectedFabric == null) ? "需要安装 Fabric" : "获取中……";
		}
		if (ModDownload.DlFabricApiLoader.Output.Any([SpecialName] (ResourceVersion f) => IsFabricApiCompatible(f, VanillaName)))
		{
			return (SelectedFabric == null) ? "需要安装 Fabric" : null;
		}
		return "无";
	}

	private void CardFabricApi_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadFabricApiGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void FabricApi_Loaded()
	{
		try
		{
			if (ModDownload.DlFabricApiLoader.State != ModBase.LoadState.Finished || VanillaName == null || SelectedFabric == null)
			{
				return;
			}
			List<ResourceVersion> list = new List<ResourceVersion>();
			foreach (ResourceVersion item in ModDownload.DlFabricApiLoader.Output)
			{
				if (IsFabricApiCompatible(item, VanillaName))
				{
					if (!StringExtensions.StartsWithF(item.Display, "[", false))
					{
						Logger.Warn($"已特判修改 Fabric API 显示名：{item.Display}", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
						item.Display = "[" + VanillaName + "] " + item.Display;
					}
					list.Add(item);
				}
			}
			if (!list.Any())
			{
				return;
			}
			list = list.OrderByDescending([SpecialName] (ResourceVersion v) => v.ReleaseDate).ToList();
			PanFabricApi.Children.Clear();
			foreach (ResourceVersion item2 in list)
			{
				PanFabricApi.Children.Add(ModDownloadLib.FabricApiDownloadListItem(item2, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					FabricApi_Selected((MyListItem)a0, a1);
				}));
			}
			if (!AutoSelectedFabricApi)
			{
				AutoSelectedFabricApi = true;
				MyListItem myListItem = (MyListItem)MyVirtualizingElement.TryInit((FrameworkElement)PanFabricApi.Children[0]);
				Logger.Info($"已自动选择 Fabric API：{myListItem.Title}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
				FabricApi_Selected(myListItem, null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 Fabric API 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void FabricApi_Selected(MyListItem sender, EventArgs e)
	{
		SelectedFabricApi = (ResourceVersion)sender.Tag;
		CardFabricApi.IsSwapped = true;
		ReloadSelected();
	}

	private void FabricApi_Clear(object sender, EventArgs e)
	{
		SelectedFabricApi = null;
		CardFabricApi.IsSwapped = true;
		ReloadSelected();
	}

	public static bool IsOptiFabricCompatible(ResourceVersion ModFile, string MinecraftVersion)
	{
		bool result;
		try
		{
			result = MinecraftVersion != null && ModFile.GameVersions.Contains(MinecraftVersion);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Warn(ex2, $"判断 OptiFabric 版本适配性出错（{MinecraftVersion}）", (LogBehavior)1, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string LoadOptiFabricGetError()
	{
		if (VanillaDrop >= 140 && VanillaDrop <= 150)
		{
			return "不兼容老版本 Fabric，请手动下载 OptiFabric Origins";
		}
		if (GetLoaderError(LoadOptiFabric) != null)
		{
			return GetLoaderError(LoadOptiFabric);
		}
		if (ModDownload.DlOptiFabricLoader.Output == null)
		{
			if (SelectedFabric == null && SelectedOptiFine == null)
			{
				return "需要安装 OptiFine 与 Fabric";
			}
			if (SelectedFabric == null)
			{
				return "需要安装 Fabric";
			}
			if (SelectedOptiFine == null)
			{
				return "需要安装 OptiFine";
			}
			return "获取中……";
		}
		foreach (ResourceVersion item in ModDownload.DlOptiFabricLoader.Output)
		{
			if (IsOptiFabricCompatible(item, VanillaName))
			{
				if (SelectedFabric == null && SelectedOptiFine == null)
				{
					return "需要安装 OptiFine 与 Fabric";
				}
				if (SelectedFabric == null)
				{
					return "需要安装 Fabric";
				}
				if (SelectedOptiFine == null)
				{
					return "需要安装 OptiFine";
				}
				return null;
			}
		}
		return "无";
	}

	private void CardOptiFabric_PreviewSwap(object sender, ModBase.RouteEventArgs e)
	{
		if (LoadOptiFabricGetError() != null)
		{
			e.Handled = true;
		}
	}

	private void OptiFabric_Loaded()
	{
		try
		{
			if (ModDownload.DlOptiFabricLoader.State != ModBase.LoadState.Finished || VanillaName == null || SelectedFabric == null || SelectedOptiFine == null)
			{
				return;
			}
			List<ResourceVersion> list = new List<ResourceVersion>();
			foreach (ResourceVersion item in ModDownload.DlOptiFabricLoader.Output)
			{
				if (IsOptiFabricCompatible(item, VanillaName))
				{
					list.Add(item);
				}
			}
			if (!list.Any())
			{
				return;
			}
			list = list.OrderByDescending([SpecialName] (ResourceVersion v) => v.ReleaseDate).ToList();
			PanOptiFabric.Children.Clear();
			foreach (ResourceVersion item2 in list)
			{
				PanOptiFabric.Children.Add(ModDownloadLib.OptiFabricDownloadListItem(item2, [SpecialName] (object a0, MouseButtonEventArgs a1) =>
				{
					OptiFabric_Selected((MyListItem)a0, a1);
				}));
			}
			if (!AutoSelectedOptiFabric && (VanillaDrop < 140 || VanillaDrop > 150))
			{
				AutoSelectedOptiFabric = true;
				MyListItem myListItem = (MyListItem)MyVirtualizingElement.TryInit((FrameworkElement)PanOptiFabric.Children[0]);
				Logger.Info($"已自动选择 OptiFabric：{myListItem.Title}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
				OptiFabric_Selected(myListItem, null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "可视化 OptiFabric 安装版本列表出错", (LogBehavior)4, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\PageDownloadInstall.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void OptiFabric_Selected(MyListItem sender, EventArgs e)
	{
		SelectedOptiFabric = (ResourceVersion)sender.Tag;
		CardOptiFabric.IsSwapped = true;
		ReloadSelected();
	}

	private void OptiFabric_Clear(object sender, EventArgs e)
	{
		SelectedOptiFabric = null;
		CardOptiFabric.IsSwapped = true;
		ReloadSelected();
	}

	public McComponents GetSelectedComponents()
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		string vanillaName = VanillaName;
		JObject obj = ((SelectedOptiFine == null) ? null : JObject.FromObject((object)SelectedOptiFine));
		string text = SelectedForge?.VersionName;
		string text2 = SelectedNeoForge?.VersionName;
		string selectedFabric = SelectedFabric;
		string obj2 = SelectedFabricApi?.Version ?? SelectedFabricApi?.Id ?? SelectedFabricApi?.Display;
		string obj3 = SelectedOptiFabric?.Version ?? SelectedOptiFabric?.Id ?? SelectedOptiFabric?.Display;
		ModDownload.DlLiteLoaderListEntry selectedLiteLoader = SelectedLiteLoader;
		object obj4;
		if (selectedLiteLoader == null)
		{
			obj4 = null;
		}
		else
		{
			JToken jsonToken = selectedLiteLoader.JsonToken;
			obj4 = ((jsonToken != null) ? jsonToken[(object)"version"].ToString() : null);
		}
		return new McComponents(vanillaName, obj, text, text2, selectedFabric, obj2, obj3, (string)obj4);
	}

	private void TextSelectName_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return && IsInSelectPage && BtnStart.IsEnabled)
		{
			BtnStart_Click();
		}
	}

	private void BtnStart_Click()
	{
		string text = TextSelectName.Text;
		ModDownloadLib.McInstallRequest request = new ModDownloadLib.McInstallRequest
		{
			NewInstanceName = text,
			InstanceFolder = $"{ModMinecraft.McFolderSelected}versions\\{text}\\",
			Components = GetSelectedComponents(),
			MinecraftJson = VanillaData["url"].ToString(),
			ForgeEntry = SelectedForge,
			NeoForgeEntry = SelectedNeoForge,
			FabricApi = SelectedFabricApi,
			OptiFabric = SelectedOptiFabric,
			LiteLoaderEntry = SelectedLiteLoader
		};
		StartInstall(request);
	}

	public virtual void StartInstall(ModDownloadLib.McInstallRequest Request)
	{
		if (((SelectedForge == null && SelectedNeoForge == null && SelectedFabric == null) || (Settings.Get<int>("LaunchArgumentIndieV2") != 0 && Settings.Get<int>("LaunchArgumentIndieV2") != 2) || ModMain.MyMsgBox("你尚未开启版本隔离，多个 MC 版本会共用同一个 Mod 文件夹。\r\n因此，游戏可能会因为读取到与当前版本不符的 Mod 而崩溃。\r\n推荐先在 设置 → 启动选项 → 默认版本隔离 中开启版本隔离！", "版本隔离提示", "取消下载", "继续") != 1) && ModDownloadLib.McInstallStart(Request))
		{
			ExitSelectPage();
		}
	}

	private string GetLoaderError(MyLoading Loader)
	{
		if (Loader == null)
		{
			return "获取中……";
		}
		if (!Loader.State.IsLoader)
		{
			return "获取中……";
		}
		switch (Loader.State.LoadingState)
		{
		case MyLoading.MyLoadingState.Run:
			return "获取中……";
		case MyLoading.MyLoadingState.Error:
		{
			string message = ((ModLoader.LoaderBase)Loader.State).Error.Message;
			return (Operators.CompareString(message, "无", TextCompare: false) == 0) ? "无" : ("获取失败：" + message);
		}
		case MyLoading.MyLoadingState.Unloaded:
			return "未知错误，状态为 Unloaded";
		default:
			return null;
		}
	}

}
