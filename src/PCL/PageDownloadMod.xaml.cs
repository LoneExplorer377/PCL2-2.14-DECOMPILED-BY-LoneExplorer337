using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace PCL;

[DesignerGenerated]
public partial class PageDownloadMod : MyPageRight, IComponentConnector
{
	[CompilerGenerated]
	[AccessedThroughProperty("Content")]
	private PageResource _Content;

	private void Hook_Content(PageResource value)
	{
		_Content = value;
		
	}


	public PageDownloadMod()
	{
		InitializeComponent();
			Hook_Content(Content);
	}

}
