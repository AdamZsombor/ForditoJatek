   M S B A M L   `   `   `  ����P  LAdam_Zsombor_beadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Adam_Zsombor_beadandoAdam_Zsombor_beadando  5      _4clr-namespace:Adam_Zsombor_beadando.Views.Converters&Adam_Zsombor_beadando.Views.Converters  64   $    Adam_Zsombor_beadando.Tablazat   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Adam_Zsombor_beadando     5      K
converters4clr-namespace:Adam_Zsombor_beadando.Views.Converters     64     � DataContext  5
      ��  �� RelativeSource �� *Self+ � 	Resources 5      G  AAdam_Zsombor_beadando.Views.Converters.HasIdToVisibilityConverter )  %converters:HasIdToVisibilityConverterE  ?Adam_Zsombor_beadando.Views.Converters.HasIdToEditTextConverter ' #converters:HasIdToEditTextConverter��%:   &	        &	        5      6*     5      6(   5      .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         
IsReadOnly$
 True��5      $��Stretch=�5      $	��Top=�5      ���#636e72$��20(�5      ���#2d3436   AutoGenerateColumns$ False��5      $   HorizontalScrollBarVisibility$
 Auto=�5      ��5      ��  �� Path$ 
DataSource� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value��%�   '        �� 5      "  6   .�5       �� 	 � ��
 �#636e726#   �� 5!      	 � ��
 �#dfe6e96#   �� 5"      	 � ��$
 SemiBold"�6#   �� 5#      	 � ��$
 0,0,1,2q�6(   �� 5$      	 � ��
 �#2d34366$   5&      5'         	CellStyle 5)      �� 5*      *  $System.Windows.Controls.DataGridCell"  6   �5+      �� 5,      	 � ��
 �#b2bec36$   5.         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Magyar��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6(   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 63   �� *Hun+  53      $ Angol��6   $ 5* 6'    62   �� *Eng+4
  .System.Windows.Controls.DataGridTemplateColumn
  55      $ Törlés��6   $ 2* 6,    
  CellTemplate 56      �� 57      .R�58      ��  ��Name$ DeleteDictionaryRecord��6   -   5        $��Törlés��59   	   y�5:   	   �� $ Id� �� 	Converter# [  5;   	   5<      5>      
  5@      $ Frissítés��6   $ 2* 6/    5A      �� 5B      .R�5C      �� $ UpdateDictionaryRecord��6   -   5        ��5D   	   �� $ Id�# [ 5E   	   5F      5H      5K      5M      