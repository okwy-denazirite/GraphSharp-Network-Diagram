   M S B A M L   `   `   `  ����L  HGraphSharpDiagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GraphSharpDiagramGraphSharpDiagram  5      N JGraphSharp.Controls, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.ControlsGraphSharp.Controls 5      O KWPFExtensions, Version=1.0.3437.34043, Culture=neutral, PublicKeyToken=nullV;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensionsWPFExtensions.Controls 5	      '    !GraphSharpDiagram.Views.GraphView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GraphSharpDiagram     5      U
graphsharp>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.Controls     5      Lzoom;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensions     5	        � 	Resources  5         demoTemplate �� DataType!   GraphSharpDiagram.PocVertex �� Orientation ��Name �� Path �� Mode �� Triggers �� Value �� Binding	 �� 
TargetName
 �� Property �� Value'  !GraphSharp.Controls.VertexControl �� 
TargetType �� 
TargetType �� CornerRadius �� Padding   Vertex J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   Color   Opacity   	Direction%  GraphSharp.Controls.EdgeControl �� 	Resources  Key  ToolTipContent��%r  &	        '  �    7   '  J    7  �� 5   
   "  6,   .R�5      �� $ 
Horizontal=�6   $��5q�62   .+�5      �� $	 img��6   $��/Images/pentagon.png��6%   $��20��6C   $��20��6N   �� 5      
���������6   �� $ ID�$ OneWay=�y�6U   �� $ Visibl�$ OneWay=�5      5       5      �� 5!      $ 1��6;    6   �� *
Facility+.a�5"      �� $		 img��6   
 � ��$ /Images/triangle.png��5#      5$      �� 5%      $ 2��6;    6   �� *
Facility+.a�5&      �� $		 img��6   
 � ��$ /Images/rhombus.png��5'      5(      �� 5)      $ 3��6;    6   �� *
Facility+.a�5*      �� $		 img��6   
 � ��$ /Images/circle.png��5+      5,      �� 5-      $ 4��6;    6   �� *
Facility+.a�5.      �� $		 img��6   
 � ��$ /Images/star.png��5/      50      �� 51      $ 5��6;    6   �� *
Facility+.a�52      �� $		 img��6   
 � ��$ /Images/square.png��53      54      56      �� 5:   
   "  6   .�5;      �� 
 � �� 5<      �� 5=      "  6&   .R�5>      �� 
�������
���   �$��2q�5@      $ 10,10,10,10��5A      # z��5B      ._�5C      �� #��z 6/   8��  5D       5F        5G   "   $ 2Q�63   $ 	LightGray��6B   $	 0.3Q�5H      $	 315Q�6+   5J      5K      5M      5P      �� 5_   
   "  6    5`      ��_� 5a      ToolTipContent .��5b      �� .+�5c      �� $
��Bold"�6$   $��Edge.ID��66   �� 5d      ��6$   �� *ID+5e      5f      5g      .�5h      �� 
 �@�ToolTip8   6(   5i      5l      .��5o      (  "WPFExtensions.Controls.ZoomControl  $��1��6      Zoom$	 0.2Q�6&      ZoomBoxOpacity$	 0.5Q�5p   	   #��� ��6   .��5q   
   &    GraphSharpDiagram.PocGraphLayout  -   5          Name$ graphLayout��5q      $��10q�64   �  �GraphSharp.Controls.GraphLayout`3[[GraphSharpDiagram.PocVertex, GraphSharpDiagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[GraphSharpDiagram.PocEdge, GraphSharpDiagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[GraphSharpDiagram.PocGraph, GraphSharpDiagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]"   OverlapRemovalAlgorithmType$	 FSA��5t   	      HighlightAlgorithmType$ Simple��5u   	      Graph 5r   	   �� $ Graph�   LayoutAlgorithmType 5s   	   �� $ LayoutAlgorithmType�$ OneWay=�5u   	   5w      5x      