using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using MeloongCore;
using MeloongCore.Extensions;
using MeloongCore.Wpf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PCL;

[DesignerGenerated]
public partial class PageSetupUI : MyPageRight, IComponentConnector
{
	private static bool _HiddenForceShow;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyScrollViewer _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMain")]
	private StackPanel _PanMain;

	[CompilerGenerated]
	[AccessedThroughProperty("CardLauncher")]
	private MyCard _CardLauncher;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderLauncherTransparent")]
	private MySlider _SliderLauncherTransparent;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLauncherHue")]
	private TextBlock _LabLauncherHue;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderLauncherHue")]
	private MySlider _SliderLauncherHue;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLauncherDelta")]
	private TextBlock _LabLauncherDelta;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderLauncherDelta")]
	private MySlider _SliderLauncherDelta;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLauncherSat")]
	private TextBlock _LabLauncherSat;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderLauncherSat")]
	private MySlider _SliderLauncherSat;

	[CompilerGenerated]
	[AccessedThroughProperty("LabLauncherLight")]
	private TextBlock _LabLauncherLight;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderLauncherLight")]
	private MySlider _SliderLauncherLight;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLauncherTheme")]
	private Grid _PanLauncherTheme;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme0")]
	private MyRadioBox _RadioLauncherTheme0;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme1")]
	private MyRadioBox _RadioLauncherTheme1;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme2")]
	private MyRadioBox _RadioLauncherTheme2;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme3")]
	private MyRadioBox _RadioLauncherTheme3;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme4")]
	private MyRadioBox _RadioLauncherTheme4;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme5")]
	private MyRadioBox _RadioLauncherTheme5;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme5Gray")]
	private MyRadioBox _RadioLauncherTheme5Gray;


	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme12")]
	private MyRadioBox _RadioLauncherTheme12;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme6")]
	private MyRadioBox _RadioLauncherTheme6;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme7")]
	private MyRadioBox _RadioLauncherTheme7;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme13")]
	private MyRadioBox _RadioLauncherTheme13;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme8")]
	private MyRadioBox _RadioLauncherTheme8;


	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme9")]
	private MyRadioBox _RadioLauncherTheme9;


	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme10")]
	private MyRadioBox _RadioLauncherTheme10;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme11")]
	private MyRadioBox _RadioLauncherTheme11;


	[CompilerGenerated]
	[AccessedThroughProperty("RadioLauncherTheme14")]
	private MyRadioBox _RadioLauncherTheme14;


	[CompilerGenerated]
	[AccessedThroughProperty("CardBackground")]
	private MyCard _CardBackground;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBackgroundSuit")]
	private Grid _PanBackgroundSuit;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBackgroundOpacity")]
	private Grid _PanBackgroundOpacity;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderBackgroundOpacity")]
	private MySlider _SliderBackgroundOpacity;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBackgroundBlur")]
	private Grid _PanBackgroundBlur;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderBackgroundBlur")]
	private MySlider _SliderBackgroundBlur;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnBackgroundOpen")]
	private MyButton _BtnBackgroundOpen;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnBackgroundRefresh")]
	private MyButton _BtnBackgroundRefresh;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnBackgroundClear")]
	private MyButton _BtnBackgroundClear;

	[CompilerGenerated]
	[AccessedThroughProperty("CardMusic")]
	private MyCard _CardMusic;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMusicVolume")]
	private Grid _PanMusicVolume;

	[CompilerGenerated]
	[AccessedThroughProperty("SliderMusicVolume")]
	private MySlider _SliderMusicVolume;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMusicDetail")]
	private StackPanel _PanMusicDetail;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckMusicRandom")]
	private MyCheckBox _CheckMusicRandom;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckMusicAuto")]
	private MyCheckBox _CheckMusicAuto;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckMusicStart")]
	private MyCheckBox _CheckMusicStart;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckMusicStop")]
	private MyCheckBox _CheckMusicStop;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnMusicOpen")]
	private MyButton _BtnMusicOpen;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnMusicRefresh")]
	private MyButton _BtnMusicRefresh;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnMusicClear")]
	private MyButton _BtnMusicClear;

	[CompilerGenerated]
	[AccessedThroughProperty("CardLogo")]
	private MyCard _CardLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLogoType0")]
	private MyRadioBox _RadioLogoType0;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLogoType1")]
	private MyRadioBox _RadioLogoType1;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLogoType2")]
	private MyRadioBox _RadioLogoType2;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioLogoType3")]
	private MyRadioBox _RadioLogoType3;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckLogoLeft")]
	private MyCheckBox _CheckLogoLeft;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLogoText")]
	private Grid _PanLogoText;

	[CompilerGenerated]
	[AccessedThroughProperty("TextLogoText")]
	private MyTextBox _TextLogoText;

	[CompilerGenerated]
	[AccessedThroughProperty("PanLogoChange")]
	private Grid _PanLogoChange;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnLogoChange")]
	private MyButton _BtnLogoChange;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnLogoDelete")]
	private MyButton _BtnLogoDelete;

	[CompilerGenerated]
	[AccessedThroughProperty("CardCustom")]
	private MyCard _CardCustom;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioCustomType0")]
	private MyRadioBox _RadioCustomType0;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioCustomType3")]
	private MyRadioBox _RadioCustomType3;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioCustomType1")]
	private MyRadioBox _RadioCustomType1;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioCustomType2")]
	private MyRadioBox _RadioCustomType2;

	[CompilerGenerated]
	[AccessedThroughProperty("HintCustom")]
	private MyHint _HintCustom;

	[CompilerGenerated]
	[AccessedThroughProperty("HintCustomWarn")]
	private MyHint _HintCustomWarn;

	[CompilerGenerated]
	[AccessedThroughProperty("PanCustomLocal")]
	private WrapPanel _PanCustomLocal;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnCustomRefresh")]
	private MyButton _BtnCustomRefresh;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnCustomFile")]
	private MyButton _BtnCustomFile;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnCustomTutorial")]
	private MyButton _BtnCustomTutorial;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnCustomFolder")]
	private MyButton _BtnCustomFolder;

	[CompilerGenerated]
	[AccessedThroughProperty("PanCustomNet")]
	private Grid _PanCustomNet;

	[CompilerGenerated]
	[AccessedThroughProperty("TextCustomNet")]
	private MyTextBox _TextCustomNet;

	[CompilerGenerated]
	[AccessedThroughProperty("PanCustomPreset")]
	private Grid _PanCustomPreset;

	[CompilerGenerated]
	[AccessedThroughProperty("CardSwitch")]
	private MyCard _CardSwitch;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenPageDownload")]
	private MyCheckBox _CheckHiddenPageDownload;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenPageLink")]
	private MyCheckBox _CheckHiddenPageLink;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenPageSetup")]
	private MyCheckBox _CheckHiddenPageSetup;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenPageOther")]
	private MyCheckBox _CheckHiddenPageOther;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenSetupLaunch")]
	private MyCheckBox _CheckHiddenSetupLaunch;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenSetupLink")]
	private MyCheckBox _CheckHiddenSetupLink;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenSetupUI")]
	private MyCheckBox _CheckHiddenSetupUI;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenSetupSystem")]
	private MyCheckBox _CheckHiddenSetupSystem;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenOtherHelp")]
	private MyCheckBox _CheckHiddenOtherHelp;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenOtherAbout")]
	private MyCheckBox _CheckHiddenOtherAbout;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenOtherTest")]
	private MyCheckBox _CheckHiddenOtherTest;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenOtherFeedback")]
	private MyCheckBox _CheckHiddenOtherFeedback;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenOtherVote")]
	private MyCheckBox _CheckHiddenOtherVote;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckLauncherEmail")]
	private MyCheckBox _CheckLauncherEmail;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenFunctionSelect")]
	private MyCheckBox _CheckHiddenFunctionSelect;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenFunctionModUpdate")]
	private MyCheckBox _CheckHiddenFunctionModUpdate;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenFunctionHidden")]
	private MyCheckBox _CheckHiddenFunctionHidden;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckHiddenFunctionModify")]
	private MyCheckBox _CheckHiddenFunctionModify;

	[SpecialName]
	private bool _0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init;





































































































	public static bool HiddenForceShow
	{
		get
		{
			return _HiddenForceShow;
		}
		set
		{
			_HiddenForceShow = value;
			HiddenRefresh();
		}
	}

	private void Hook_PanBack(MyScrollViewer value)
	{
		_PanBack = value;
	}

	private void Hook_PanMain(StackPanel value)
	{
		_PanMain = value;
	}

	private void Hook_CardLauncher(MyCard value)
	{
		_CardLauncher = value;
	}

	private void Hook_SliderLauncherTransparent(MySlider value)
	{
		_SliderLauncherTransparent = value;
	}

	private void Hook_LabLauncherHue(TextBlock value)
	{
		_LabLauncherHue = value;
	}

	private void Hook_SliderLauncherHue(MySlider value)
	{
		MySlider.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HSL_Change();
		};
		MySlider mySlider = _SliderLauncherHue;
		if (mySlider != null)
		{
			mySlider.Change -= value2;
		}
		_SliderLauncherHue = value;
		mySlider = _SliderLauncherHue;
		if (mySlider != null)
		{
			mySlider.Change += value2;
		}
	}

	private void Hook_LabLauncherDelta(TextBlock value)
	{
		_LabLauncherDelta = value;
	}

	private void Hook_SliderLauncherDelta(MySlider value)
	{
		MySlider.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HSL_Change();
		};
		MySlider mySlider = _SliderLauncherDelta;
		if (mySlider != null)
		{
			mySlider.Change -= value2;
		}
		_SliderLauncherDelta = value;
		mySlider = _SliderLauncherDelta;
		if (mySlider != null)
		{
			mySlider.Change += value2;
		}
	}

	private void Hook_LabLauncherSat(TextBlock value)
	{
		_LabLauncherSat = value;
	}

	private void Hook_SliderLauncherSat(MySlider value)
	{
		MySlider.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HSL_Change();
		};
		MySlider mySlider = _SliderLauncherSat;
		if (mySlider != null)
		{
			mySlider.Change -= value2;
		}
		_SliderLauncherSat = value;
		mySlider = _SliderLauncherSat;
		if (mySlider != null)
		{
			mySlider.Change += value2;
		}
	}

	private void Hook_LabLauncherLight(TextBlock value)
	{
		_LabLauncherLight = value;
	}

	private void Hook_SliderLauncherLight(MySlider value)
	{
		MySlider.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HSL_Change();
		};
		MySlider mySlider = _SliderLauncherLight;
		if (mySlider != null)
		{
			mySlider.Change -= value2;
		}
		_SliderLauncherLight = value;
		mySlider = _SliderLauncherLight;
		if (mySlider != null)
		{
			mySlider.Change += value2;
		}
	}

	private void Hook_PanLauncherTheme(Grid value)
	{
		_PanLauncherTheme = value;
	}

	private void Hook_RadioLauncherTheme0(MyRadioBox value)
	{
		_RadioLauncherTheme0 = value;
	}

	private void Hook_RadioLauncherTheme1(MyRadioBox value)
	{
		_RadioLauncherTheme1 = value;
	}

	private void Hook_RadioLauncherTheme2(MyRadioBox value)
	{
		_RadioLauncherTheme2 = value;
	}

	private void Hook_RadioLauncherTheme3(MyRadioBox value)
	{
		_RadioLauncherTheme3 = value;
	}

	private void Hook_RadioLauncherTheme4(MyRadioBox value)
	{
		_RadioLauncherTheme4 = value;
	}

	private void Hook_RadioLauncherTheme5(MyRadioBox value)
	{
		_RadioLauncherTheme5 = value;
	}

	private void Hook_RadioLauncherTheme5Gray(MyRadioBox value)
	{
		_RadioLauncherTheme5Gray = value;
	}

	private void Hook_RadioLauncherTheme12(MyRadioBox value)
	{
		_RadioLauncherTheme12 = value;
	}

	private void Hook_RadioLauncherTheme6(MyRadioBox value)
	{
		_RadioLauncherTheme6 = value;
	}

	private void Hook_RadioLauncherTheme7(MyRadioBox value)
	{
		_RadioLauncherTheme7 = value;
	}

	private void Hook_RadioLauncherTheme13(MyRadioBox value)
	{
		_RadioLauncherTheme13 = value;
	}

	private void Hook_RadioLauncherTheme8(MyRadioBox value)
	{
		_RadioLauncherTheme8 = value;
	}

	private void Hook_RadioLauncherTheme9(MyRadioBox value)
	{
		_RadioLauncherTheme9 = value;
	}

	private void Hook_RadioLauncherTheme10(MyRadioBox value)
	{
		_RadioLauncherTheme10 = value;
	}

	private void Hook_RadioLauncherTheme11(MyRadioBox value)
	{
		_RadioLauncherTheme11 = value;
	}

	private void Hook_RadioLauncherTheme14(MyRadioBox value)
	{
		IMyRadio.ChangedEventHandler value2 = RadioLauncherTheme14_Change;
		MyRadioBox myRadioBox = _RadioLauncherTheme14;
		if (myRadioBox != null)
		{
			myRadioBox.Changed -= value2;
		}
		_RadioLauncherTheme14 = value;
		myRadioBox = _RadioLauncherTheme14;
		if (myRadioBox != null)
		{
			myRadioBox.Changed += value2;
		}
	}

	private void Hook_CardBackground(MyCard value)
	{
		_CardBackground = value;
	}

	private void Hook_PanBackgroundSuit(Grid value)
	{
		_PanBackgroundSuit = value;
	}

	private void Hook_PanBackgroundOpacity(Grid value)
	{
		_PanBackgroundOpacity = value;
	}

	private void Hook_SliderBackgroundOpacity(MySlider value)
	{
		_SliderBackgroundOpacity = value;
	}

	private void Hook_PanBackgroundBlur(Grid value)
	{
		_PanBackgroundBlur = value;
	}

	private void Hook_SliderBackgroundBlur(MySlider value)
	{
		_SliderBackgroundBlur = value;
	}

	private void Hook_BtnBackgroundOpen(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnUIBgOpen_Click;
		MyButton myButton = _BtnBackgroundOpen;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnBackgroundOpen = value;
		myButton = _BtnBackgroundOpen;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnBackgroundRefresh(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnBackgroundRefresh_Click;
		MyButton myButton = _BtnBackgroundRefresh;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnBackgroundRefresh = value;
		myButton = _BtnBackgroundRefresh;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnBackgroundClear(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnBackgroundClear_Click;
		MyButton myButton = _BtnBackgroundClear;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnBackgroundClear = value;
		myButton = _BtnBackgroundClear;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_CardMusic(MyCard value)
	{
		_CardMusic = value;
	}

	private void Hook_PanMusicVolume(Grid value)
	{
		_PanMusicVolume = value;
	}

	private void Hook_SliderMusicVolume(MySlider value)
	{
		_SliderMusicVolume = value;
	}

	private void Hook_PanMusicDetail(StackPanel value)
	{
		_PanMusicDetail = value;
	}

	private void Hook_CheckMusicRandom(MyCheckBox value)
	{
		_CheckMusicRandom = value;
	}

	private void Hook_CheckMusicAuto(MyCheckBox value)
	{
		_CheckMusicAuto = value;
	}

	private void Hook_CheckMusicStart(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			CheckMusicStart_Change();
		};
		MyCheckBox myCheckBox = _CheckMusicStart;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckMusicStart = value;
		myCheckBox = _CheckMusicStart;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckMusicStop(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			CheckMusicStop_Change();
		};
		MyCheckBox myCheckBox = _CheckMusicStop;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckMusicStop = value;
		myCheckBox = _CheckMusicStop;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_BtnMusicOpen(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnMusicOpen_Click;
		MyButton myButton = _BtnMusicOpen;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnMusicOpen = value;
		myButton = _BtnMusicOpen;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnMusicRefresh(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnMusicRefresh_Click;
		MyButton myButton = _BtnMusicRefresh;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnMusicRefresh = value;
		myButton = _BtnMusicRefresh;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnMusicClear(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnMusicClear_Click;
		MyButton myButton = _BtnMusicClear;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnMusicClear = value;
		myButton = _BtnMusicClear;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_CardLogo(MyCard value)
	{
		_CardLogo = value;
	}

	private void Hook_RadioLogoType0(MyRadioBox value)
	{
		_RadioLogoType0 = value;
	}

	private void Hook_RadioLogoType1(MyRadioBox value)
	{
		_RadioLogoType1 = value;
	}

	private void Hook_RadioLogoType2(MyRadioBox value)
	{
		_RadioLogoType2 = value;
	}

	private void Hook_RadioLogoType3(MyRadioBox value)
	{
		MyRadioBox.PreviewCheckEventHandler value2 = RadioLogoType3_Check;
		MyRadioBox myRadioBox = _RadioLogoType3;
		if (myRadioBox != null)
		{
			myRadioBox.PreviewCheck -= value2;
		}
		_RadioLogoType3 = value;
		myRadioBox = _RadioLogoType3;
		if (myRadioBox != null)
		{
			myRadioBox.PreviewCheck += value2;
		}
	}

	private void Hook_CheckLogoLeft(MyCheckBox value)
	{
		_CheckLogoLeft = value;
	}

	private void Hook_PanLogoText(Grid value)
	{
		_PanLogoText = value;
	}

	private void Hook_TextLogoText(MyTextBox value)
	{
		_TextLogoText = value;
	}

	private void Hook_PanLogoChange(Grid value)
	{
		_PanLogoChange = value;
	}

	private void Hook_BtnLogoChange(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnLogoChange_Click;
		MyButton myButton = _BtnLogoChange;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnLogoChange = value;
		myButton = _BtnLogoChange;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnLogoDelete(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnLogoDelete_Click;
		MyButton myButton = _BtnLogoDelete;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnLogoDelete = value;
		myButton = _BtnLogoDelete;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_CardCustom(MyCard value)
	{
		_CardCustom = value;
	}

	private void Hook_RadioCustomType0(MyRadioBox value)
	{
		_RadioCustomType0 = value;
	}

	private void Hook_RadioCustomType3(MyRadioBox value)
	{
		_RadioCustomType3 = value;
	}

	private void Hook_RadioCustomType1(MyRadioBox value)
	{
		_RadioCustomType1 = value;
	}

	private void Hook_RadioCustomType2(MyRadioBox value)
	{
		_RadioCustomType2 = value;
	}

	private void Hook_HintCustom(MyHint value)
	{
		_HintCustom = value;
	}

	private void Hook_HintCustomWarn(MyHint value)
	{
		_HintCustomWarn = value;
	}

	private void Hook_PanCustomLocal(WrapPanel value)
	{
		_PanCustomLocal = value;
	}

	private void Hook_BtnCustomRefresh(MyButton value)
	{
		MyButton.ClickEventHandler value2 = (object a0, MouseButtonEventArgs a1) =>
		{
			BtnCustomRefresh_Click();
		};
		MyButton myButton = _BtnCustomRefresh;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnCustomRefresh = value;
		myButton = _BtnCustomRefresh;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnCustomFile(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnCustomFile_Click;
		MyButton myButton = _BtnCustomFile;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnCustomFile = value;
		myButton = _BtnCustomFile;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnCustomTutorial(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnCustomTutorial_Click;
		MyButton myButton = _BtnCustomTutorial;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnCustomTutorial = value;
		myButton = _BtnCustomTutorial;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_BtnCustomFolder(MyButton value)
	{
		MyButton.ClickEventHandler value2 = BtnCustomFolder_Click;
		MyButton myButton = _BtnCustomFolder;
		if (myButton != null)
		{
			myButton.Click -= value2;
		}
		_BtnCustomFolder = value;
		myButton = _BtnCustomFolder;
		if (myButton != null)
		{
			myButton.Click += value2;
		}
	}

	private void Hook_PanCustomNet(Grid value)
	{
		_PanCustomNet = value;
	}

	private void Hook_TextCustomNet(MyTextBox value)
	{
		_TextCustomNet = value;
	}

	private void Hook_PanCustomPreset(Grid value)
	{
		_PanCustomPreset = value;
	}

	private void Hook_CardSwitch(MyCard value)
	{
		_CardSwitch = value;
	}

	private void Hook_CheckHiddenPageDownload(MyCheckBox value)
	{
		_CheckHiddenPageDownload = value;
	}

	private void Hook_CheckHiddenPageLink(MyCheckBox value)
	{
		_CheckHiddenPageLink = value;
	}

	private void Hook_CheckHiddenPageSetup(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenSetupMain();
		};
		MyCheckBox.ChangeEventHandler value3 = HiddenHint;
		MyCheckBox myCheckBox = _CheckHiddenPageSetup;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
			myCheckBox.Change -= value3;
		}
		_CheckHiddenPageSetup = value;
		myCheckBox = _CheckHiddenPageSetup;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
			myCheckBox.Change += value3;
		}
	}

	private void Hook_CheckHiddenPageOther(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenOtherMain();
		};
		MyCheckBox myCheckBox = _CheckHiddenPageOther;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenPageOther = value;
		myCheckBox = _CheckHiddenPageOther;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenSetupLaunch(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenSetupSub();
		};
		MyCheckBox myCheckBox = _CheckHiddenSetupLaunch;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenSetupLaunch = value;
		myCheckBox = _CheckHiddenSetupLaunch;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenSetupLink(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenSetupSub();
		};
		MyCheckBox myCheckBox = _CheckHiddenSetupLink;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenSetupLink = value;
		myCheckBox = _CheckHiddenSetupLink;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenSetupUI(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenSetupSub();
		};
		MyCheckBox.ChangeEventHandler value3 = HiddenHint;
		MyCheckBox myCheckBox = _CheckHiddenSetupUI;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
			myCheckBox.Change -= value3;
		}
		_CheckHiddenSetupUI = value;
		myCheckBox = _CheckHiddenSetupUI;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
			myCheckBox.Change += value3;
		}
	}

	private void Hook_CheckHiddenSetupSystem(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = (object a0, bool a1) =>
		{
			HiddenSetupSub();
		};
		MyCheckBox myCheckBox = _CheckHiddenSetupSystem;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenSetupSystem = value;
		myCheckBox = _CheckHiddenSetupSystem;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenOtherHelp(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenOtherSub;
		MyCheckBox myCheckBox = _CheckHiddenOtherHelp;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenOtherHelp = value;
		myCheckBox = _CheckHiddenOtherHelp;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenOtherAbout(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenOtherSub;
		MyCheckBox myCheckBox = _CheckHiddenOtherAbout;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenOtherAbout = value;
		myCheckBox = _CheckHiddenOtherAbout;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenOtherTest(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenOtherSub;
		MyCheckBox myCheckBox = _CheckHiddenOtherTest;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenOtherTest = value;
		myCheckBox = _CheckHiddenOtherTest;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenOtherFeedback(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenOtherNet;
		MyCheckBox myCheckBox = _CheckHiddenOtherFeedback;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenOtherFeedback = value;
		myCheckBox = _CheckHiddenOtherFeedback;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenOtherVote(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenOtherNet;
		MyCheckBox myCheckBox = _CheckHiddenOtherVote;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenOtherVote = value;
		myCheckBox = _CheckHiddenOtherVote;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckLauncherEmail(MyCheckBox value)
	{
		_CheckLauncherEmail = value;
	}

	private void Hook_CheckHiddenFunctionSelect(MyCheckBox value)
	{
		_CheckHiddenFunctionSelect = value;
	}

	private void Hook_CheckHiddenFunctionModUpdate(MyCheckBox value)
	{
		_CheckHiddenFunctionModUpdate = value;
	}

	private void Hook_CheckHiddenFunctionHidden(MyCheckBox value)
	{
		MyCheckBox.ChangeEventHandler value2 = HiddenHint;
		MyCheckBox myCheckBox = _CheckHiddenFunctionHidden;
		if (myCheckBox != null)
		{
			myCheckBox.Change -= value2;
		}
		_CheckHiddenFunctionHidden = value;
		myCheckBox = _CheckHiddenFunctionHidden;
		if (myCheckBox != null)
		{
			myCheckBox.Change += value2;
		}
	}

	private void Hook_CheckHiddenFunctionModify(MyCheckBox value)
	{
		_CheckHiddenFunctionModify = value;
	}

	public PageSetupUI()
	{
		Loaded += PageSetupUI_Loaded;
		Loaded += (object a0, RoutedEventArgs a1) =>
		{
			HiddenRefresh();
		};
		InitializeComponent();
		Hook_PanBack(PanBack);
		Hook_PanMain(PanMain);
		Hook_CardLauncher(CardLauncher);
		Hook_SliderLauncherTransparent(SliderLauncherTransparent);
		Hook_LabLauncherHue(LabLauncherHue);
		Hook_SliderLauncherHue(SliderLauncherHue);
		Hook_LabLauncherDelta(LabLauncherDelta);
		Hook_SliderLauncherDelta(SliderLauncherDelta);
		Hook_LabLauncherSat(LabLauncherSat);
		Hook_SliderLauncherSat(SliderLauncherSat);
		Hook_LabLauncherLight(LabLauncherLight);
		Hook_SliderLauncherLight(SliderLauncherLight);
		Hook_PanLauncherTheme(PanLauncherTheme);
		Hook_RadioLauncherTheme0(RadioLauncherTheme0);
		Hook_RadioLauncherTheme1(RadioLauncherTheme1);
		Hook_RadioLauncherTheme2(RadioLauncherTheme2);
		Hook_RadioLauncherTheme3(RadioLauncherTheme3);
		Hook_RadioLauncherTheme4(RadioLauncherTheme4);
		Hook_RadioLauncherTheme5(RadioLauncherTheme5);
		Hook_RadioLauncherTheme5Gray(RadioLauncherTheme5Gray);
		Hook_RadioLauncherTheme12(RadioLauncherTheme12);
		Hook_RadioLauncherTheme6(RadioLauncherTheme6);
		Hook_RadioLauncherTheme7(RadioLauncherTheme7);
		Hook_RadioLauncherTheme13(RadioLauncherTheme13);
		Hook_RadioLauncherTheme8(RadioLauncherTheme8);
		Hook_RadioLauncherTheme9(RadioLauncherTheme9);
		Hook_RadioLauncherTheme10(RadioLauncherTheme10);
		Hook_RadioLauncherTheme11(RadioLauncherTheme11);
		Hook_RadioLauncherTheme14(RadioLauncherTheme14);
		Hook_CardBackground(CardBackground);
		Hook_PanBackgroundSuit(PanBackgroundSuit);
		Hook_PanBackgroundOpacity(PanBackgroundOpacity);
		Hook_SliderBackgroundOpacity(SliderBackgroundOpacity);
		Hook_PanBackgroundBlur(PanBackgroundBlur);
		Hook_SliderBackgroundBlur(SliderBackgroundBlur);
		Hook_BtnBackgroundOpen(BtnBackgroundOpen);
		Hook_BtnBackgroundRefresh(BtnBackgroundRefresh);
		Hook_BtnBackgroundClear(BtnBackgroundClear);
		Hook_CardMusic(CardMusic);
		Hook_PanMusicVolume(PanMusicVolume);
		Hook_SliderMusicVolume(SliderMusicVolume);
		Hook_PanMusicDetail(PanMusicDetail);
		Hook_CheckMusicRandom(CheckMusicRandom);
		Hook_CheckMusicAuto(CheckMusicAuto);
		Hook_CheckMusicStart(CheckMusicStart);
		Hook_CheckMusicStop(CheckMusicStop);
		Hook_BtnMusicOpen(BtnMusicOpen);
		Hook_BtnMusicRefresh(BtnMusicRefresh);
		Hook_BtnMusicClear(BtnMusicClear);
		Hook_CardLogo(CardLogo);
		Hook_RadioLogoType0(RadioLogoType0);
		Hook_RadioLogoType1(RadioLogoType1);
		Hook_RadioLogoType2(RadioLogoType2);
		Hook_RadioLogoType3(RadioLogoType3);
		Hook_CheckLogoLeft(CheckLogoLeft);
		Hook_PanLogoText(PanLogoText);
		Hook_TextLogoText(TextLogoText);
		Hook_PanLogoChange(PanLogoChange);
		Hook_BtnLogoChange(BtnLogoChange);
		Hook_BtnLogoDelete(BtnLogoDelete);
		Hook_CardCustom(CardCustom);
		Hook_RadioCustomType0(RadioCustomType0);
		Hook_RadioCustomType3(RadioCustomType3);
		Hook_RadioCustomType1(RadioCustomType1);
		Hook_RadioCustomType2(RadioCustomType2);
		Hook_HintCustom(HintCustom);
		Hook_HintCustomWarn(HintCustomWarn);
		Hook_PanCustomLocal(PanCustomLocal);
		Hook_BtnCustomRefresh(BtnCustomRefresh);
		Hook_BtnCustomFile(BtnCustomFile);
		Hook_BtnCustomTutorial(BtnCustomTutorial);
		Hook_BtnCustomFolder(BtnCustomFolder);
		Hook_PanCustomNet(PanCustomNet);
		Hook_TextCustomNet(TextCustomNet);
		Hook_PanCustomPreset(PanCustomPreset);
		Hook_CardSwitch(CardSwitch);
		Hook_CheckHiddenPageDownload(CheckHiddenPageDownload);
		Hook_CheckHiddenPageLink(CheckHiddenPageLink);
		Hook_CheckHiddenPageSetup(CheckHiddenPageSetup);
		Hook_CheckHiddenPageOther(CheckHiddenPageOther);
		Hook_CheckHiddenSetupLaunch(CheckHiddenSetupLaunch);
		Hook_CheckHiddenSetupLink(CheckHiddenSetupLink);
		Hook_CheckHiddenSetupUI(CheckHiddenSetupUI);
		Hook_CheckHiddenSetupSystem(CheckHiddenSetupSystem);
		Hook_CheckHiddenOtherHelp(CheckHiddenOtherHelp);
		Hook_CheckHiddenOtherAbout(CheckHiddenOtherAbout);
		Hook_CheckHiddenOtherTest(CheckHiddenOtherTest);
		Hook_CheckHiddenOtherFeedback(CheckHiddenOtherFeedback);
		Hook_CheckHiddenOtherVote(CheckHiddenOtherVote);
		Hook_CheckLauncherEmail(CheckLauncherEmail);
		Hook_CheckHiddenFunctionSelect(CheckHiddenFunctionSelect);
		Hook_CheckHiddenFunctionModUpdate(CheckHiddenFunctionModUpdate);
		Hook_CheckHiddenFunctionHidden(CheckHiddenFunctionHidden);
		Hook_CheckHiddenFunctionModify(CheckHiddenFunctionModify);
	}

	private void PageSetupUI_Loaded(object sender, RoutedEventArgs e)
	{
		PanBack.ScrollToHome();
		ModSecret.ThemeCheckAll(EffectSetup: true);
		if (ModSecret.ThemeDontClick != 0)
		{
			string text = null;
			switch (ModSecret.ThemeDontClick)
			{
			case 1:
				text = "眼瞎白";
				break;
			case 2:
				text = "真·滑稽彩";
				break;
			}
			foreach (object child in PanLauncherTheme.Children)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(child);
				if (objectValue is MyRadioBox && ((MyRadioBox)objectValue).IsEnabled)
				{
					((MyRadioBox)objectValue).Text = text;
				}
			}
		}
		checked
		{
			ModAnimation.AniControlEnabled++;
			Refresh();
			ModAnimation.AniControlEnabled--;
			if (_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init == null)
			{
				Interlocked.CompareExchange(ref _0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init, new StaticLocalInitFlag(), null);
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init, ref lockTaken);
				if (_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init.State == 0)
				{
					_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init.State = 2;
					_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded = false;
				}
				else if (_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init.State = 1;
				if (lockTaken)
				{
					Monitor.Exit(_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded_0024Init);
				}
			}
			if (!_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded)
			{
				_0024STATIC_0024PageSetupUI_Loaded_002420211C128141_0024Reloaded = true;
				SliderLoad();
			}
		}
	}

	public void Refresh()
	{
		try
		{
			SettingService.RefreshSettings(this);
			BackgroundRefresh(IsHint: false, Refresh: false);
			CheckLogoLeft.Visibility = ((!RadioLogoType0.Checked) ? Visibility.Collapsed : Visibility.Visible);
			PanLogoText.Visibility = ((!RadioLogoType2.Checked) ? Visibility.Collapsed : Visibility.Visible);
			PanLogoChange.Visibility = ((!RadioLogoType3.Checked) ? Visibility.Collapsed : Visibility.Visible);
			MusicRefreshUI();
			OnMainPageTypeChanged();
		}
		catch (NullReferenceException ex)
		{
			ProjectData.SetProjectError(ex);
			Logger.Error(ex, "个性化设置项存在异常，已被自动重置", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			Reset();
			ProjectData.ClearProjectError();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Logger.Error(ex2, "重载个性化设置时出错", LogBehavior.AlertThenFeedback, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	public void Reset()
	{
		try
		{
			SettingService.ResetSettings(this);
			Logger.Info("已初始化个性化设置！", LogBehavior.None, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ModMain.Hint("已初始化个性化设置", ModMain.HintType.Green, Log: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logger.Error(ex, "初始化个性化设置失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ProjectData.ClearProjectError();
		}
		Refresh();
	}

	private void BtnUIBgOpen_Click(object sender, EventArgs e)
	{
		ModBase.OpenExplorer(Paths.Base + "PCL\\Pictures\\");
	}

	private void BtnBackgroundRefresh_Click(object sender, EventArgs e)
	{
		BackgroundRefresh(IsHint: true, Refresh: true);
	}

	public void BackgroundRefreshUI(bool Show, int Count)
	{
		if (!Information.IsNothing(PanBackgroundOpacity))
		{
			if (Show)
			{
				PanBackgroundOpacity.Visibility = Visibility.Visible;
				PanBackgroundBlur.Visibility = Visibility.Visible;
				PanBackgroundSuit.Visibility = Visibility.Visible;
				BtnBackgroundClear.Visibility = Visibility.Visible;
				CardBackground.Title = "背景图片（" + Conversions.ToString(Count) + " 张）";
			}
			else
			{
				PanBackgroundOpacity.Visibility = Visibility.Collapsed;
				PanBackgroundBlur.Visibility = Visibility.Collapsed;
				PanBackgroundSuit.Visibility = Visibility.Collapsed;
				BtnBackgroundClear.Visibility = Visibility.Collapsed;
				CardBackground.Title = "背景图片";
			}
			CardBackground.TriggerForceResize();
		}
	}

	private void BtnBackgroundClear_Click(object sender, EventArgs e)
	{
		if (ModMain.MyMsgBox("即将删除背景图片文件夹中的所有文件。\r\n此操作不可撤销，是否确定？", "警告", "确定", "取消", "", IsWarn: true) == 1)
		{
			DirectoryUtils.Delete(Paths.Base + "PCL\\Pictures");
			BackgroundRefresh(IsHint: false, Refresh: true);
			ModMain.Hint("背景图片已清空！", ModMain.HintType.Green);
		}
	}

	public static void BackgroundRefresh(bool IsHint, bool Refresh)
	{
		try
		{
			DirectoryUtils.Create(Paths.Base + "PCL\\Pictures\\");
			List<string> list = new List<string>();
			foreach (string item in DirectoryUtils.EnumerateFiles(Paths.Base + "PCL\\Pictures\\", includeSubDirectories: true))
			{
				string extension = PathUtils.GetExtension(item);
				if (Operators.CompareString(extension, "ini", TextCompare: false) != 0 && Operators.CompareString(extension, "db", TextCompare: false) != 0)
				{
					list.Add(item);
				}
			}
			if (!list.Any())
			{
				if (Refresh)
				{
					if (ModMain.FrmMain.ImgBack.Visibility == Visibility.Collapsed)
					{
						if (IsHint)
						{
							ModMain.Hint("未检测到可用背景图片！", ModMain.HintType.Red);
						}
					}
					else
					{
						ModMain.FrmMain.ImgBack.Visibility = Visibility.Collapsed;
						if (IsHint)
						{
							ModMain.Hint("背景图片已清除！", ModMain.HintType.Green);
						}
					}
				}
				if (!Information.IsNothing(ModMain.FrmSetupUI))
				{
					ModMain.FrmSetupUI.BackgroundRefreshUI(Show: false, 0);
				}
				return;
			}
			if (Refresh)
			{
				string text = ModBase.RandomOne(list);
				try
				{
					Logger.LogInterpolatedStringHandler<Logger.InfoLogLevel> handler = new Logger.LogInterpolatedStringHandler<Logger.InfoLogLevel>(7, 1, out var isEnabled);
					if (isEnabled)
					{
						handler.AppendLiteral("加载背景图片：");
						handler.AppendFormatted(text);
					}
					Logger.Info(ref handler, LogBehavior.None, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
					ModMain.FrmMain.ImgBack.Background = (ImageBrush)new MyBitmap(text);
					ModMain.FrmMain.ImgBack.Visibility = Visibility.Visible;
					ModMain.FrmMain.UpdateBackgroundAndTitleBar();
					if (IsHint)
					{
						ModMain.Hint("背景图片已刷新：" + PathUtils.GetLastPart(text), ModMain.HintType.Green, Log: false);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (ex2.Message.Contains("参数无效"))
					{
						Logger.Error(string.Format("刷新背景图片失败，该图片文件可能并非标准格式。{0}你可以尝试使用画图打开该文件并重新保存，这会让图片变为标准格式。{1}文件：{2}", "\r\n", "\r\n", text), LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
					}
					else
					{
						Logger.Error(ex2, "刷新背景图片失败（" + text + "）", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
					}
					ProjectData.ClearProjectError();
				}
			}
			if (!Information.IsNothing(ModMain.FrmSetupUI))
			{
				ModMain.FrmSetupUI.BackgroundRefreshUI(Show: true, list.Count);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Logger.Error(ex3, "刷新背景图片时出现未知错误", LogBehavior.AlertThenFeedback, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnLogoChange_Click(object sender, EventArgs e)
	{
		string text = Dialogs.SelectFile("选择图片", multiselect: false, null, OneOfHelper.From<IEnumerable<(string[], string)>, string>(new (string[], string)[1] { (new string[5] { "png", "jpg", "jpeg", "gif", "webp" }, "常用图片文件") })).FirstOrDefault();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Paths.Base + "PCL\\Logo.png";
		try
		{
			FileUtils.Copy(text, text2);
			ModMain.FrmMain.ImageTitleLogo.Source = null;
			ModMain.FrmMain.ImageTitleLogo.Source = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (ex2.Message.Contains("参数无效"))
			{
				Logger.Error(string.Format("改变标题栏图片失败，该图片文件可能并非标准格式。{0}你可以尝试使用画图打开该文件并重新保存，这会让图片变为标准格式。{1}文件：{2}", "\r\n", "\r\n", text2), LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			}
			else
			{
				Logger.Error(ex2, "设置标题栏图片失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			}
			ModMain.FrmMain.ImageTitleLogo.Source = null;
			ProjectData.ClearProjectError();
		}
	}

	private void RadioLogoType3_Check(object sender, ModBase.RouteEventArgs e)
	{
		if (ModAnimation.AniControlEnabled != 0 || !e.RaiseByMouse)
		{
			return;
		}
		while (true)
		{
			string text = Paths.Base + "PCL\\Logo.png";
			if (FileUtils.Exists(text))
			{
				try
				{
					ModMain.FrmMain.ImageTitleLogo.Source = null;
					ModMain.FrmMain.ImageTitleLogo.Source = text;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (ex2.Message.Contains("参数无效"))
					{
						Logger.Error(string.Format("改变标题栏图片失败，该图片文件可能并非标准格式。{0}你可以尝试使用画图打开该文件并重新保存，这会让图片变为标准格式。{1}文件：{2}", "\r\n", "\r\n", text), LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
					}
					else
					{
						Logger.Error(ex2, "调整标题栏图片失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
					}
					ModMain.FrmMain.ImageTitleLogo.Source = null;
					e.Handled = true;
					try
					{
						FileUtils.Delete(text);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Logger.Error(ex3, "清理错误的标题栏图片失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			string text2 = Dialogs.SelectFile("选择图片", multiselect: false, null, OneOfHelper.From<IEnumerable<(string[], string)>, string>(new (string[], string)[1] { (new string[5] { "png", "jpeg", "jpg", "gif", "webp" }, "常用图片文件") })).FirstOrDefault();
			if (string.IsNullOrEmpty(text2))
			{
				break;
			}
			try
			{
				FileUtils.Copy(text2, text);
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Logger.Error(ex4, "复制标题栏图片失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
				ProjectData.ClearProjectError();
				return;
			}
		}
		ModMain.FrmMain.ImageTitleLogo.Source = null;
		e.Handled = true;
	}

	private void BtnLogoDelete_Click(object sender, EventArgs e)
	{
		try
		{
			FileUtils.Delete(Paths.Base + "PCL\\Logo.png");
			RadioLogoType1.SetChecked(value: true, user: true);
			ModMain.Hint("标题栏图片已清空！", ModMain.HintType.Green);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logger.Error(ex, "清空标题栏图片失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnMusicOpen_Click(object sender, EventArgs e)
	{
		ModBase.OpenExplorer(Paths.Base + "PCL\\Musics\\");
	}

	private void BtnMusicRefresh_Click(object sender, EventArgs e)
	{
		ModMusic.MusicRefreshPlay(ShowHint: true);
	}

	public void MusicRefreshUI()
	{
		if (PanBackgroundOpacity == null)
		{
			return;
		}
		if (ModMusic.MusicAllList.Any())
		{
			PanMusicVolume.Visibility = Visibility.Visible;
			PanMusicDetail.Visibility = Visibility.Visible;
			BtnMusicClear.Visibility = Visibility.Visible;
			CardMusic.Title = "背景音乐（" + Conversions.ToString(DirectoryUtils.EnumerateFiles(Paths.Base + "PCL\\Musics\\", includeSubDirectories: true).Count((string f) => !new string[7] { "ini", "jpg", "txt", "cfg", "lrc", "db", "png" }.Contains(PathUtils.GetExtension(f)))) + " 首）";
		}
		else
		{
			PanMusicVolume.Visibility = Visibility.Collapsed;
			PanMusicDetail.Visibility = Visibility.Collapsed;
			BtnMusicClear.Visibility = Visibility.Collapsed;
			CardMusic.Title = "背景音乐";
		}
		CardMusic.TriggerForceResize();
	}

	private void BtnMusicClear_Click(object sender, EventArgs e)
	{
		if (ModMain.MyMsgBox("即将删除背景音乐文件夹中的所有文件。\r\n此操作不可撤销，是否确定？", "警告", "确定", "取消", "", IsWarn: true) != 1)
		{
			return;
		}
		ModBase.RunInThread(() =>
		{
			ModMain.Hint("正在删除背景音乐……");
			ModMusic.MusicNAudio = null;
			ModMusic.MusicWaitingList = new List<string>();
			ModMusic.MusicAllList = new List<string>();
			Thread.Sleep(200);
			try
			{
				DirectoryUtils.Delete(Paths.Base + "PCL\\Musics");
				ModMain.Hint("背景音乐已删除！", ModMain.HintType.Green);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Logger.Error(ex, "删除背景音乐失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
				ProjectData.ClearProjectError();
			}
			try
			{
				DirectoryUtils.Create(Paths.Base + "PCL\\Musics\\");
				ModBase.RunInUi(() =>
				{
					ModMusic.MusicRefreshPlay(ShowHint: false);
				});
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Logger.Error(ex2, "重建背景音乐文件夹失败", LogBehavior.Alert, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
				ProjectData.ClearProjectError();
			}
		});
	}

	private void CheckMusicStart_Change()
	{
		if (ModAnimation.AniControlEnabled == 0 && CheckMusicStart.Checked)
		{
			CheckMusicStop.Checked = false;
		}
	}

	private void CheckMusicStop_Change()
	{
		if (ModAnimation.AniControlEnabled == 0 && CheckMusicStop.Checked)
		{
			CheckMusicStart.Checked = false;
		}
	}

	private void BtnCustomFile_Click(object sender, EventArgs e)
	{
		try
		{
			if (!FileUtils.Exists(Paths.Base + "PCL\\Custom.xaml") || ModMain.MyMsgBox("当前已存在布局文件，继续生成教学文件将会覆盖现有布局文件！", "覆盖确认", "继续", "取消", "", IsWarn: true) != 2)
			{
				ModBase.ExtractResources(Paths.Base + "PCL\\Custom.xaml", "Custom");
				ModMain.Hint("教学文件已生成！", ModMain.HintType.Green);
				ModBase.OpenExplorer(Paths.Base + "PCL\\Custom.xaml");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Logger.Error(ex, "生成教学文件失败", LogBehavior.AlertThenFeedback, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnCustomRefresh_Click()
	{
		ModMain.FrmLaunchRight.ForceRefresh();
		ModMain.Hint("已刷新主页！", ModMain.HintType.Green);
	}

	private void BtnCustomTutorial_Click(object sender, EventArgs e)
	{
		ModMain.MyMsgBox("1. 点击 生成教学文件 按钮，这会在 PCL 文件夹下生成 Custom.xaml 布局文件。\r\n2. 使用记事本等工具打开这个文件并进行修改，修改完记得保存。\r\n3. 点击 刷新主页 按钮，查看主页现在长啥样了。\r\n\r\n你可以在生成教学文件后直接刷新主页，对照着进行修改，更有助于理解。\r\n直接将主页文件拖进 PCL 窗口也可以快捷加载。", "主页自定义教程");
	}

	public static void OnMainPageTypeChanged()
	{
		if (ModMain.FrmSetupUI != null)
		{
			switch (Settings.Get<int>("UiCustomType"))
			{
			case 0:
				ModMain.FrmSetupUI.PanCustomPreset.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomLocal.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomNet.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.HintCustom.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.HintCustomWarn.Visibility = Visibility.Collapsed;
				break;
			case 1:
				ModMain.FrmSetupUI.PanCustomPreset.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomLocal.Visibility = Visibility.Visible;
				ModMain.FrmSetupUI.PanCustomNet.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.HintCustom.Visibility = Visibility.Visible;
				ModMain.FrmSetupUI.HintCustomWarn.Visibility = (Settings.Get<bool>("HintCustomWarn") ? Visibility.Collapsed : Visibility.Visible);
				ModMain.FrmSetupUI.HintCustom.Text = string.Format("从 PCL 文件夹下的 Custom.xaml 读取主页内容。{0}你可以手动编辑该文件，向主页添加文本、图片、常用网站、快捷启动等功能。", "\r\n");
				CustomEventService.SetEventType(ModMain.FrmSetupUI.HintCustom, CustomEvent.EventType.None);
				break;
			case 2:
				ModMain.FrmSetupUI.PanCustomPreset.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomLocal.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomNet.Visibility = Visibility.Visible;
				ModMain.FrmSetupUI.HintCustom.Visibility = Visibility.Visible;
				ModMain.FrmSetupUI.HintCustomWarn.Visibility = (Settings.Get<bool>("HintCustomWarn") ? Visibility.Collapsed : Visibility.Visible);
				ModMain.FrmSetupUI.HintCustom.Text = string.Format("从指定网址联网获取主页内容。服主也可以用于动态更新服务器公告。{0}如果你制作了稳定运行的联网主页，可以点击这条提示投稿，若合格即可加入预设！", "\r\n");
				CustomEventService.SetEventType(ModMain.FrmSetupUI.HintCustom, CustomEvent.EventType.打开网页);
				CustomEventService.SetEventData(ModMain.FrmSetupUI.HintCustom, "https://github.com/Meloong-Git/PCL/discussions/2528");
				break;
			case 3:
				ModMain.FrmSetupUI.PanCustomPreset.Visibility = Visibility.Visible;
				ModMain.FrmSetupUI.PanCustomLocal.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.PanCustomNet.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.HintCustom.Visibility = Visibility.Collapsed;
				ModMain.FrmSetupUI.HintCustomWarn.Visibility = Visibility.Collapsed;
				break;
			}
			ModMain.FrmSetupUI.CardCustom.TriggerForceResize();
		}
	}

	private void BtnCustomFolder_Click(object sender, MouseButtonEventArgs e)
	{
		string text = Paths.Base + "PCL\\Custom.xaml";
		if (FileUtils.Exists(text))
		{
			ModBase.OpenExplorer(text);
		}
		else
		{
			ModBase.OpenExplorer(Paths.Base + "PCL\\");
		}
	}

	private void RadioLauncherTheme14_Change(object sender, ModBase.RouteEventArgs e)
	{
		if (RadioLauncherTheme14.Checked)
		{
			if (LabLauncherHue.Visibility == Visibility.Visible)
			{
				return;
			}
			LabLauncherHue.Visibility = Visibility.Visible;
			SliderLauncherHue.Visibility = Visibility.Visible;
			LabLauncherSat.Visibility = Visibility.Visible;
			SliderLauncherSat.Visibility = Visibility.Visible;
			LabLauncherDelta.Visibility = Visibility.Visible;
			SliderLauncherDelta.Visibility = Visibility.Visible;
			LabLauncherLight.Visibility = Visibility.Visible;
			SliderLauncherLight.Visibility = Visibility.Visible;
		}
		else
		{
			if (LabLauncherHue.Visibility == Visibility.Collapsed)
			{
				return;
			}
			LabLauncherHue.Visibility = Visibility.Collapsed;
			SliderLauncherHue.Visibility = Visibility.Collapsed;
			LabLauncherSat.Visibility = Visibility.Collapsed;
			SliderLauncherSat.Visibility = Visibility.Collapsed;
			LabLauncherDelta.Visibility = Visibility.Collapsed;
			SliderLauncherDelta.Visibility = Visibility.Collapsed;
			LabLauncherLight.Visibility = Visibility.Collapsed;
			SliderLauncherLight.Visibility = Visibility.Collapsed;
		}
		CardLauncher.TriggerForceResize();
	}

	private void HSL_Change()
	{
		if (ModAnimation.AniControlEnabled == 0 && SliderLauncherSat != null && SliderLauncherSat.IsLoaded)
		{
			ModSecret.ThemeRefresh();
		}
	}

	public static void HiddenRefresh()
	{
		if (ModMain.FrmMain.PanTitleSelect == null || !ModMain.FrmMain.PanTitleSelect.IsLoaded)
		{
			return;
		}
		checked
		{
			try
			{
				if (!HiddenForceShow && Settings.Get<bool>("UiHiddenPageDownload") && Settings.Get<bool>("UiHiddenPageLink") && Settings.Get<bool>("UiHiddenPageSetup") && Settings.Get<bool>("UiHiddenPageOther"))
				{
					ModMain.FrmMain.PanTitleSelect.Visibility = Visibility.Collapsed;
				}
				else
				{
					ModMain.FrmMain.PanTitleSelect.Visibility = Visibility.Visible;
					ModMain.FrmMain.BtnTitleSelect1.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenPageDownload")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmMain.BtnTitleSelect2.Visibility = Visibility.Collapsed;
					ModMain.FrmMain.BtnTitleSelect3.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenPageSetup")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmMain.BtnTitleSelect4.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenPageOther")) ? Visibility.Collapsed : Visibility.Visible);
				}
				ModMain.FrmLaunchLeft.RefreshButtonsUI();
				if (ModMain.FrmSetupUI != null)
				{
					ModMain.FrmSetupUI.CardSwitch.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenFunctionHidden")) ? Visibility.Collapsed : Visibility.Visible);
				}
				if (ModMain.FrmInstanceLeft != null)
				{
					ModMain.FrmInstanceLeft.ItemModify.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenFunctionInstanceModify")) ? Visibility.Collapsed : Visibility.Visible);
				}
				if (ModMain.FrmSetupLeft != null)
				{
					ModMain.FrmSetupLeft.ItemLaunch.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenSetupLaunch")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmSetupLeft.ItemUI.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenSetupUi")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmSetupLeft.ItemLink.Visibility = Visibility.Collapsed;
					ModMain.FrmSetupLeft.ItemSystem.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenSetupSystem")) ? Visibility.Collapsed : Visibility.Visible);
					int num = 0;
					if (!Settings.Get<bool>("UiHiddenSetupLaunch"))
					{
						num++;
					}
					if (!Settings.Get<bool>("UiHiddenSetupUi"))
					{
						num++;
					}
					if (!Settings.Get<bool>("UiHiddenSetupSystem"))
					{
						num++;
					}
					ModMain.FrmSetupLeft.PanItem.Visibility = ((num < 2 && !HiddenForceShow) ? Visibility.Collapsed : Visibility.Visible);
				}
				int num2 = 0;
				if (!Settings.Get<bool>("UiHiddenOtherHelp"))
				{
					num2++;
				}
				if (!Settings.Get<bool>("UiHiddenOtherAbout"))
				{
					num2++;
				}
				if (!Settings.Get<bool>("UiHiddenOtherTest"))
				{
					num2++;
				}
				if (!Settings.Get<bool>("UiHiddenOtherFeedback"))
				{
					num2++;
				}
				if (!Settings.Get<bool>("UiHiddenOtherVote"))
				{
					num2++;
				}
				if (ModMain.FrmOtherLeft != null)
				{
					ModMain.FrmOtherLeft.ItemHelp.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenOtherHelp")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmOtherLeft.ItemFeedback.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenOtherFeedback")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmOtherLeft.ItemVote.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenOtherVote")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmOtherLeft.ItemAbout.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenOtherAbout")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmOtherLeft.ItemTest.Visibility = ((!HiddenForceShow && Settings.Get<bool>("UiHiddenOtherTest")) ? Visibility.Collapsed : Visibility.Visible);
					ModMain.FrmOtherLeft.PanItem.Visibility = ((num2 < 2 && !HiddenForceShow) ? Visibility.Collapsed : Visibility.Visible);
				}
				if (num2 == 1 && !HiddenForceShow)
				{
					if (!Settings.Get<bool>("UiHiddenOtherHelp"))
					{
						ModMain.FrmMain.BtnTitleSelect4.Text = "帮助";
					}
					else if (!Settings.Get<bool>("UiHiddenOtherAbout"))
					{
						ModMain.FrmMain.BtnTitleSelect4.Text = "关于";
					}
					else
					{
						ModMain.FrmMain.BtnTitleSelect4.Text = "百宝箱";
					}
				}
				else
				{
					ModMain.FrmMain.BtnTitleSelect4.Text = "更多";
				}
				if (ModMain.FrmMain.PageCurrent == FormMain.PageType.InstanceSelect)
				{
					ModMain.FrmSelectRight.BtnEmptyDownload_Loaded();
				}
				if (ModMain.FrmMain.PageCurrent == FormMain.PageType.Launch)
				{
					ModMain.FrmLaunchLeft.RefreshButtonsUI();
				}
				if (ModMain.FrmMain.PageCurrent == FormMain.PageType.InstanceSetup && ModMain.FrmInstanceModDisabled != null)
				{
					ModMain.FrmInstanceModDisabled.BtnDownload_Loaded();
				}
				if (ModMain.FrmSetupUI != null)
				{
					ModMain.FrmSetupUI.CardSwitch.Title = (HiddenForceShow ? "功能隐藏（已暂时关闭，按 F12 以重新启用）" : "功能隐藏");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Logger.Error(ex, "刷新功能隐藏项目失败", LogBehavior.AlertThenFeedback, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupUI.xaml.vb");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void HiddenSetupMain()
	{
		if (CheckHiddenPageSetup.Checked)
		{
			CheckHiddenSetupLaunch.Checked = true;
			CheckHiddenSetupSystem.Checked = true;
			CheckHiddenSetupLink.Checked = true;
			CheckHiddenSetupUI.Checked = true;
		}
		else if (Settings.Get<bool>("UiHiddenSetupLaunch") && Settings.Get<bool>("UiHiddenSetupUi") && Settings.Get<bool>("UiHiddenSetupSystem") && Settings.Get<bool>("UiHiddenSetupLink"))
		{
			CheckHiddenSetupLaunch.Checked = false;
			CheckHiddenSetupSystem.Checked = false;
			CheckHiddenSetupLink.Checked = false;
			CheckHiddenSetupUI.Checked = false;
		}
	}

	private void HiddenSetupSub()
	{
		if (Settings.Get<bool>("UiHiddenSetupLaunch") && Settings.Get<bool>("UiHiddenSetupUi") && Settings.Get<bool>("UiHiddenSetupSystem") && Settings.Get<bool>("UiHiddenSetupLink"))
		{
			CheckHiddenPageSetup.Checked = true;
		}
		else
		{
			CheckHiddenPageSetup.Checked = false;
		}
	}

	private void HiddenOtherMain()
	{
		if (CheckHiddenPageOther.Checked)
		{
			CheckHiddenOtherAbout.Checked = true;
			CheckHiddenOtherTest.Checked = true;
			CheckHiddenOtherFeedback.Checked = true;
			CheckHiddenOtherVote.Checked = true;
			CheckHiddenOtherHelp.Checked = true;
		}
		else if (Settings.Get<bool>("UiHiddenOtherHelp") && Settings.Get<bool>("UiHiddenOtherAbout") && Settings.Get<bool>("UiHiddenOtherTest") && Settings.Get<bool>("UiHiddenOtherVote") && Settings.Get<bool>("UiHiddenOtherFeedback"))
		{
			CheckHiddenOtherAbout.Checked = false;
			CheckHiddenOtherTest.Checked = false;
			CheckHiddenOtherFeedback.Checked = false;
			CheckHiddenOtherVote.Checked = false;
			CheckHiddenOtherHelp.Checked = false;
		}
	}

	private void HiddenOtherSub(object sender, bool user)
	{
		if (Settings.Get<bool>("UiHiddenOtherHelp") && Settings.Get<bool>("UiHiddenOtherAbout") && Settings.Get<bool>("UiHiddenOtherTest"))
		{
			CheckHiddenPageOther.Checked = true;
		}
		else
		{
			CheckHiddenPageOther.Checked = false;
		}
		if (user && Settings.Get<bool>("UiHiddenOtherHelp") && Settings.Get<bool>("UiHiddenOtherAbout") && Settings.Get<bool>("UiHiddenOtherTest"))
		{
			CheckHiddenOtherFeedback.Checked = true;
			CheckHiddenOtherVote.Checked = true;
		}
	}

	private void HiddenOtherNet(object sender, bool user)
	{
		if (user && Settings.Get<bool>("UiHiddenOtherHelp") && Settings.Get<bool>("UiHiddenOtherAbout") && Settings.Get<bool>("UiHiddenOtherTest") && (!Settings.Get<bool>("UiHiddenOtherFeedback") || !Settings.Get<bool>("UiHiddenOtherVote")))
		{
			CheckHiddenOtherAbout.Checked = false;
			CheckHiddenOtherTest.Checked = false;
			CheckHiddenOtherHelp.Checked = false;
		}
	}

	private void HiddenHint(object sender, bool user)
	{
		if (Conversions.ToBoolean(ModAnimation.AniControlEnabled == 0 && Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null))))
		{
			ModMain.Hint("按 F12 即可暂时关闭功能隐藏设置。千万别忘了，要不然设置就改不回来了……");
		}
	}

	private void SliderLoad()
	{
		SliderMusicVolume.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.MultiplyObject(v, 0.1) }, null, null, null), "%"));
		SliderLauncherTransparent.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[1] { Operators.AddObject(40, Operators.MultiplyObject(v, 0.1)) }, null, null, null), "%"));
		SliderLauncherHue.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(v, "°"));
		SliderLauncherSat.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(v, "%"));
		checked
		{
			SliderLauncherDelta.GetHintText = (VB_0024AnonymousDelegate_26<int, string>)((int Value) =>
			{
				if (Value > 90)
				{
					return "+" + Conversions.ToString(Value - 90);
				}
				return (Value != 90) ? Conversions.ToString(Value - 90) : Conversions.ToString(0);
			});
			SliderLauncherLight.GetHintText = (VB_0024AnonymousDelegate_26<int, string>)((int Value) =>
			{
				if (Value > 20)
				{
					return "+" + Conversions.ToString(Value - 20);
				}
				return (Value != 20) ? Conversions.ToString(Value - 20) : Conversions.ToString(0);
			});
			SliderBackgroundOpacity.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[1] { Operators.MultiplyObject(v, 0.1) }, null, null, null), "%"));
			SliderBackgroundBlur.GetHintText = (VB_0024AnonymousDelegate_25<object, object>)((object v) => Operators.ConcatenateObject(v, " 像素"));
		}
	}
}
