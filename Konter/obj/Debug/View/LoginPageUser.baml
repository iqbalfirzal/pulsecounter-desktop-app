   M S B A M L   `   `   `  ����A  =Konter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KonterKonter  5   	       Konter.LoginPageUser   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Konter     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  ../Images/icon.png��5	   	    � Title$ Login Karyawan��5
   	   $	��500��6    $	��350��6-    � 
ResizeMode$ NoResize=�69    � WindowStyle$
 None=�6O   $��Segoe UI Emoji)�6b    � WindowState$ Normal=�6~    � WindowStartupLocation$ CenterScreen=�6�    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6&   	 W� From$	 0X�6J   	
 W� To$
 1X�6S    g� Duration$ 0:0:2D�6Z    g� FillBehavior$ HoldEnd=�6k   5      5      5      .��5      �� 
�������$��10q�6%   
������� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 2Q�6   ._�5   
   � 
�������.+�5      �� $	��280��6   $	��Top=�6%   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�6;   .��5      �  � Color$ LightSeaGreen��6'    � Offset$ 0Q�6=   � 5      $ 
BlueViolet��6'   $	 1.0Q�6:   5      5!      �� 5"      $	��280��6   $	��240��6$   $��Bottom=�61   $
��0,80q�6L    �� RadiusY$ 10��6Z    �� RadiusX$ 10��6g   
������� 5#        5$         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E   $ 1Q�6]      Color$ 	#FFBBBBBB��6m   5&      � 5'      $��Bottom=�6   $��35,80q�6.   $	��240��6=   .+�5(      �� $��
LOGIN USER��6   $��Center=�6-   $	��Top=�6J   $��5q�6b   ���	#FF020000$��18(�6�   $
��Bold"�6�   �� 5)      $��Center=�6   $��15q�68   .+�5*      �� -   5         ��Name$ txtUsernameUser��5*      $
��0,10q�67   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ USERNAME��6E    %  !MaterialDesignFloatingHintTextBox#��[  5+      $��Champagne & Limousines)�5,      $��18(�6B   
���   �6P   G� 5-      -   5         G�Name$ txtPasswordUser��5-   "   $
��0,10q�6;   $ PASSWORD��6I    ) %MaterialDesignFloatingHintPasswordBox#��[ 5.      $��Champagne & Limousines)�5/      $��18(�6F   
���   �6T   50      51      �� 52      -   5         ��Name$ btnLoginUser��52      $	��150��6+   $��Center=�67   $��Bottom=�6T   $
��0,65q�6o   $��LOGIN��6}   6�   �� 53      -   5         ��Name$ 	ImageBack��53      $��..\Images\back.png��6'    �� Left$ 74��6C   
 �� Top$	 224��6T   $��127,424,136,6q�6e   �� 54      -   5        $ btnBackUser��54      $�� ��6*   $
��Left=�65   $��33��6P   $��132,432,0,0q�6\   $	��Top=�6q   $��59��6�     J� Opacity$  0Q�6�   6�   '  !MaterialDesignThemes.Wpf.PackIcon  55      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]!   Kind$! Account=�6&   $	��150��65   $	��120��6A   $��Center=�6N   $��100,10,0,370q�6i   
�������6   56      57      58      