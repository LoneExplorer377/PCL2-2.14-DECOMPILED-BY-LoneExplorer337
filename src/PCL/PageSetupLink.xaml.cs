using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using MeloongCore;
using Microsoft.VisualBasic.CompilerServices;

namespace PCL;

[DesignerGenerated]
public partial class PageSetupLink : MyPageRight, IComponentConnector
{
	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyScrollViewer _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMain")]
	private StackPanel _PanMain;

	[CompilerGenerated]
	[AccessedThroughProperty("CardArgument")]
	private MyCard _CardArgument;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboLatencyMode")]
	private MyComboBox _ComboLatencyMode;

	[CompilerGenerated]
	[AccessedThroughProperty("TextCustomPeer")]
	private MyTextBox _TextCustomPeer;

	[SpecialName]
	private bool _0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init;

	private void Hook_PanBack(MyScrollViewer value)
	{
		_PanBack = value;
		
	}


	private void Hook_PanMain(StackPanel value)
	{
		_PanMain = value;
		
	}


	private void Hook_CardArgument(MyCard value)
	{
		_CardArgument = value;
		
	}


	private void Hook_ComboLatencyMode(MyComboBox value)
	{
		_ComboLatencyMode = value;
		
	}


	private void Hook_TextCustomPeer(MyTextBox value)
	{
		_TextCustomPeer = value;
		
	}


	public PageSetupLink()
	{
		Loaded += PageSetupLink_Loaded;
		InitializeComponent();
			Hook_PanBack(PanBack);
			Hook_PanMain(PanMain);
			Hook_CardArgument(CardArgument);
			Hook_ComboLatencyMode(ComboLatencyMode);
			Hook_TextCustomPeer(TextCustomPeer);
	}

	private void PageSetupLink_Loaded(object sender, RoutedEventArgs e)
	{
		PanBack.ScrollToHome();
		if (_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init, ref lockTaken);
			if (_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init.State == 0)
			{
				_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init.State = 2;
				_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded = false;
			}
			else if (_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded_0024Init);
			}
		}
		checked
		{
			if (!_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded)
			{
				_0024STATIC_0024PageSetupLink_Loaded_002420211C128141_0024IsLoaded = true;
				ModAnimation.AniControlEnabled++;
				Reload();
				ModAnimation.AniControlEnabled--;
			}
		}
	}

	public void Reload()
	{
		SettingService.RefreshSettings(this);
	}

	public void Reset()
	{
		try
		{
			SettingService.ResetSettings(this);
			Logger.Info("已初始化联机页设置", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupLink.xaml.vb");
			ModMain.Hint("已初始化联机页设置！", ModMain.HintType.Green, Log: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Logger.Error(ex2, "初始化联机页设置失败", (LogBehavior)3, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageSetup\\PageSetupLink.xaml.vb");
			ProjectData.ClearProjectError();
		}
		Reload();
	}

}
