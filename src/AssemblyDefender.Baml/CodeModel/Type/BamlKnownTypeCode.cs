using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyDefender.Baml
{
	public enum BamlKnownTypeCode : short
	{
		AccessText = 0x1,
		AdornedElementPlaceholder = 0x2,
		Adorner = 0x3,
		AdornerDecorator = 0x4,
		AdornerLayer = 0x5,
		AffineTransform3D = 0x6,
		AmbientLight = 0x7,
		AnchoredBlock = 0x8,
		Animatable = 0x9,
		AnimationClock = 0xa,
		AnimationTimeline = 0xb,
		Application = 0xc,
		ArcSegment = 0xd,
		ArrayExtension = 0xe,
		AxisAngleRotation3D = 0xf,
		BaseIListConverter = 0x10,
		BeginStoryboard = 0x11,
		BevelBitmapEffect = 0x12,
		BezierSegment = 0x13,
		Binding = 0x14,
		BindingBase = 0x15,
		BindingExpression = 0x16,
		BindingExpressionBase = 0x17,
		BindingListCollectionView = 0x18,
		BitmapDecoder = 0x19,
		BitmapEffect = 0x1a,
		BitmapEffectCollection = 0x1b,
		BitmapEffectGroup = 0x1c,
		BitmapEffectInput = 0x1d,
		BitmapEncoder = 0x1e,
		BitmapFrame = 0x1f,
		BitmapImage = 0x20,
		BitmapMetadata = 0x21,
		BitmapPalette = 0x22,
		BitmapSource = 0x23,
		Block = 0x24,
		BlockUIContainer = 0x25,
		BlurBitmapEffect = 0x26,
		BmpBitmapDecoder = 0x27,
		BmpBitmapEncoder = 0x28,
		Bold = 0x29,
		BoolIListConverter = 0x2a,
		Bool = 0x2b,
		BooleanAnimationBase = 0x2c,
		BooleanAnimationUsingKeyFrames = 0x2d,
		BooleanConverter = 0x2e,
		BooleanKeyFrame = 0x2f,
		BooleanKeyFrameCollection = 0x30,
		BooleanToVisibilityConverter = 0x31,
		Border = 0x32,
		BorderGapMaskConverter = 0x33,
		Brush = 0x34,
		BrushConverter = 0x35,
		BulletDecorator = 0x36,
		Button = 0x37,
		ButtonBase = 0x38,
		Byte = 0x39,
		ByteAnimation = 0x3a,
		ByteAnimationBase = 0x3b,
		ByteAnimationUsingKeyFrames = 0x3c,
		ByteConverter = 0x3d,
		ByteKeyFrame = 0x3e,
		ByteKeyFrameCollection = 0x3f,
		CachedBitmap = 0x40,
		Camera = 0x41,
		Canvas = 0x42,
		Char = 0x43,
		CharAnimationBase = 0x44,
		CharAnimationUsingKeyFrames = 0x45,
		CharConverter = 0x46,
		CharIListConverter = 0x47,
		CharKeyFrame = 0x48,
		CharKeyFrameCollection = 0x49,
		CheckBox = 0x4a,
		Clock = 0x4b,
		ClockController = 0x4c,
		ClockGroup = 0x4d,
		CollectionContainer = 0x4e,
		CollectionView = 0x4f,
		CollectionViewSource = 0x50,
		Color = 0x51,
		ColorAnimation = 0x52,
		ColorAnimationBase = 0x53,
		ColorAnimationUsingKeyFrames = 0x54,
		ColorConvertedBitmap = 0x55,
		ColorConvertedBitmapExtension = 0x56,
		ColorConverter = 0x57,
		ColorKeyFrame = 0x58,
		ColorKeyFrameCollection = 0x59,
		ColumnDefinition = 0x5a,
		CombinedGeometry = 0x5b,
		ComboBox = 0x5c,
		ComboBoxItem = 0x5d,
		CommandConverter = 0x5e,
		ComponentResourceKey = 0x5f,
		ComponentResourceKeyConverter = 0x60,
		CompositionTarget = 0x61,
		Condition = 0x62,
		ContainerVisual = 0x63,
		ContentControl = 0x64,
		ContentElement = 0x65,
		ContentPresenter = 0x66,
		ContentPropertyAttribute = 0x67,
		ContentWrapperAttribute = 0x68,
		ContextMenu = 0x69,
		ContextMenuService = 0x6a,
		Control = 0x6b,
		ControlTemplate = 0x6c,
		ControllableStoryboardAction = 0x6d,
		CornerRadius = 0x6e,
		CornerRadiusConverter = 0x6f,
		CroppedBitmap = 0x70,
		CultureInfo = 0x71,
		CultureInfoConverter = 0x72,
		CultureInfoIetfLanguageTagConverter = 0x73,
		Cursor = 0x74,
		CursorConverter = 0x75,
		DashStyle = 0x76,
		DataChangedEventManager = 0x77,
		DataTemplate = 0x78,
		DataTemplateKey = 0x79,
		DataTrigger = 0x7a,
		DateTime = 0x7b,
		DateTimeConverter = 0x7c,
		DateTimeConverter2 = 0x7d,
		Decimal = 0x7e,
		DecimalAnimation = 0x7f,
		DecimalAnimationBase = 0x80,
		DecimalAnimationUsingKeyFrames = 0x81,
		DecimalConverter = 0x82,
		DecimalKeyFrame = 0x83,
		DecimalKeyFrameCollection = 0x84,
		Decorator = 0x85,
		DefinitionBase = 0x86,
		DependencyObject = 0x87,
		DependencyProperty = 0x88,
		DependencyPropertyConverter = 0x89,
		DialogResultConverter = 0x8a,
		DiffuseMaterial = 0x8b,
		DirectionalLight = 0x8c,
		DiscreteBooleanKeyFrame = 0x8d,
		DiscreteByteKeyFrame = 0x8e,
		DiscreteCharKeyFrame = 0x8f,
		DiscreteColorKeyFrame = 0x90,
		DiscreteDecimalKeyFrame = 0x91,
		DiscreteDoubleKeyFrame = 0x92,
		DiscreteInt16KeyFrame = 0x93,
		DiscreteInt32KeyFrame = 0x94,
		DiscreteInt64KeyFrame = 0x95,
		DiscreteMatrixKeyFrame = 0x96,
		DiscreteObjectKeyFrame = 0x97,
		DiscretePoint3DKeyFrame = 0x98,
		DiscretePointKeyFrame = 0x99,
		DiscreteQuaternionKeyFrame = 0x9a,
		DiscreteRectKeyFrame = 0x9b,
		DiscreteRotation3DKeyFrame = 0x9c,
		DiscreteSingleKeyFrame = 0x9d,
		DiscreteSizeKeyFrame = 0x9e,
		DiscreteStringKeyFrame = 0x9f,
		DiscreteThicknessKeyFrame = 0xa0,
		DiscreteVector3DKeyFrame = 0xa1,
		DiscreteVectorKeyFrame = 0xa2,
		DockPanel = 0xa3,
		DocumentPageView = 0xa4,
		DocumentReference = 0xa5,
		DocumentViewer = 0xa6,
		DocumentViewerBase = 0xa7,
		Double = 0xa8,
		DoubleAnimation = 0xa9,
		DoubleAnimationBase = 0xaa,
		DoubleAnimationUsingKeyFrames = 0xab,
		DoubleAnimationUsingPath = 0xac,
		DoubleCollection = 0xad,
		DoubleCollectionConverter = 0xae,
		DoubleConverter = 0xaf,
		DoubleIListConverter = 0xb0,
		DoubleKeyFrame = 0xb1,
		DoubleKeyFrameCollection = 0xb2,
		Drawing = 0xb3,
		DrawingBrush = 0xb4,
		DrawingCollection = 0xb5,
		DrawingContext = 0xb6,
		DrawingGroup = 0xb7,
		DrawingImage = 0xb8,
		DrawingVisual = 0xb9,
		DropShadowBitmapEffect = 0xba,
		Duration = 0xbb,
		DurationConverter = 0xbc,
		DynamicResourceExtension = 0xbd,
		DynamicResourceExtensionConverter = 0xbe,
		Ellipse = 0xbf,
		EllipseGeometry = 0xc0,
		EmbossBitmapEffect = 0xc1,
		EmissiveMaterial = 0xc2,
		EnumConverter = 0xc3,
		EventManager = 0xc4,
		EventSetter = 0xc5,
		EventTrigger = 0xc6,
		Expander = 0xc7,
		Expression = 0xc8,
		ExpressionConverter = 0xc9,
		Figure = 0xca,
		FigureLength = 0xcb,
		FigureLengthConverter = 0xcc,
		FixedDocument = 0xcd,
		FixedDocumentSequence = 0xce,
		FixedPage = 0xcf,
		Floater = 0xd0,
		FlowDocument = 0xd1,
		FlowDocumentPageViewer = 0xd2,
		FlowDocumentReader = 0xd3,
		FlowDocumentScrollViewer = 0xd4,
		FocusManager = 0xd5,
		FontFamily = 0xd6,
		FontFamilyConverter = 0xd7,
		FontSizeConverter = 0xd8,
		FontStretch = 0xd9,
		FontStretchConverter = 0xda,
		FontStyle = 0xdb,
		FontStyleConverter = 0xdc,
		FontWeight = 0xdd,
		FontWeightConverter = 0xde,
		FormatConvertedBitmap = 0xdf,
		Frame = 0xe0,
		FrameworkContentElement = 0xe1,
		FrameworkElement = 0xe2,
		FrameworkElementFactory = 0xe3,
		FrameworkPropertyMetadata = 0xe4,
		FrameworkPropertyMetadataOptions = 0xe5,
		FrameworkRichTextComposition = 0xe6,
		FrameworkTemplate = 0xe7,
		FrameworkTextComposition = 0xe8,
		Freezable = 0xe9,
		GeneralTransform = 0xea,
		GeneralTransformCollection = 0xeb,
		GeneralTransformGroup = 0xec,
		Geometry = 0xed,
		Geometry3D = 0xee,
		GeometryCollection = 0xef,
		GeometryConverter = 0xf0,
		GeometryDrawing = 0xf1,
		GeometryGroup = 0xf2,
		GeometryModel3D = 0xf3,
		GestureRecognizer = 0xf4,
		GifBitmapDecoder = 0xf5,
		GifBitmapEncoder = 0xf6,
		GlyphRun = 0xf7,
		GlyphRunDrawing = 0xf8,
		GlyphTypeface = 0xf9,
		Glyphs = 0xfa,
		GradientBrush = 0xfb,
		GradientStop = 0xfc,
		GradientStopCollection = 0xfd,
		Grid = 0xfe,
		GridLength = 0xff,
		GridLengthConverter = 0x100,
		GridSplitter = 0x101,
		GridView = 0x102,
		GridViewColumn = 0x103,
		GridViewColumnHeader = 0x104,
		GridViewHeaderRowPresenter = 0x105,
		GridViewRowPresenter = 0x106,
		GridViewRowPresenterBase = 0x107,
		GroupBox = 0x108,
		GroupItem = 0x109,
		Guid = 0x10a,
		GuidConverter = 0x10b,
		GuidelineSet = 0x10c,
		HeaderedContentControl = 0x10d,
		HeaderedItemsControl = 0x10e,
		HierarchicalDataTemplate = 0x10f,
		HostVisual = 0x110,
		Hyperlink = 0x111,
		IAddChild = 0x112,
		IAddChildInternal = 0x113,
		ICommand = 0x114,
		IComponentConnector = 0x115,
		INameScope = 0x116,
		IStyleConnector = 0x117,
		IconBitmapDecoder = 0x118,
		Image = 0x119,
		ImageBrush = 0x11a,
		ImageDrawing = 0x11b,
		ImageMetadata = 0x11c,
		ImageSource = 0x11d,
		ImageSourceConverter = 0x11e,
		InPlaceBitmapMetadataWriter = 0x11f,
		InkCanvas = 0x120,
		InkPresenter = 0x121,
		Inline = 0x122,
		InlineCollection = 0x123,
		InlineUIContainer = 0x124,
		InputBinding = 0x125,
		InputDevice = 0x126,
		InputLanguageManager = 0x127,
		InputManager = 0x128,
		InputMethod = 0x129,
		InputScope = 0x12a,
		InputScopeConverter = 0x12b,
		InputScopeName = 0x12c,
		InputScopeNameConverter = 0x12d,
		Short = 0x12e,
		Int16Animation = 0x12f,
		Int16AnimationBase = 0x130,
		Int16AnimationUsingKeyFrames = 0x131,
		Int16Converter = 0x132,
		Int16KeyFrame = 0x133,
		Int16KeyFrameCollection = 0x134,
		Int = 0x135,
		Int32Animation = 0x136,
		Int32AnimationBase = 0x137,
		Int32AnimationUsingKeyFrames = 0x138,
		Int32Collection = 0x139,
		Int32CollectionConverter = 0x13a,
		Int32Converter = 0x13b,
		Int32KeyFrame = 0x13c,
		Int32KeyFrameCollection = 0x13d,
		Int32Rect = 0x13e,
		Int32RectConverter = 0x13f,
		Long = 0x140,
		Int64Animation = 0x141,
		Int64AnimationBase = 0x142,
		Int64AnimationUsingKeyFrames = 0x143,
		Int64Converter = 0x144,
		Int64KeyFrame = 0x145,
		Int64KeyFrameCollection = 0x146,
		Italic = 0x147,
		ItemCollection = 0x148,
		ItemsControl = 0x149,
		ItemsPanelTemplate = 0x14a,
		ItemsPresenter = 0x14b,
		JournalEntry = 0x14c,
		JournalEntryListConverter = 0x14d,
		JournalEntryUnifiedViewConverter = 0x14e,
		JpegBitmapDecoder = 0x14f,
		JpegBitmapEncoder = 0x150,
		KeyBinding = 0x151,
		KeyConverter = 0x152,
		KeyGesture = 0x153,
		KeyGestureConverter = 0x154,
		KeySpline = 0x155,
		KeySplineConverter = 0x156,
		KeyTime = 0x157,
		KeyTimeConverter = 0x158,
		KeyboardDevice = 0x159,
		Label = 0x15a,
		LateBoundBitmapDecoder = 0x15b,
		LengthConverter = 0x15c,
		Light = 0x15d,
		Line = 0x15e,
		LineBreak = 0x15f,
		LineGeometry = 0x160,
		LineSegment = 0x161,
		LinearByteKeyFrame = 0x162,
		LinearColorKeyFrame = 0x163,
		LinearDecimalKeyFrame = 0x164,
		LinearDoubleKeyFrame = 0x165,
		LinearGradientBrush = 0x166,
		LinearInt16KeyFrame = 0x167,
		LinearInt32KeyFrame = 0x168,
		LinearInt64KeyFrame = 0x169,
		LinearPoint3DKeyFrame = 0x16a,
		LinearPointKeyFrame = 0x16b,
		LinearQuaternionKeyFrame = 0x16c,
		LinearRectKeyFrame = 0x16d,
		LinearRotation3DKeyFrame = 0x16e,
		LinearSingleKeyFrame = 0x16f,
		LinearSizeKeyFrame = 0x170,
		LinearThicknessKeyFrame = 0x171,
		LinearVector3DKeyFrame = 0x172,
		LinearVectorKeyFrame = 0x173,
		List = 0x174,
		ListBox = 0x175,
		ListBoxItem = 0x176,
		ListCollectionView = 0x177,
		ListItem = 0x178,
		ListView = 0x179,
		ListViewItem = 0x17a,
		Localization = 0x17b,
		LostFocusEventManager = 0x17c,
		MarkupExtension = 0x17d,
		Material = 0x17e,
		MaterialCollection = 0x17f,
		MaterialGroup = 0x180,
		Matrix = 0x181,
		Matrix3D = 0x182,
		Matrix3DConverter = 0x183,
		MatrixAnimationBase = 0x184,
		MatrixAnimationUsingKeyFrames = 0x185,
		MatrixAnimationUsingPath = 0x186,
		MatrixCamera = 0x187,
		MatrixConverter = 0x188,
		MatrixKeyFrame = 0x189,
		MatrixKeyFrameCollection = 0x18a,
		MatrixTransform = 0x18b,
		MatrixTransform3D = 0x18c,
		MediaClock = 0x18d,
		MediaElement = 0x18e,
		MediaPlayer = 0x18f,
		MediaTimeline = 0x190,
		Menu = 0x191,
		MenuBase = 0x192,
		MenuItem = 0x193,
		MenuScrollingVisibilityConverter = 0x194,
		MeshGeometry3D = 0x195,
		Model3D = 0x196,
		Model3DCollection = 0x197,
		Model3DGroup = 0x198,
		ModelVisual3D = 0x199,
		ModifierKeysConverter = 0x19a,
		MouseActionConverter = 0x19b,
		MouseBinding = 0x19c,
		MouseDevice = 0x19d,
		MouseGesture = 0x19e,
		MouseGestureConverter = 0x19f,
		MultiBinding = 0x1a0,
		MultiBindingExpression = 0x1a1,
		MultiDataTrigger = 0x1a2,
		MultiTrigger = 0x1a3,
		NameScope = 0x1a4,
		NavigationWindow = 0x1a5,
		NullExtension = 0x1a6,
		NullableBoolConverter = 0x1a7,
		NullableConverter = 0x1a8,
		NumberSubstitution = 0x1a9,
		Object = 0x1aa,
		ObjectAnimationBase = 0x1ab,
		ObjectAnimationUsingKeyFrames = 0x1ac,
		ObjectDataProvider = 0x1ad,
		ObjectKeyFrame = 0x1ae,
		ObjectKeyFrameCollection = 0x1af,
		OrthographicCamera = 0x1b0,
		OuterGlowBitmapEffect = 0x1b1,
		Page = 0x1b2,
		PageContent = 0x1b3,
		PageFunctionBase = 0x1b4,
		Panel = 0x1b5,
		Paragraph = 0x1b6,
		ParallelTimeline = 0x1b7,
		ParserContext = 0x1b8,
		PasswordBox = 0x1b9,
		Path = 0x1ba,
		PathFigure = 0x1bb,
		PathFigureCollection = 0x1bc,
		PathFigureCollectionConverter = 0x1bd,
		PathGeometry = 0x1be,
		PathSegment = 0x1bf,
		PathSegmentCollection = 0x1c0,
		PauseStoryboard = 0x1c1,
		Pen = 0x1c2,
		PerspectiveCamera = 0x1c3,
		PixelFormat = 0x1c4,
		PixelFormatConverter = 0x1c5,
		PngBitmapDecoder = 0x1c6,
		PngBitmapEncoder = 0x1c7,
		Point = 0x1c8,
		Point3D = 0x1c9,
		Point3DAnimation = 0x1ca,
		Point3DAnimationBase = 0x1cb,
		Point3DAnimationUsingKeyFrames = 0x1cc,
		Point3DCollection = 0x1cd,
		Point3DCollectionConverter = 0x1ce,
		Point3DConverter = 0x1cf,
		Point3DKeyFrame = 0x1d0,
		Point3DKeyFrameCollection = 0x1d1,
		Point4D = 0x1d2,
		Point4DConverter = 0x1d3,
		PointAnimation = 0x1d4,
		PointAnimationBase = 0x1d5,
		PointAnimationUsingKeyFrames = 0x1d6,
		PointAnimationUsingPath = 0x1d7,
		PointCollection = 0x1d8,
		PointCollectionConverter = 0x1d9,
		PointConverter = 0x1da,
		PointIListConverter = 0x1db,
		PointKeyFrame = 0x1dc,
		PointKeyFrameCollection = 0x1dd,
		PointLight = 0x1de,
		PointLightBase = 0x1df,
		PolyBezierSegment = 0x1e0,
		PolyLineSegment = 0x1e1,
		PolyQuadraticBezierSegment = 0x1e2,
		Polygon = 0x1e3,
		Polyline = 0x1e4,
		Popup = 0x1e5,
		PresentationSource = 0x1e6,
		PriorityBinding = 0x1e7,
		PriorityBindingExpression = 0x1e8,
		ProgressBar = 0x1e9,
		ProjectionCamera = 0x1ea,
		PropertyPath = 0x1eb,
		PropertyPathConverter = 0x1ec,
		QuadraticBezierSegment = 0x1ed,
		Quaternion = 0x1ee,
		QuaternionAnimation = 0x1ef,
		QuaternionAnimationBase = 0x1f0,
		QuaternionAnimationUsingKeyFrames = 0x1f1,
		QuaternionConverter = 0x1f2,
		QuaternionKeyFrame = 0x1f3,
		QuaternionKeyFrameCollection = 0x1f4,
		QuaternionRotation3D = 0x1f5,
		RadialGradientBrush = 0x1f6,
		RadioButton = 0x1f7,
		RangeBase = 0x1f8,
		Rect = 0x1f9,
		Rect3D = 0x1fa,
		Rect3DConverter = 0x1fb,
		RectAnimation = 0x1fc,
		RectAnimationBase = 0x1fd,
		RectAnimationUsingKeyFrames = 0x1fe,
		RectConverter = 0x1ff,
		RectKeyFrame = 0x200,
		RectKeyFrameCollection = 0x201,
		Rectangle = 0x202,
		RectangleGeometry = 0x203,
		RelativeSource = 0x204,
		RemoveStoryboard = 0x205,
		RenderOptions = 0x206,
		RenderTargetBitmap = 0x207,
		RepeatBehavior = 0x208,
		RepeatBehaviorConverter = 0x209,
		RepeatButton = 0x20a,
		ResizeGrip = 0x20b,
		ResourceDictionary = 0x20c,
		ResourceKey = 0x20d,
		ResumeStoryboard = 0x20e,
		RichTextBox = 0x20f,
		RotateTransform = 0x210,
		RotateTransform3D = 0x211,
		Rotation3D = 0x212,
		Rotation3DAnimation = 0x213,
		Rotation3DAnimationBase = 0x214,
		Rotation3DAnimationUsingKeyFrames = 0x215,
		Rotation3DKeyFrame = 0x216,
		Rotation3DKeyFrameCollection = 0x217,
		RoutedCommand = 0x218,
		RoutedEvent = 0x219,
		RoutedEventConverter = 0x21a,
		RoutedUICommand = 0x21b,
		RoutingStrategy = 0x21c,
		RowDefinition = 0x21d,
		Run = 0x21e,
		RuntimeNamePropertyAttribute = 0x21f,
		Sbyte = 0x220,
		SByteConverter = 0x221,
		ScaleTransform = 0x222,
		ScaleTransform3D = 0x223,
		ScrollBar = 0x224,
		ScrollContentPresenter = 0x225,
		ScrollViewer = 0x226,
		Section = 0x227,
		SeekStoryboard = 0x228,
		Selector = 0x229,
		Separator = 0x22a,
		SetStoryboardSpeedRatio = 0x22b,
		Setter = 0x22c,
		SetterBase = 0x22d,
		Shape = 0x22e,
		Float = 0x22f,
		SingleAnimation = 0x230,
		SingleAnimationBase = 0x231,
		SingleAnimationUsingKeyFrames = 0x232,
		SingleConverter = 0x233,
		SingleKeyFrame = 0x234,
		SingleKeyFrameCollection = 0x235,
		Size = 0x236,
		Size3D = 0x237,
		Size3DConverter = 0x238,
		SizeAnimation = 0x239,
		SizeAnimationBase = 0x23a,
		SizeAnimationUsingKeyFrames = 0x23b,
		SizeConverter = 0x23c,
		SizeKeyFrame = 0x23d,
		SizeKeyFrameCollection = 0x23e,
		SkewTransform = 0x23f,
		SkipStoryboardToFill = 0x240,
		Slider = 0x241,
		SolidColorBrush = 0x242,
		SoundPlayerAction = 0x243,
		Span = 0x244,
		SpecularMaterial = 0x245,
		SpellCheck = 0x246,
		SplineByteKeyFrame = 0x247,
		SplineColorKeyFrame = 0x248,
		SplineDecimalKeyFrame = 0x249,
		SplineDoubleKeyFrame = 0x24a,
		SplineInt16KeyFrame = 0x24b,
		SplineInt32KeyFrame = 0x24c,
		SplineInt64KeyFrame = 0x24d,
		SplinePoint3DKeyFrame = 0x24e,
		SplinePointKeyFrame = 0x24f,
		SplineQuaternionKeyFrame = 0x250,
		SplineRectKeyFrame = 0x251,
		SplineRotation3DKeyFrame = 0x252,
		SplineSingleKeyFrame = 0x253,
		SplineSizeKeyFrame = 0x254,
		SplineThicknessKeyFrame = 0x255,
		SplineVector3DKeyFrame = 0x256,
		SplineVectorKeyFrame = 0x257,
		SpotLight = 0x258,
		StackPanel = 0x259,
		StaticExtension = 0x25a,
		StaticResourceExtension = 0x25b,
		StatusBar = 0x25c,
		StatusBarItem = 0x25d,
		StickyNoteControl = 0x25e,
		StopStoryboard = 0x25f,
		Storyboard = 0x260,
		StreamGeometry = 0x261,
		StreamGeometryContext = 0x262,
		StreamResourceInfo = 0x263,
		String = 0x264,
		StringAnimationBase = 0x265,
		StringAnimationUsingKeyFrames = 0x266,
		StringConverter = 0x267,
		StringKeyFrame = 0x268,
		StringKeyFrameCollection = 0x269,
		StrokeCollection = 0x26a,
		StrokeCollectionConverter = 0x26b,
		Style = 0x26c,
		Stylus = 0x26d,
		StylusDevice = 0x26e,
		TabControl = 0x26f,
		TabItem = 0x270,
		TabPanel = 0x271,
		Table = 0x272,
		TableCell = 0x273,
		TableColumn = 0x274,
		TableRow = 0x275,
		TableRowGroup = 0x276,
		TabletDevice = 0x277,
		TemplateBindingExpression = 0x278,
		TemplateBindingExpressionConverter = 0x279,
		TemplateBindingExtension = 0x27a,
		TemplateBindingExtensionConverter = 0x27b,
		TemplateKey = 0x27c,
		TemplateKeyConverter = 0x27d,
		TextBlock = 0x27e,
		TextBox = 0x27f,
		TextBoxBase = 0x280,
		TextComposition = 0x281,
		TextCompositionManager = 0x282,
		TextDecoration = 0x283,
		TextDecorationCollection = 0x284,
		TextDecorationCollectionConverter = 0x285,
		TextEffect = 0x286,
		TextEffectCollection = 0x287,
		TextElement = 0x288,
		TextSearch = 0x289,
		ThemeDictionaryExtension = 0x28a,
		Thickness = 0x28b,
		ThicknessAnimation = 0x28c,
		ThicknessAnimationBase = 0x28d,
		ThicknessAnimationUsingKeyFrames = 0x28e,
		ThicknessConverter = 0x28f,
		ThicknessKeyFrame = 0x290,
		ThicknessKeyFrameCollection = 0x291,
		Thumb = 0x292,
		TickBar = 0x293,
		TiffBitmapDecoder = 0x294,
		TiffBitmapEncoder = 0x295,
		TileBrush = 0x296,
		TimeSpan = 0x297,
		TimeSpanConverter = 0x298,
		Timeline = 0x299,
		TimelineCollection = 0x29a,
		TimelineGroup = 0x29b,
		ToggleButton = 0x29c,
		ToolBar = 0x29d,
		ToolBarOverflowPanel = 0x29e,
		ToolBarPanel = 0x29f,
		ToolBarTray = 0x2a0,
		ToolTip = 0x2a1,
		ToolTipService = 0x2a2,
		Track = 0x2a3,
		Transform = 0x2a4,
		Transform3D = 0x2a5,
		Transform3DCollection = 0x2a6,
		Transform3DGroup = 0x2a7,
		TransformCollection = 0x2a8,
		TransformConverter = 0x2a9,
		TransformGroup = 0x2aa,
		TransformedBitmap = 0x2ab,
		TranslateTransform = 0x2ac,
		TranslateTransform3D = 0x2ad,
		TreeView = 0x2ae,
		TreeViewItem = 0x2af,
		Trigger = 0x2b0,
		TriggerAction = 0x2b1,
		TriggerBase = 0x2b2,
		TypeExtension = 0x2b3,
		TypeTypeConverter = 0x2b4,
		Typography = 0x2b5,
		UIElement = 0x2b6,
		Ushort = 0x2b7,
		UInt16Converter = 0x2b8,
		Uint = 0x2b9,
		UInt32Converter = 0x2ba,
		Ulong = 0x2bb,
		UInt64Converter = 0x2bc,
		UShortIListConverter = 0x2bd,
		Underline = 0x2be,
		UniformGrid = 0x2bf,
		Uri = 0x2c0,
		UriTypeConverter = 0x2c1,
		UserControl = 0x2c2,
		Validation = 0x2c3,
		Vector = 0x2c4,
		Vector3D = 0x2c5,
		Vector3DAnimation = 0x2c6,
		Vector3DAnimationBase = 0x2c7,
		Vector3DAnimationUsingKeyFrames = 0x2c8,
		Vector3DCollection = 0x2c9,
		Vector3DCollectionConverter = 0x2ca,
		Vector3DConverter = 0x2cb,
		Vector3DKeyFrame = 0x2cc,
		Vector3DKeyFrameCollection = 0x2cd,
		VectorAnimation = 0x2ce,
		VectorAnimationBase = 0x2cf,
		VectorAnimationUsingKeyFrames = 0x2d0,
		VectorCollection = 0x2d1,
		VectorCollectionConverter = 0x2d2,
		VectorConverter = 0x2d3,
		VectorKeyFrame = 0x2d4,
		VectorKeyFrameCollection = 0x2d5,
		VideoDrawing = 0x2d6,
		ViewBase = 0x2d7,
		Viewbox = 0x2d8,
		Viewport3D = 0x2d9,
		Viewport3DVisual = 0x2da,
		VirtualizingPanel = 0x2db,
		VirtualizingStackPanel = 0x2dc,
		Visual = 0x2dd,
		Visual3D = 0x2de,
		VisualBrush = 0x2df,
		VisualTarget = 0x2e0,
		WeakEventManager = 0x2e1,
		WhitespaceSignificantCollectionAttribute = 0x2e2,
		Window = 0x2e3,
		WmpBitmapDecoder = 0x2e4,
		WmpBitmapEncoder = 0x2e5,
		WrapPanel = 0x2e6,
		WriteableBitmap = 0x2e7,
		XamlBrushSerializer = 0x2e8,
		XamlInt32CollectionSerializer = 0x2e9,
		XamlPathDataSerializer = 0x2ea,
		XamlPoint3DCollectionSerializer = 0x2eb,
		XamlPointCollectionSerializer = 0x2ec,
		XamlReader = 0x2ed,
		XamlStyleSerializer = 0x2ee,
		XamlTemplateSerializer = 0x2ef,
		XamlVector3DCollectionSerializer = 0x2f0,
		XamlWriter = 0x2f1,
		XmlDataProvider = 0x2f2,
		XmlLangPropertyAttribute = 0x2f3,
		XmlLanguage = 0x2f4,
		XmlLanguageConverter = 0x2f5,
		XmlNamespaceMapping = 0x2f6,
		ZoomPercentageConverter = 0x2f7,
	}
}
