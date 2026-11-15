using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using MeloongCore;
using Microsoft.VisualBasic.CompilerServices;
using PCLCS;

namespace PCL;

[DesignerGenerated]
public partial class MyResourceItem : Grid, IComponentConnector
{
	public delegate void ClickEventHandler(object sender, MouseButtonEventArgs e);

	public int Uuid;

	private bool IsMouseDown;

	private Border _RectBack;

	private string StateLast;

	[CompilerGenerated]
	[AccessedThroughProperty("PanBack")]
	private MyResourceItem _PanBack;

	[CompilerGenerated]
	[AccessedThroughProperty("PathLogo")]
	private MyImage _PathLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("LabTitle")]
	private TextBlock _LabTitle;

	[CompilerGenerated]
	[AccessedThroughProperty("LabTitleRaw")]
	private TextBlock _LabTitleRaw;

	[CompilerGenerated]
	[AccessedThroughProperty("PanTags")]
	private StackPanel _PanTags;

	[CompilerGenerated]
	[AccessedThroughProperty("LabInfo")]
	private TextBlock _LabInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolTipInfo")]
	private ToolTip _ToolTipInfo;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnVersion1")]
	private ColumnDefinition _ColumnVersion1;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnVersion2")]
	private ColumnDefinition _ColumnVersion2;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnVersion3")]
	private ColumnDefinition _ColumnVersion3;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnTime1")]
	private ColumnDefinition _ColumnTime1;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnTime2")]
	private ColumnDefinition _ColumnTime2;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnTime3")]
	private ColumnDefinition _ColumnTime3;

	[CompilerGenerated]
	[AccessedThroughProperty("PathVersion")]
	private Path _PathVersion;

	[CompilerGenerated]
	[AccessedThroughProperty("LabVersion")]
	private TextBlock _LabVersion;

	[CompilerGenerated]
	[AccessedThroughProperty("PathDownload")]
	private Path _PathDownload;

	[CompilerGenerated]
	[AccessedThroughProperty("LabDownload")]
	private TextBlock _LabDownload;

	[CompilerGenerated]
	[AccessedThroughProperty("PathTime")]
	private Path _PathTime;

	[CompilerGenerated]
	[AccessedThroughProperty("LabTime")]
	private TextBlock _LabTime;

	[CompilerGenerated]
	[AccessedThroughProperty("PathSource")]
	private Path _PathSource;

	[CompilerGenerated]
	[AccessedThroughProperty("LabSource")]
	private TextBlock _LabSource;

	public string Title
	{
		get
		{
			return LabTitle.Text;
		}
		set
		{
			if (Operators.CompareString(LabTitle.Text, value, TextCompare: false) != 0)
			{
				LabTitle.Text = value;
			}
		}
	}

	public string SubTitle
	{
		get
		{
			return LabTitleRaw?.Text ?? "";
		}
		set
		{
			if (Operators.CompareString(LabTitleRaw.Text, value, TextCompare: false) != 0)
			{
				LabTitleRaw.Text = value;
				LabTitleRaw.Visibility = ((Operators.CompareString(value, "", TextCompare: false) == 0) ? Visibility.Collapsed : Visibility.Visible);
			}
		}
	}

	public string Description
	{
		get
		{
			return LabInfo.Text;
		}
		set
		{
			if (Operators.CompareString(LabInfo.Text, value, TextCompare: false) != 0)
			{
				LabInfo.Text = value;
			}
		}
	}

	public List<string> Tags
	{
		set
		{
			PanTags.Children.Clear();
			PanTags.Visibility = ((!value.Any()) ? Visibility.Collapsed : Visibility.Visible);
			foreach (string item in value)
			{
				Border border = new Border
				{
					Background = new ModBase.MyColor("#11000000"),
					Padding = new Thickness(3.0, 1.0, 3.0, 1.0),
					CornerRadius = new CornerRadius(3.0),
					Margin = new Thickness(0.0, 0.0, 3.0, 0.0),
					SnapsToDevicePixels = true,
					UseLayoutRounding = false
				};
				TextBlock child = new TextBlock
				{
					Text = item,
					Foreground = new ModBase.MyColor("#868686"),
					FontSize = 11.0
				};
				border.Child = child;
				PanTags.Children.Add(border);
			}
		}
	}

	public Border RectBack
	{
		get
		{
			if (_RectBack == null)
			{
				Border border = new Border
				{
					Name = "RectBack",
					CornerRadius = new CornerRadius(3.0),
					RenderTransform = new ScaleTransform(0.8, 0.8),
					RenderTransformOrigin = new Point(0.5, 0.5),
					BorderThickness = new Thickness(ModBase.GetWPFSize(1.0)),
					SnapsToDevicePixels = true,
					IsHitTestVisible = false,
					Opacity = 0.0
				};
				border.SetResourceReference(Border.BackgroundProperty, "ColorBrush7");
				border.SetResourceReference(Border.BorderBrushProperty, "ColorBrush6");
				Grid.SetColumnSpan(border, 999);
				Grid.SetRowSpan(border, 999);
				Children.Insert(0, border);
				_RectBack = border;
			}
			return _RectBack;
		}
	}

	public bool CanInteraction { get; set; }

	internal virtual MyResourceItem PanBack
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

	internal virtual MyImage PathLogo
	{
		[CompilerGenerated]
		get
		{
			return _PathLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PathLogo = value;
		}
	}

	internal virtual TextBlock LabTitle
	{
		[CompilerGenerated]
		get
		{
			return _LabTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabTitle = value;
		}
	}

	internal virtual TextBlock LabTitleRaw
	{
		[CompilerGenerated]
		get
		{
			return _LabTitleRaw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabTitleRaw = value;
		}
	}

	internal virtual StackPanel PanTags
	{
		[CompilerGenerated]
		get
		{
			return _PanTags;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PanTags = value;
		}
	}

	internal virtual TextBlock LabInfo
	{
		[CompilerGenerated]
		get
		{
			return _LabInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = LabInfo_MouseEnter;
			TextBlock textBlock = _LabInfo;
			if (textBlock != null)
			{
				textBlock.MouseEnter -= value2;
			}
			_LabInfo = value;
			textBlock = _LabInfo;
			if (textBlock != null)
			{
				textBlock.MouseEnter += value2;
			}
		}
	}

	internal virtual ToolTip ToolTipInfo
	{
		[CompilerGenerated]
		get
		{
			return _ToolTipInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ToolTipInfo = value;
		}
	}

	internal virtual ColumnDefinition ColumnVersion1
	{
		[CompilerGenerated]
		get
		{
			return _ColumnVersion1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnVersion1 = value;
		}
	}

	internal virtual ColumnDefinition ColumnVersion2
	{
		[CompilerGenerated]
		get
		{
			return _ColumnVersion2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnVersion2 = value;
		}
	}

	internal virtual ColumnDefinition ColumnVersion3
	{
		[CompilerGenerated]
		get
		{
			return _ColumnVersion3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnVersion3 = value;
		}
	}

	internal virtual ColumnDefinition ColumnTime1
	{
		[CompilerGenerated]
		get
		{
			return _ColumnTime1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnTime1 = value;
		}
	}

	internal virtual ColumnDefinition ColumnTime2
	{
		[CompilerGenerated]
		get
		{
			return _ColumnTime2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnTime2 = value;
		}
	}

	internal virtual ColumnDefinition ColumnTime3
	{
		[CompilerGenerated]
		get
		{
			return _ColumnTime3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_ColumnTime3 = value;
		}
	}

	internal virtual Path PathVersion
	{
		[CompilerGenerated]
		get
		{
			return _PathVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PathVersion = value;
		}
	}

	internal virtual TextBlock LabVersion
	{
		[CompilerGenerated]
		get
		{
			return _LabVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabVersion = value;
		}
	}

	internal virtual Path PathDownload
	{
		[CompilerGenerated]
		get
		{
			return _PathDownload;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PathDownload = value;
		}
	}

	internal virtual TextBlock LabDownload
	{
		[CompilerGenerated]
		get
		{
			return _LabDownload;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabDownload = value;
		}
	}

	internal virtual Path PathTime
	{
		[CompilerGenerated]
		get
		{
			return _PathTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PathTime = value;
		}
	}

	internal virtual TextBlock LabTime
	{
		[CompilerGenerated]
		get
		{
			return _LabTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabTime = value;
		}
	}

	internal virtual Path PathSource
	{
		[CompilerGenerated]
		get
		{
			return _PathSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_PathSource = value;
		}
	}

	internal virtual TextBlock LabSource
	{
		[CompilerGenerated]
		get
		{
			return _LabSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_LabSource = value;
		}
	}

	public event ClickEventHandler Click;

	public MyResourceItem()
	{
		PreviewMouseLeftButtonUp += Button_MouseUp;
		Click += [SpecialName] (object a0, MouseButtonEventArgs a1) =>
		{
			MyResourceItem_Click((MyResourceItem)a0, a1);
		};
		PreviewMouseLeftButtonDown += Button_MouseDown;
		MouseLeave += Button_MouseLeave;
		PreviewMouseLeftButtonUp += Button_MouseLeave;
		MouseEnter += RefreshColor;
		MouseLeave += RefreshColor;
		MouseLeftButtonDown += RefreshColor;
		MouseLeftButtonUp += RefreshColor;
		Uuid = ModBase.GetUuid();
		IsMouseDown = false;
		_RectBack = null;
		CanInteraction = true;
		InitializeComponent();
	}

	private void LabInfo_MouseEnter(object sender, MouseEventArgs e)
	{
		ToolTipInfo.Content = LabInfo.Text;
		LabInfo.ToolTip = (ModBase.IsTextTrimmed(LabInfo) ? ToolTipInfo : null);
	}

	private void Button_MouseUp(object sender, MouseButtonEventArgs e)
	{
		if (IsMouseDown)
		{
			Click?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
			if (!e.Handled)
			{
				Logger.Info($"按下资源工程列表项：{LabTitle.Text}", (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\MyResourceItem.xaml.vb");
			}
		}
	}

	private void MyResourceItem_Click(MyResourceItem sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		if (ModMain.FrmMain.PageCurrent.Page == FormMain.PageType.ResourceDetail)
		{
			foreach (MyCard child in ModMain.FrmDownloadResourceDetail.PanResults.Children)
			{
				if (Operators.CompareString(child.Title, "", TextCompare: false) != 0 && !child.IsSwapped)
				{
					list.Add(child.Title);
				}
			}
			Logger.Info(string.Format("记录当前已展开的卡片：{0}", string.Join("、", list)), (LogBehavior)0, "E:\\Projects\\PCL\\本体代码\\Plain Craft Launcher 2\\Pages\\PageDownload\\Resource\\MyResourceItem.xaml.vb");
		}
		string text = null;
		ModLoaders val = (ModLoaders)0;
		ResourceTypes val2 = default;
		if (ModMain.FrmMain.PageCurrent.Page == FormMain.PageType.Download)
		{
			switch (ModMain.FrmMain.PageCurrentSub)
			{
			case FormMain.PageSubType.DownloadMod:
				val2 = (ResourceTypes)1;
				text = ModMain.FrmDownloadMod.Content.Loader.Input.GameVersion;
				val = ModMain.FrmDownloadMod.Content.Loader.Input.ModLoaders;
				break;
			case FormMain.PageSubType.DownloadPack:
				val2 = (ResourceTypes)2;
				text = ModMain.FrmDownloadPack.Content.Loader.Input.GameVersion;
				break;
			case FormMain.PageSubType.DownloadDataPack:
				val2 = (ResourceTypes)16;
				text = ModMain.FrmDownloadDataPack.Content.Loader.Input.GameVersion;
				break;
			case FormMain.PageSubType.DownloadResourcePack:
				val2 = (ResourceTypes)4;
				text = ModMain.FrmDownloadResourcePack.Content.Loader.Input.GameVersion;
				break;
			case FormMain.PageSubType.DownloadShader:
				val2 = (ResourceTypes)8;
				text = ModMain.FrmDownloadShader.Content.Loader.Input.GameVersion;
				break;
			}
		}
		else
		{
			val2 = (ResourceTypes)127;
			text = Conversions.ToString(NewLateBinding.LateIndexGet(ModMain.FrmMain.PageCurrent.Additional, new object[1] { 2 }, null));
			val = (ModLoaders)Conversions.ToInteger(NewLateBinding.LateIndexGet(ModMain.FrmMain.PageCurrent.Additional, new object[1] { 3 }, null));
		}
		ModMain.FrmMain.PageChange(new FormMain.PageStackData
		{
			Page = FormMain.PageType.ResourceDetail,
			Additional = new object[5] { sender.Tag, list, text, val, val2 }
		});
	}

	private void Button_MouseDown(object sender, MouseButtonEventArgs e)
	{
		if (IsMouseOver && CanInteraction)
		{
			IsMouseDown = true;
		}
	}

	private void Button_MouseLeave(object sender, object e)
	{
		IsMouseDown = false;
	}

	public void RefreshColor(object sender, EventArgs e)
	{
		if (!CanInteraction)
		{
			return;
		}
		string text;
		int num;
		if (IsMouseOver)
		{
			if (IsMouseDown)
			{
				text = "MouseDown";
				num = 120;
			}
			else
			{
				text = "MouseOver";
				num = 120;
			}
		}
		else
		{
			text = "Idle";
			num = 180;
		}
		if (Operators.CompareString(StateLast, text, TextCompare: false) == 0)
		{
			return;
		}
		StateLast = text;
		checked
		{
			if (IsLoaded && ModAnimation.AniControlEnabled == 0)
			{
				List<ModAnimation.AniData> list = new List<ModAnimation.AniData>();
				if (IsMouseOver)
				{
					list.AddRange(new ModAnimation.AniData[2]
					{
						ModAnimation.AaColor(RectBack, Border.BackgroundProperty, IsMouseDown ? "ColorBrush6" : "ColorBrushBg1", num),
						ModAnimation.AaOpacity(RectBack, 1.0 - RectBack.Opacity, num, 0, new ModAnimation.AniEaseOutFluent())
					});
					if (IsMouseDown)
					{
						list.Add(ModAnimation.AaScaleTransform(RectBack, 0.996 - ((ScaleTransform)RectBack.RenderTransform).ScaleX, (int)Math.Round((double)num * 1.2), 0, new ModAnimation.AniEaseOutFluent()));
					}
					else
					{
						list.Add(ModAnimation.AaScaleTransform(RectBack, 1.0 - ((ScaleTransform)RectBack.RenderTransform).ScaleX, (int)Math.Round((double)num * 1.2), 0, new ModAnimation.AniEaseOutFluent()));
					}
				}
				else
				{
					list.AddRange(new ModAnimation.AniData[4]
					{
						ModAnimation.AaOpacity(RectBack, 0.0 - RectBack.Opacity, num),
						ModAnimation.AaColor(RectBack, Border.BackgroundProperty, IsMouseDown ? "ColorBrush6" : "ColorBrush7", num),
						ModAnimation.AaScaleTransform(RectBack, 0.996 - ((ScaleTransform)RectBack.RenderTransform).ScaleX, num, 0, new ModAnimation.AniEaseOutFluent()),
						ModAnimation.AaScaleTransform(RectBack, -0.196, 1, 0, null, After: true)
					});
				}
				ModAnimation.AniStart(list, "MyResourceItem Color " + Conversions.ToString(Uuid));
			}
			else
			{
				ModAnimation.AniStop("MyResourceItem Color " + Conversions.ToString(Uuid));
				if (_RectBack != null)
				{
					RectBack.Opacity = 0.0;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}
}
