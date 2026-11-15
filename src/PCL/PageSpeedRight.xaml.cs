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

	private void Hook_PanBack(MyScrollViewer value)
	{
		_PanBack = value;
		
	}


	private void Hook_PanMain(StackPanel value)
	{
		_PanMain = value;
		
	}


	public PageSpeedRight()
	{
		Loaded += [SpecialName] (object a0, RoutedEventArgs a1) =>
		{
			Init();
		};
		InitializeComponent();
			Hook_PanBack(PanBack);
			Hook_PanMain(PanMain);
	}

	private void Init()
	{
		PanBack.ScrollToHome();
	}

}
