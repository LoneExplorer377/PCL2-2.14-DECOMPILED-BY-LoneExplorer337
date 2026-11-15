using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace PCL;

[DesignerGenerated]
public partial class PageSpeedRight : MyPageRight, IComponentConnector
{
	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyScrollViewer _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PanMain")]
	private StackPanel _PanMain;

	internal virtual MyScrollViewer PanBack
	{
		[CompilerGenerated]
		get
		{
			return _PanBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PanBack = value;
		}
	}

	internal virtual StackPanel PanMain
	{
		[CompilerGenerated]
		get
		{
			return _PanMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PanMain = value;
		}
	}

	public PageSpeedRight()
	{
		Loaded += [SpecialName] (object a0, RoutedEventArgs a1) =>
		{
			Init();
		};
		InitializeComponent();
	}

	private void Init()
	{
		PanBack.ScrollToHome();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}
}
