   M S B A M L   `   `   `  ����  OS11    OS11.Views.HomePageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
�������$��Stretch=�5      $��Stretch=�6,   $��0q�6H   $��0q�6T     J� Opacity$  1Q�6_   $	��904��6k   $	��646��6z    � 	Resources 5	         HomePageBtn �� 
TargetType �� Property �� Value �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration		   To
   
Storyboard   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name � Cursor �� RadiusY �� RadiusX J� SnapsToDevicePixels �� Triggers P� Property P� Value  OpenSampleBtn  OpenExistingBtn  HelpBtn��%�  &	        &	 w    &	 �
    &	 i    �� 5
      " ��6   .�5      ��  � �� 5      �� 5      " ��6   .R�5      �  5   	     5   
   CommonStates�� 5        5      $ 0:0:0.2D�6     5      $ 0:0:0.2D�6   $	 	MouseOver��69   .
 5      �� 5      . 5        
Normal��6     5      	MouseOver��. 5      �� .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6*   $ 	rectangle��6k   .g�5        $ 0��6"   $ 	#FFEBEBEB��6.   5      �� 5      $, &(Shape.Stroke).(SolidColorBrush.Color)�6*   $ 	rectangle��6m   .g�5        $ 0��6"   $ 	#FFADADAD��6.   5      5       5!        5"      Pressed��6     5#      Disabled��6   5$      .+�5&   	   �� $ 	rectangle��6   $
 Hand��6&   $ 4��64   $ 4��6@   ���	#FFCFCFCF
�������6_   �� 5'   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   �� 5(   	   $��New Reconstruction��6   $��0q�6,   $��Center=�67   $��Center=�6T   ���	#FF3F3F3F$��Center=�6�   $��Disabled=�6�   $��16(�6�   $��Center=�6�   $��0q�6  $��Lucida Sans)�6  $
 Hand��63  5)   	    5*      P� 5+   	    �@J�	IsFocused . 6&   P� 5,   	    �@��IsDefaulted . 6(   P� 5-   	    �@J�IsMouseOver . 6(   P� 5.   	    � �� . 6&   P� 5/   	    � {� .  6&   51      53      54      �� 55      " ��6    .�56      ��  � �� 57      �� 58      " ��6   .R�59      �  5:   	     5;   
   CommonStates�� 5<        5=      $ 0:0:0.2D�6     5>      $ 0:0:0.2D�6   $	 	MouseOver��69   .
 5?      �� 5@      . 5B        
Normal��6     5C      	MouseOver��. 5D      �� .��5E      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6*   $ 	rectangle��6k   .g�5F        $ 0��6"   $ 	#FFEBEBEB��6.   5G      �� 5H      $, &(Shape.Stroke).(SolidColorBrush.Color)�6*   $ 	rectangle��6m   .g�5I        $ 0��6"   $ 	#FFADADAD��6.   5J      5K      5L        5M      Pressed��6     5N      Disabled��6   5O      .+�5Q   	   �� $ 	rectangle��6   $
 Hand��6&   $ 4��64   $ 4��6@   ���	#FFCFCFCF
�������6_   �� 5R   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   �� 5S   	   $��Open Sample��6   $��0q�6%   $��Center=�60   $��Center=�6M   ���	#FF3F3F3F$��Center=�6   $��Disabled=�6�   $��16(�6�   $��Center=�6�   $��0q�6  $��Lucida Sans)�6  $
 Hand��6,  5T   	    5U      P� 5V   	    �@J�	IsFocused . 6&   P� 5W   	    �@��IsDefaulted . 6(   P� 5X   	    �@J�IsMouseOver . 6(   P� 5Y   	    � �� . 6&   P� 5Z   	    � {� .  6&   5\      5^      5_      �� 5`      " ��6"   .�5a      ��  � �� 5b      �� 5c      " ��6   .R�5d      �  5e   	     5f   
   CommonStates�� 5g        5h      $ 0:0:0.2D�6     5i      $ 0:0:0.2D�6   $	 	MouseOver��69   .
 5j      �� 5k      . 5m        
Normal��6     5n      	MouseOver��. 5o      �� .��5p      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6*   $ 	rectangle��6k   .g�5q        $ 0��6"   $ 	#FFEBEBEB��6.   5r      �� 5s      $, &(Shape.Stroke).(SolidColorBrush.Color)�6*   $ 	rectangle��6m   .g�5t        $ 0��6"   $ 	#FFADADAD��6.   5u      5v      5w        5x      Pressed��6     5y      Disabled��6   5z      .+�5|   	   �� $ 	rectangle��6   $
 Hand��6&   $ 4��64   $ 4��6@   ���	#FFCFCFCF
�������6_   �� 5}   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   �� 5~   	   $#��Open Existing Reconstructions��6   $��0q�67   $��Center=�6B   $��Center=�6_   ���	#FF3F3F3F$��Center=�6�   $��Disabled=�6�   $��16(�6�   $��Center=�6�   $��0q�6  $��Lucida Sans)�6%  $
 Hand��6>  5   	    5�      P� 5�   	    �@J�	IsFocused . 6&   P� 5�   	    �@��IsDefaulted . 6(   P� 5�   	    �@J�IsMouseOver . 6(   P� 5�   	    � �� . 6&   P� 5�   	    � {� .  6&   5�      5�      5�      �� 5�      " ��6   .�5�      ��  � �� 5�      �� 5�      " ��6   .R�5�      �  5�   	     5�   
   CommonStates�� 5�        5�      $ 0:0:0.2D�6     5�      $ 0:0:0.2D�6   $	 	MouseOver��69   .
 5�      �� 5�      . 5�        
Normal��6     5�      	MouseOver��. 5�      �� .��5�      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6*   $ 	rectangle��6k   .g�5�        $ 0��6"   $ 	#FFEBEBEB��6.   5�      �� 5�      $, &(Shape.Stroke).(SolidColorBrush.Color)�6*   $ 	rectangle��6m   .g�5�        $ 0��6"   $ 	#FFADADAD��6.   5�      5�      5�        5�      Pressed��6     5�      Disabled��6   5�      .+�5�   	   �� $ 	rectangle��6   $
 Hand��6&   $ 4��64   $ 4��6@   ���	#FFCFCFCF
�������6_   �� 5�   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   �� 5�   	   $
��Help��6   $��0q�6   $��Center=�6)   $��Center=�6F   ���	#FF3F3F3F$��Center=�6x   $��Disabled=�6�   $��16(�6�   $��Center=�6�   $��0q�6   $��Lucida Sans)�6  $
 Hand��6%  5�   	    5�      P� 5�   	    �@J�	IsFocused . 6&   P� 5�   	    �@��IsDefaulted . 6(   P� 5�   	    �@J�IsMouseOver . 6(   P� 5�   	    � �� . 6&   P� 5�   	    � {� .  6&   5�      5�      5�      5�      .��5�   
   � -   5         �Name$ 
LayoutRoot��5�      
�������.+�5�      � $��Center=�6   $��Center=�60   .+�5�      �� 
�������$��0q�6&   $	��400��61   $��Bottom=�6>   $��Center=�6Y   $	��600��6v   $ 20��6�   $ 20��6�   ���	#FF0677B2 �� StrokeDashArray$	 4 4R�6�    . 6�   �� 5�      $��
0,-230,0,0q�6   $,��&/OS11;component/images/mosaiq_logo.png��6)   $
��Fill=�6Y   $��144.674��6h   $��Center=�6y   $	��501��6�   $��Center=�6�   F� 5�      -   5         F�Name$ div_line��5�      ���� z  �}
� 4I# �}
	
�������$��1��6J   $��	8,169,7,0q�6U    �� Stretch$
 Fill=�6h   ���	#FF0677B2$	��Top=�6�   $��Center=�6�   $	��600��6�   $	 4 4R�6�   �� 5�      $��	8,171,8,0q�6   .+�5�      �� -   5        $��Button��5�      $��Center=�6(   $��40��6E   $��0,20,0,0q�6Q   #���   6c   $��Center=�6�   $	��300��6�   6�   �� 5�      -   5        $��Button��5�      $��Center=�6(   $��40��6E   $��0,15,0,0q�6Q   #���  6c   $��Center=�6�   $	��300��6�   6�   �� 5�      -   5        $��Button��5�      $��Center=�6(   $��40��6E   $��0,15,0,0q�6Q   #���  6c   $��Center=�6�   $	��300��6�   6�   �� 5�      -   5        $��Button��5�      $��Center=�6(   $��40��6E   $��	0,15,0,20q�6Q   #���  6d   $��Center=�6�   $	��300��6�   6�   5�      5�      5�      5�      