   M S B A M L   `   `   `  ����A  =Konter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KonterKonter  5          Konter.MngrLaporan   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Konter     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6     � Triggers  5
      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:1D�6#   5      5      5      .��5      � $	��550��6   $	��770��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $
��Left=�6   $	��550��60   $	��Top=�6=   $	��770��6U   $��2��6a   $��2��6u   .+�5      �� $��44��6   $
��10,0q�6%   
�������.+�5       �� -   5         ��Name$ lblJudul��5       $/��)LAPORAN RIWAYAT TRANSAKSI PENJUALAN PULSA��6*   $��10,10,324,10q�6^   $��16(�6t   
���   �$
��Bold"�6�   $��30��6�   5!      �� 5"      $	��445��6   $
��10,0q�6&   
�������.+�5#      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 
dtgLaporan��5#      
dtgLaporan��
   AutoGenerateColumns
 .   �� SelectedIndex$ 0��6v   $	��445��6�   ��6B   ��    Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ No Transaksi��6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ��  �� Path$ kd_Transaksi�6U     5&      $ Nomor Handphone��6X    6-   �� $ nomor_Handphone�6X     5'      $ Nominal��6P    6-   �� $ nominal�6P     5(      $ Harga��6N    6-   �� $ Harga�6N     5)      $ Nama Karyawan��6M    6-   �� $
 Nama�6M     5*      $ Tgl Transasksi��6Z    6-   �� $ tanggal_Transaksi�6Z   5,      �� 5-      -   5         ��Name$ txtGetKdTransaksi��5-      $
��Left=�6}   $��Center=�6�   $y�Hidden=�6�   ��65   ��  �� ElementName$ 
dtgLaporan��$ SelectedItem.kd_Transaksi�6�   5.      � 5/      $��65��6   $
��10,0q�6    50      �� 51      $	��17* �6'   �� 52      $	��24* �6'   �� 53      $	��34* �6'   .+�55      �� -   5         ��Name$ btnPrint��55      $��Cetak��6+   $
��Left=�6;   $��0,10,0,0q�6V   $	��Top=�6h   $	��159��6�   $��40��6�   ���	#FF2196F3���	#FF2196F3$��0��6�   6�   �� 56      -   5        $ btnRest��56      $��
Reset Data��6*   $
��Left=�6?   $��	10,10,0,0q�6Z   $	��Top=�6m   $	��159��6�   $��40��6�   ���	#FF303030���	#FF303030$��1��6�   6�   57      58      59      5:      