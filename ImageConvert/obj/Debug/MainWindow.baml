   M S B A M L   `   `   `  ����G  CImageConvert, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ImageConvertImageConvert  5   	       ImageConvert.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ImageConvert     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)   $	��350��65   $	��600��6E   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��5* �6   �� 5      $
��1.2* �6   .+�5   
   �� $��PngFolderPath : ��6   $��	5,0,2.5,0q�6+   $��30��6>    �� TextAlignment$ Right=�6J   $��Center=�6`    �� 
IsReadOnly . 6�   �� 5   
   -   5        $��FolderNameLabel��5   e   $��1��6   $��2.5,0,2.5,0q�6"   $��30��67   $��Center=�6C    . 6|   �� 5   
   -   5        $��BrowseButton��5   4   $��2��6   $��	2.5,0,5,0q�6!   $��Browse��6H   $��30��6Y   $
��auto��6e   6r   �� 5   
   -   5        $��1��5      $��Convert JPG��6   $��3��64   $��Center=�6H   $��40��6e   $��Center=�6q   $	��240��6�   $��7,0,0,10q�6�   $��18(�6�   6�   �� 5   
   -   5        $��PngFileCount��5   -   $��1��6   $��1��6   $��5,0,0,0q�6A   $��25��6R   $��Center=�6^   $��Bottom=�6{   �� 5    
   $��2��6   $��OutPutFolderPath : ��6   $��	5,0,2.5,0q�6:   $��30��6M   $ Right=�6Y   $��Center=�6o    . 6�   �� 5!   
   -   5        $��OutPutFolderNameLabel��5!   r   $��2��6   $��1��6   $��2.5,0,2.5,0q�6/   $��30��6D   $��Center=�6P    . 6�   �� 5"   
   -   5        $��
OpenButton��5"   A   $��2��6   $��2��6   $��	2.5,0,5,0q�6.   $
��Open��6S   $��30��6b   $
��auto��6n   6{   5#      5$      