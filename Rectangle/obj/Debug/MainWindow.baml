   M S B A M L   `   `   `  ����D  @Rectangle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Rectangle	Rectangle  5   	       Rectangle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Rectangle     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5
      �  � ColumnDefinitions 5   
   .+�5   
   �� -   5         ��Name$ 	lengthBox��5      $
��Left=�6%   $��23��6@   $��
238,37,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   $��16(�6�   6�   �� 5   
   -   5        $ widthBox��5      $
��Left=�6$   $��23��6?   $��
238,84,0,0q�6K   $
 Wrap=�6_   $�� ��6t   $	��Top=�6|   $	��120��6�   $��16(�6�   6�   �� 5   
   -   5        $ strokeThicknessBox��5      $
��Left=�6.   $��23��6I   $��238,128,0,0q�6U   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��120��6�   $��18(�6�   �� 5   
   -   5         ��Name$ lengthBlock��5      $
��Left=�6)   $��
140,37,0,0q�6D   $
��Wrap=�6X   $��Length: ��6l   $	��Top=�6|   $��23��6�   $��18(�6�   �� 5   
   -   5        $ 
WidthBlock��5      $
��Left=�6(   $��
140,84,0,0q�6C   $
��Wrap=�6W   $��Width: ��6k   $	��Top=�6z   $��23��6�   $��18(�6�   �� 5   
   -   5        $ 
colorBlock��5      $
��Left=�6(   $��140,172,0,0q�6C   $
��Wrap=�6X   $��Color: ��6l   $	��Top=�6{   $��23��6�   $��18(�6�    J� RenderTransformOrigin$ 0.465,0.061&�6�   �� 5   
   -   5        $ strokeThicknessBlock��5      $
��Left=�62   $��140,128,0,0q�6M   $
��Wrap=�6b   $��Thickness: ��6v   $	��Top=�6�   $��23��6�   $��18(�6�   �� 5   
   -   5         ��Name$ Confirm��5      $��Confirm��6"   $
��Left=�64   $��140,244,0,0q�6O   $	��Top=�6d   $��60��6|   $��30��6�   6�   �� 5   
   -	   5        $ Cancel��5      $��Cancel��6!   $
��Left=�62   $��220,244,0,0q�6M   $	��Top=�6b   $��60��6z   $��30��6�   6�   �� 5   
   -
   5        $ Close��5      $��Close��6    $
��Left=�60   $��298,244,0,0q�6K   $	��Top=�6`   $��60��6x   $��30��6�   6�   #  Xceed.Wpf.Toolkit.ColorPicker  5   
   -   5        $��colorPicker��5         DisplayColorAndName . $��238,172,154.429,119.143q�6�   5      5       