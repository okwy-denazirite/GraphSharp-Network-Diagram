   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      O KWPFExtensions, Version=1.0.3437.34043, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:WPFExtensions.Converters;assembly=WPFExtensionsWPFExtensions.Converters 5      nGclr-namespace:WPFExtensions.ViewModel.Commanding;assembly=WPFExtensions"WPFExtensions.ViewModel.Commanding 5      ` \RibbonControlsLibrary, Version=3.5.31016.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon 5      nGclr-namespace:WPFExtensions.ViewModel.Commanding;assembly=WPFExtensions"WPFExtensions.ViewModel.Commanding 5      L HGraphSharp.Sample, Version=1.0.2.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GraphSharp.Sample.ViewModelGraphSharp.Sample.ViewModel 5      5clr-namespace:GraphSharp.SampleGraphSharp.Sample 5	      N JGraphSharp.Controls, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.ControlsGraphSharp.Controls 5
      K*clr-namespace:GraphSharp.Sample.ConvertersGraphSharp.Sample.Converters 5      V;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensionsWPFExtensions.Controls 5      "   GraphSharp.Sample.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5      Vextconvertes=clr-namespace:WPFExtensions.Converters;assembly=WPFExtensions     5      ^
cmdbindingGclr-namespace:WPFExtensions.ViewModel.Commanding;assembly=WPFExtensions     5      ]rbNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary     5      WextGclr-namespace:WPFExtensions.ViewModel.Commanding;assembly=WPFExtensions     5      ?	ViewModel)clr-namespace:GraphSharp.Sample.ViewModel     5      2Sampleclr-namespace:GraphSharp.Sample     5	      SControls>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.Controls     5
      A
Converters*clr-namespace:GraphSharp.Sample.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^WPFExtensions_Controls;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensions     5      -   5        4  .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$
  root��5       � Title$ Graph layout PoC��5      
������� � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�5      ;  5WPFExtensions.ViewModel.Commanding.CommandSinkBinding   CommandSink 5      ��  � 	Resources 5       �� MergedDictionaries �� Source8  2WPFExtensions.Converters.BoolToVisibilityConverter   visibilityToBoolConverter;  5GraphSharp.Sample.Converters.IntegerToDoubleConverter  doubleIntConverter  algorithmConstraintEnum S� 
MethodName	 S� 
ObjectType   System.Enum
 S� MethodParameters M� TypeName5  /Microsoft.Windows.Controls.Ribbon.RibbonCommand  NewLayoutRCmd   
LabelTitle  Horizon_Image_Add   SmallImageSource   LargeImageSource  ContinueLayoutRCmd  Horizon_Image_Forward  RelayoutRCmd  Horizon_Image_Refresh 	 OpenGraphFileRCmd 
 Horizon_Image_Open  SaveGraphFileRCmd  Horizon_Image_Save  ExitRCmd  Horizon_Image_Delete  GraphItemTemplate �� Path �� Mode �� FallbackValue  	MainColor �� Color  
graphmodel6  0GraphSharp.Sample.ViewModel.GraphLayoutViewModel�� 5   
    5      �� 5      $- 'Resources/LayoutParameterTemplates.xaml?�6%   �� 5      $* $Resources/PocGraphDataTemplates.xaml?�6%   %  &	        &	      &	 &     &	 �     7  7  &	 �     7  7  &	 '    7  7  &		 `    7 
 7 
 &	 �    7  7  &	 �    7  7  &	     &	 �      5"      65     5%      62   S� 5'      $ 	GetValues��5(   %   "	  5)      
 5+      M� 5,      $# Controls:AlgorithmConstraints��6   5.        51      $ New Layout Tab��52      8   8  54        56      $ Continue Layout��57      8   8  59        5;      $ Relayout��5<      8   8  5>        5@      $ Open graphs��5A      8   8  5C        5E      $ Save graphs��5F      8   8  5H        5J      $
 Exit��5K      8   8  5M      �� 5O      .R�5P      �� $��18(�6   $
��Bold"�6&   $��5,5,5,5q�68   ��6I   �� $
 Name�$ OneWay=�$ NoName����5Q      �� 5R      # �  6*   5T      5U      S� 5V      "	  6J   5W       J� CommandBindings 5Z        5[   
   9  3GraphSharp.Sample.ViewModel.LayoutAnalyzerViewModel   RemoveLayoutCommand)	  #System.Windows.Input.CommandBinding 	  Command# Z 6!     5\   
      AddLayoutCommand# Z 6!     5]   
      ContinueLayoutCommand# Z 6!     5^   
      RelayoutCommand# Z 6!     5_   
      OpenGraphsCommand# Z 6!     5`   
      SaveGraphsCommand# Z 6!   	  5b   
   -   5        # [ 5b      5c      =
  7WPFExtensions.ViewModel.Commanding.MapperCommandBinding
  5e   
   # [ 6#    
  MappedToCommand# Z 5f   #   
  5g   
   # [ 6#   # Z 5h   #   
  5i   
   # [ 6#   # Z 5j   #   
  5k   
   # [	 6#   # Z 5l   #   
  5m   
   # [ 6#   # Z 5n   #   .��5q      ]� ��. .+�5t   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  $	��Top=�6      ApplicationMenu 5u      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5v      .@�5w      A  ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem   m� Command# [	 63     5x      # [ 63   7  1Microsoft.Windows.Controls.Ribbon.RibbonSeparator  5y        5z      # [ 63   5{         Tabs. 5~      1  +Microsoft.Windows.Controls.Ribbon.RibbonTab     Label$ General��6       Groups.  5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  !   Command! 5�        5�      $ Project��6+   "   Controls." 5�      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  #��[	 6&     5�      #��[ 6&   5�        5�      ! 5�        5�      $ Layout��6+   #   GroupSizeDefinitions# 5�      K  EMicrosoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionCollection  A  ;Microsoft.Windows.Controls.Ribbon.RibbonGroupSizeDefinition  5�      $   ControlSizeDefinitions.$ 5�   "   C  =Microsoft.Windows.Controls.Ribbon.RibbonControlSizeDefinition  %   	ImageSize$% Large=�6A   &   IsLabelVisible& . 5�   
     5�   "   $% Large=�6A   & . 5�   
   5�        5�      '   IsCollapsed' . 6;   5�      ." 5�        #��[ 6&     5�      #��[ 6&   5�        5�      ! 5�        5�      $
 View��6+   # 5�          5�      .$ 5�   "     $% Small=�6A   & . 5�   
     5�   "   $% Small=�6A   & . 5�   
   5�      5�      ." 5�      3  -Microsoft.Windows.Controls.Ribbon.RibbonLabel  .��5�      �� $
��Auto��6%   ( �� Orientation$( 
Horizontal=�5�      .+�5�      �� $( 
Horizontal=�6)   .+�5�   "   ��   Horizon_Image_Search#���  6(     	IconWidth#���  5�   
   $��Uniform=�5�   
     
IconMargin#���  5�   
   �� 5�   "   $��General zoom��6,   $
��Wrap=�5�   
   $��5,0,5,0q�5�   
   $��Center=�5�   
   $��Center=�5�   
   5�      �� 5�      -   5        ) ��Name$) 
zoomSlider��5�   	   * � Value$* 1Q�5�   %   + � Minimum$
+ 0.25Q�5�   	   , � Maximum$, 2Q�5�   	   $
��Auto��5�   	   $��50��5�   	   5�      5�      5�        5�      ! 5�        5�      $ Tests��6+   ." 5�        ��5�        5�      -   5        $ NotificationTest��5�   /   5�   	   5�        5�      ��5�        5�      -   5        $ CompoundLayoutTest��5�   /   5�   	   5�      5�      5�      5�      ]� 5�   
   .+�5�      �� $��5q�5�      $
��Left=�5�      #���  6   $	��300��6N   $	��150��6]   $	��150��6l   ��5�      �� $ GraphModels�- �� SelectedValue- 5�      �� $ SelectedGraphModel�$ TwoWay=�5�   l   �� 5�      $( 
Horizontal=�6   $��0,5,5,5q�5�      $	��Top=�5�      .+�5�      �� $
��Auto��6   $
��Auto��5�      $��	Vertices:��5�      $
��Wrap=�5�      $��Center=�5�      $��	20,0,10,0q�5�      �� 5�      $
��Auto��6   $
��Auto��5�      $
��Wrap=�5�      $��Center=�5�      $��0,0,20,0q�5�      ��5�      �� $* $SelectedGraphModel.Graph.VertexCount�5�      �� 5�      $
��Auto��6   $
��Auto��5�      $��Edges:��5�      $
��Wrap=�5�      $��Center=�5�      $��0,0,10,0q�5�      �� 5�      $
��Auto��6   $
��Auto��5�      $
��Wrap=�5�      $��Center=�5�      ��5�      �� $( "SelectedGraphModel.Graph.EdgeCount�5�      5�      ]� 5�      . � DataContext. 6   �� $ AnalyzedLayouts�/ � LayoutTransform/ 5�      �� 5�      0 �� CenterX$	0 0.5Q�5�      1 �� CenterY$	1 0.5Q�5      2 �� ScaleX2 5�   %   �� $ Value�3 �� ElementName$3 
zoomSlider��4 �� ScaleY4 5�      �� $ Value�$3 
zoomSlider��5      .+�5     � $	��Top=�6   5 � ColumnDefinitions5 5     �� 5     $��* �6+   �� 5     $��* �6+   .+�5
     �� $��0��6!   .+�5     �  5     6 �� 
TargetType7 �� Property8 �� Value��%�   '��       '�� G     �� 5  "   "6 ��6(   .�5  &   �� 7 � ��$8 3q�6?   5  #   �� 5  "   "6 ��6(   .�5  &   �� 7 � ��$8 3q�6?   5  #   5     9 � RowDefinitions9 5     �� 5  "   �� 5  "   �� 5  "   �� 5  "   �� 5  "   �� 5  "   �� 5  "   �� 5  "   �� 5  "   5 5      �� 5!  "   $
��Auto �63   $	��150��6@   �� 5"  "   $��* �63   .+�5$     �� $��Layout algorithm��6(   �� 5%     $��1��6'   ��5&     �� $+ %LayoutAlgorithmFactory.AlgorithmTypes�$3 graphLayout��- 5'     �� $ LayoutAlgorithmType��� 5(     $��1��6(   $��Overlap Removal��65   �� 5)     $��1��6'   $��1��5*     ��5+     �� : �� Source#: [ - 5,     �� $ OverlapRemovalConstraint�$3 graphLayout���� 5-     $��2��6(   $��Overlap Removal Algorithm��65   �� 5.     $��1��6'   $��2��5/     ��50     �� $3 -OverlapRemovalAlgorithmFactory.AlgorithmTypes�$3 graphLayout��- 51     �� $! OverlapRemovalAlgorithmType�$3 graphLayout���� 52     $��3��6(   $��Edge Routing��65   �� 53     $��1��6'   $��3��54     ��55     �� #: [ - 56     �� $ EdgeRoutingConstraint�$3 graphLayout���� 57     $��4��6(   $��Edge Routing Algorithm��65   �� 58     $��1��6'   $��4��59     ��5:     �� $0 *EdgeRoutingAlgorithmFactory.AlgorithmTypes�$3 graphLayout��- 5;     �� $ EdgeRoutingAlgorithmType�$3 graphLayout���� 5<     $��5��6(   $��0��65   $��State��6E   �� 5=     $��1��6%   $��5��5>     $	��150��5?     $+ 0Q�5@     ; �� TickFrequency$; 1Q�5C     , 5A     �� $ 
StateCount�< �� 	Converter#< [ $3 graphLayout��$ 0��* 5B     �� $ 
StateIndex�#< [ $3 graphLayout��$ 0��5C     �� 5E     $��Computation Time��6(   $��7��5F     $��0��5G     �� 5H     $��7��5I     $��1��5J     ��5H  (   �� $! LayoutState.ComputationTime�$3 graphLayout��5J     �� 5L     $��Show all states��6(   $��8��5M     $��0��5N     �� 5O     $��8��5P     $��1��5Q     = d� 	IsChecked= 5O  '   �� $ ShowAllStates�$3 graphLayout��5Q     5R     5S     �� 5V     $��1��6!   $
��10,0q�5W      5X     ��%Q   '��       �� 5Y     "6 ��6$   .�5Z  "   �� 7 � ��$8 5q�6;   5[     5\     .+�5^     �� $!��Layout algorithm parameters��6#   ��5_     �� $ LayoutParameters�$3 graphLayout���� 5`     $ ��Overlap removal parameters��6#   ��5a     �� $ OverlapRemovalParameters�$3 graphLayout���� 5b     $��Edge routing parameters��6#   ��5c     �� $ EdgeRoutingParameters�$3 graphLayout��5d     5f     (  "WPFExtensions.Controls.ZoomControl  5h     .��5i     0  *GraphSharp.Sample.ViewModel.PocGraphLayout  -   5        >  Name$> graphLayout��5i  /   %  GraphSharp.Sample.LayoutManager?   ManagedLayout? . �  �GraphSharp.Controls.GraphLayout`3[[GraphSharp.Sample.PocVertex, GraphSharp.Sample, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null],[GraphSharp.Sample.PocEdge, GraphSharp.Sample, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null],[GraphSharp.Sample.PocGraph, GraphSharp.Sample, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null]]"@   OverlapRemovalAlgorithmType$	@ FSA��5m     A   HighlightAlgorithmType$A Simple��5n     B   GraphB 5j     �� $ Graph�C   LayoutAlgorithmTypeC 5k     �� $ LayoutAlgorithmType�5n     5o     5p     5q     5r     5s     