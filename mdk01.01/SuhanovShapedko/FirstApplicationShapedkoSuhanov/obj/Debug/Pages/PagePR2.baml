   M S B A M L   `   `   `  ����Z  VFirstApplicationShapedkoSuhanov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:FirstApplicationShapedkoSuhanov.Pages%FirstApplicationShapedkoSuhanov.Pages  5      3    -FirstApplicationShapedkoSuhanov.Pages.PagePR2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:FirstApplicationShapedkoSuhanov.Pages     5        N� Title$  PagePR2��5	      .��5      � 
����ح� � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�5      .+�5      �� $ Vertical=�6   $��Center=�5      .+�5      �� $ 
Horizontal=�6   $��Center=�5      .+�5      �� $'��!Введите значение X��6    $��10q�5      �� 5      -   5        $
��txtX��5      $��10q�5      $	��100��5      
������5      5      �� 5       $ 
Horizontal=�6   $��Center=�5!      .+�5"      �� $'��!Введите значение y��6    $��10q�5#      �� 5$      -   5        $
��txtY��5$      $��10q�5%      $	��100��5&      
������5'      5*      �� 5+      $ 
Horizontal=�6   $��Center=�5,      .+�5-      �� $'��!Введите значение z��6    $��10q�5.      �� 5/      -   5        $
��txtZ��5/      $��10q�50      $	��100��51      
������52      55      58      �� 59      $ Vertical=�6   $��Center=�5:      $��20q�5;      .+�5<      	� -   5        $��rbtSin��5=       	� 	GroupName$ Function��5<      $��Sin(x)��5>       d� 	IsChecked$
 TrueY�5?      $��10q�5@      	� 5A      -   5        $��rbtSqrX��5B      $ Function��5A      $	��x^2��5C      $��10q�5D      	� 5E      -   5        $��rbtExp��5F      $ Function��5E      $��Exp(x)��5G      $��10q�5H      5I      5J      �� 5K   
   $��1��6   $ Vertical=�6"   $��Center=�5L      .+�5M      �� $A��;Результат выполнения программы:��6   $��10q�5N      �� 5O      -   5        $��	lstResult��5O      $��10q�5P      $	��150��5Q      
�������5R      5S      ]� 5U   
   $��2��6   $��Center=�5V      .+�5W      �� -   5        $��btnCalc��5W      $��50��6$   $	��150��5X      $��Выполнить��5Y      $��10q�6)   5Z      �� 5\      -	   5        $��btnClear��5\      $��50��6%   $	��150��5]      $��Очистить��5^      $��10q�6(   5_      5a      5b      5d      