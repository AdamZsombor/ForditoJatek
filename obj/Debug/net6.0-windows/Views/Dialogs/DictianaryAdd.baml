   M S B A M L   `   `   `  ����P  LAdam_Zsombor_beadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Adam_Zsombor_beadando.Views.Dialogs#Adam_Zsombor_beadando.Views.Dialogs  5   	   7    1Adam_Zsombor_beadando.Views.Dialogs.DictianaryAdd   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Adam_Zsombor_beadando.Views.Dialogs     5   	     � Title$  DictianaryAdd��5   	   $	��450��6   $	��450��6,   ���#FFFF80 � 
ResizeMode$ NoResize=�5
       � DataContext 5      ��  �� RelativeSource �� *Self+.��5      �  � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��1* �6   .+�5      �� $��Magyar:��5      $��44(�5      $��Center=�5      $��Right=�5      $��0 0 10 0q�5      5      �� 5      $��Angol:��5      $��44(�5      $��Center=�5       $��Right=�5!      $��1��5"      $��0 0 10 0q�5#      5$      �� 5%      $��1��5&      $��10 50 10 50q�5'      $��44(�5)      ��5(      ��  �� Path$ 
Szotar.Hun�.��5)      5*      �� 5+      $��1��5,      $��1��5-      $��10 50 10 50q�5.      $��44(�50      ��5/      �� $ 
Szotar.Eng�.��50      51      �� 52      -   5         ��Name$ 
SaveButton��55      $��Mentés��53      $��10 10 10 10q�54      $��24(�56      $��1��57      $��2��58      ��59      �� 5:       �� 
TargetType" ��6   .�5;      �� 	 �� Property	 � ��
 �� Value
 �#74b9ff6$   �� 5<      	 � ��
 �#1b1e8f6$   �� 5=      	 �@�Cursor$

 Hand��6     �� Triggers 5>      P� 5?       P� Property �@J�IsMouseOver P� Value$
 True��6'   . �5@   	   �� 	 � ��
 �#0984e36&   5A   	   5C      ��5E      �� 5F       �� 
TargetType" ��6   .R�5G      �� $	��150��6   $��50��5H       �� CornerRadius$ 12��5I      #��z��5J      ._�5K      �� $��Center=�5L      $��Center=�5M      5N      5O      5Q      �� 5R      -   5        $ CancelButton��5U      $��Mégsem��5S      $��10 10 10 10q�5T      $��24(�5V      $��0��5W      $��2��5X      ��5Y      �� 5Z      " ��6   .�5[      �� 	 � ��
 �#74b9ff6$   �� 5\      	 � ��
 �#1b1e8f6$   �� 5]      	 �@�Cursor$

 Hand��6     5^      P� 5_       �@J�IsMouseOver$
 True��6'   . �5`   	   �� 	 � ��
 �#0984e36&   5a   	   5c      ��5e      �� 5f      " ��6   .R�5g      �� $	��150��6   $��50��5h      $ 12��5i      #��z��5j      ._�5k      �� $��Center=�5l      $��Center=�5m      5n      5o      5q      5r      5s      