   M S B A M L   `   `   `  ����D  @ChatHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ChatHello	ChatHello  5   	       ChatHello.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ChatHello     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��415��6)   .��5	      � $��Center=�6   $��Center=�6(    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
    � -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   �� 5   
   $9��3Добро пожаловать в чат ChatHello��6   $��Center=�6<   $��	0,20,0,10q�6Y   $��20(�6l   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Имя: ��6   $��Center=�6%   $��20,0,0,0q�6@   �� 5      -   5         ��Name$ UserName��5      $	��200��6(   $��Center=�64   $��25,0,0,0q�6O   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��IP адрес: ��6   $��Center=�6*   $��12,0,0,0q�6E   �� 5      -   5        $ IPAdress��5      $	��200��6(   $��Center=�64   $��12,0,0,0q�6O   5      �� 5   
   $��3��6   $ 
Horizontal=�6"   $��10q�6;   .+�5       �� -   5        $&�� Создать новый чат��5       $	��150��61   $��30��6=   $��0,0,10,0q�6I   6[   �� 5!      -   5        $,��&Зайти в существующий��5!      $	��150��64   $��30��6@   6L   5"      5$      5%      