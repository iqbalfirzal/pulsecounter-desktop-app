   M S B A M L   `   `   `  ����A  =Konter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KonterKonter  5   	       Konter.AdminPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Konter     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  ../Images/icon.png��5   	   $	��600��5	      $
��1024��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5
      � -   5        ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � 
�������$��10��6%   � 5      $��5q�6   $��38��6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5         ��Name$ ButtonFechar��5      $��32��63   $��30��6>    � ToolTip$ Keluar��6w   $��0q�6�   
���������6J   Z� ��6`   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ Logout=�62   $��30��6@   $��32��6L   5      5      5      5      � 5   
   $��
250 55 0 0q�6   .+�5      � -   5         �Name$ GridPrincipal��5      $��Center=�6*   $��Center=�6G   5      � 5   
   $	��250��6   $
��Left=�6   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ 
BlueViolet��6#    � Offset$	 0.0Q�66   � 5      $ LightSeaGreen��6#   $	 1.0Q�69   5      .+�5       ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5    2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5!      � -   5        $ 
GridCursor��5!      $��	0 100 0 0q�6+   
���<��$��10��6S   $
��Left=�6^   $��60��6y   $	��Top=�6�   5"      �� 5#      -   5         ��Name$ ListViewMenu��5#      $��0,100,0,310q�6-   
�������$��Champagne & Limousines)�6Y   $��18(�6�    �� SelectedIndex$ 0��6�   .@�5$      �� $��60��6   .��5%      �� $ 
Horizontal=�6!   .+�5&        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�6c   $��5q�6~   �� 5'      $��Laporan��6$   $��17(�63   $��Center=�6A   $
��20 0q�6\   5(      5)      �� 5*      $��60��6   .��5+      �� $ 
Horizontal=�6!   .+�5,        $ Account=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5-      $��Karyawan��6$   $��17(�64   $��Center=�6B   $
��20 0q�6]   5.      5/      �� 50      $��60��6   .��51      �� $ 
Horizontal=�6!   .+�52        $ Details=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 53      $��Jenis Pulsa��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   54      55      56      57      58      59      