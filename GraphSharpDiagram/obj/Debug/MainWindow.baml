   M S B A M L   `   `   `  ����L  HGraphSharpDiagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GraphSharpDiagram.ViewsGraphSharpDiagram.Views  5   	   K*clr-namespace:GraphSharpDiagram.ViewModelsGraphSharpDiagram.ViewModels  5   	   5clr-namespace:GraphSharpDiagramGraphSharpDiagram  5   	   "    GraphSharpDiagram.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;	graphctrl%clr-namespace:GraphSharpDiagram.Views     5   	   9vm*clr-namespace:GraphSharpDiagram.ViewModels     5   	   /srcclr-namespace:GraphSharpDiagram     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ 	#FF3164a5��6    � Offset$ 1Q�6-   � 5      $ 	#FF8AAED4��6   $ 0Q�6-   5       � 	Resources 5      .   (GraphSharpDiagram.ContentToPathConverter   content2PathConverter0   *GraphSharpDiagram.ContentToMarginConverter  content2MarginConverter  BorderBrush �� Color  
HoverBrush  TabControlBackgroundBrush  TabItemPathBrush  TabControlStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType � RowDefinitions K� ZIndex �� CornerRadius �� Orientation K� IsItemsHost  tabPath �Name F�Name �� ElementName �� 	Converter E� IsClosed E� 
StartPoint � LayoutTransform �� ScaleY ��Name ��Name �� Triggers P� 
SourceName P� Property P� Value �� 
TargetName F� 	Direction  F� Opacity! F� ShadowDepth" F� Softness��%j
  &	        &	      &	 &     &	 I     &	 l     &	 m    &	     7  7  7  &	     '�� �    7  7  7  7   7  7  7    5   
   6%     5   
   6'   �� 5   
   $ 	#FFFFFFFF��6.   �� 5   
   $ 	#FFFF4500��6-   �� 5   
   $ 0.5,0&�6@   $ 0.5,1&�6Q   .��5      � $ 	#FFa9cde7��6   $ 0Q�6-   � 5      $ 	#FFe7f4fc��6   $	 0.3Q�6-   � 5      $ 	#FFf2fafd��6   $
 0.85Q�6-   � 5      $ 	#FFe4f6fa��6   $ 1Q�6-   5      �� 5   
   $	 0,0&�67   $	 0,1&�6H   .��5       � $ 	#FF3164a5��6   $ 0Q�6-   � 5!      $ 	#FFe4f6fa��6   $ 1Q�6-   5"      �� 5'   
   " ��6(   .�5(      ��  � ��$	 1q�60   �� 5)       � ��	 5*      �� 5+      "
 ��6&   .R�5,      �  5-      �� 5.   "   $
��Auto �60   �� 5/   "   $��* �60   .+�51      �� $��1��6%   $��2,0,2,2q�62   $ 2��6L   $ 0,0,2,2��6]   8��  8�� ._�54   "   �� $��SelectedContent��63   55      �� 56      $ 
Horizontal=�6)   $��0��6B   $ 1��6O    . 6`   �� 57      $��0��6(   $��2��65   $��Bottom=�6@   8�� 58   $   59      5:      5<      5=      �� 5>   
   " F�6    .�5?      ��  � ��
	 �   �6'   �� 5@       � ��	 5A      B� 5B      $=��7M 0,0 L 0,14 C 0,18 2,20 6,20 L 60,20 C 70,20 80,0 84,0C�6#   5D      5E      �� 5H   
   " ��6)   .�5I      ��  �@J�SnapsToDevicePixels	 . 64   �� 5J       � ��	 5K      �� 5L      "
 ��6&   .R�5M      � $	 grd��6   .+�5N      F� $ TabPath��6#   $��2��64   8��  8�� ��5O      �� $ TabItemContent��8  ��5R   "   B� 5S   &   .��5T   *   E�  .  $	 1,0&�6F   ��5U   1   �� $ TabItemContent��8  5V   +   5W   '    5Y   "   �� 5Z   &   $ -1Q�65   5\      �� 5]      $ TabItemTopBorder��6(   $��2��6B   $y�Visible=�6M   $��Bottom=�5^   $   8�� ��5_   $   �� $ TabItemContent��8  �� 5`      $ TabItemContent��6/   $��Header��6G   $��	10,2,10,2q�5a   +   $��Center=�6>   ���	#FF0000005b   +   5c       5d      P� 5e      $	 grd��6J    �@J�IsMouseOver . . �5f   "   �� 8	  $ TabPath��6_    � ��5g      P� 5h       �@��
IsSelected . . �5i   "   �� $ TabPath��69    � ��	 5j   &   �� 5k   *   $ 	#FFe4f6fa��6:   5m   #   �� 5n   "    �@J�BitmapEffect	 5o   &   F� 5p   *   $	 302Q�6A   $	  0.4Q�6Q   $! 2Q�5q   9   $	" 0.5Q�6I   5s   #   �� 5t   "    �@K�ZIndex$	 2��6A   �� 5u   "   $ TabItemTopBorder��6N    � y�$	 Hidden=�6?   6N   5v      5x      5z      5{      5|      .��5      ]� ��. .+�5�   
   �� # �� TabStripPlacement$	# Top=�5�      $ �� SelectedIndex$ 5�      �� *SelectedIndex+��5�      �� *Items+��5�      �� 5�      .R�5�      �� ��5�      �� *	TabName+5�      % �� ContentTemplate% 5�      �� 5�      .R�5�      �� .��5�      '   !GraphSharpDiagram.Views.GraphView  5�      5�      5�      5�      5�      