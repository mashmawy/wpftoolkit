   M S B A M L   `   `   `  ���� l  hXceed.Wpf.Toolkit.LiveExplorer, Version=3.4.6747.17709, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem H    BXceed.Wpf.Toolkit.LiveExplorer.Samples.Button.Views.IconButtonView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  0sys&clr-namespace:System;assembly=mscorlib  -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  
IconButton��   Description J� $��14(�$��Segoe)�.*���The IconButton control is a Button that contains an icon and some data. The Foreground, Background and BorderBrush can be easily modified with properties while the Icon location is customizable. � 	Resources G  AXceed.Wpf.Toolkit.Core.Converters.SolidColorBrushToColorConverter #  SolidColorBrushToColorConverter 
 Image1 
 Image2  ButtonLocationEnumData S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        &	      &	 ?     &	 t       �� $#��../Resources/PencilTool16.png��$��20��$��5q��� $��../Resources/Default.jpg��$��25��$��5q�S� $ 	GetValues��"   M� $ xctk:Location��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��Features��$��0��$��5q�.��� $��5q� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $	��100 ��� $
��Auto ��� $	��100 �.+��� $��Icon:��$��Center=��� $��1��$��5q�$��Center=�	 �� SelectedValuePath$		 Tag��
 �� SelectedValue
 �� *Icon+ �� ElementName$ _iconButton��.@��� $
��None��
 � Tag Z� �� $��Image 1��# [ �� $��Image 2��# [ �� $��1��$��Icon Location: ��$��Center=��� $��1��$��1��$��5q�$��Center=�����  �� Source# [  �� SelectedItem �� *IconLocation+$ _iconButton���� $��MouseOver Foreground:��$��2��$��Center=�$��10,0,0,0q�#  Xceed.Wpf.Toolkit.ColorPicker  $��3��$��5q�   SelectedColor �� *MouseOverForeground+$ _iconButton�� �� 	Converter# [  �� $��MousePressed Foreground:��$��1��$��2��$��Center=�$��10,0,0,0q�  $��1��$��3��$��5q� �� *MousePressedForeground+$ _iconButton��# [  �� $��MouseOver Background:��$��2��$��2��$��Center=�$��10,0,0,0q�  $��2��$��3��$��5q� �� *MouseOverBackground+$ _iconButton��# [  �� $��MousePressed Background:��$��3��$��2��$��Center=�$��10,0,0,0q�  $��3��$��3��$��5q� �� *MousePressedBackground+$ _iconButton��# [  �� $��MouseOver BorderBrush:��$��4��$��2��$��Center=�$��10,0,0,0q�  $��4��$��3��$��5q� �� *MouseOverBorderBrush+$ _iconButton��# [  �� $��MousePressed BorderBrush:��$��5��$��2��$��Center=�$��10,0,0,0q�  $��5��$��3��$��5q� �� *MousePressedBorderBrush+$ _iconButton��# [  �� $��1��$��10q�.+��� $��Usage:�� 
 Header#��[ "  Xceed.Wpf.Toolkit.IconButton  -     Name$ _iconButton��$
��Test��   Icon# [    IconLocation$
 Left=�   MouseOverForeground
 �   �   MousePressedForeground
 �����   MouseOverBackground
 ��ح�   MousePressedBackground
 ��  �   MouseOverBorderBrush
 �����   MousePressedBorderBrush
 �����$��10q�$
��20,3q�$��Center=�