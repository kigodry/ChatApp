   M S B A M L   `   `   `  ����D  @ChatHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ChatHello	ChatHello  5          ChatHello.AdminChatPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ChatHello     5        N� Title$  AdminChatPage��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ userList��5      $��10q�6(   
������ 
������ ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����67   �� 5       � ��$ 16(�65   �� 5       � ��$ 5q�63   5      5      5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5       $��* �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    .+�5&      �� -   5        $ messageListBox��5&   #   $��1��6   $��10q�6;   
������ 
�������$��Center=�6t   �� 5)      $��2��6    �� Orientation$ 
Horizontal=�6&   ���#007ACC.+�5*      �� -   5         ��Name$ 
messageBox��5*      $��10q�6.   $��Center=�6:   $��16(�6U   $��40��6c   $	��400��6r   �� 5+      -   5        	 ��Name$	 
sendButton��5+      $��Отправить��6-   $��10q�6A   $
��10 5q�6M   $��16(�6\   $
��Bold"�6j   ���#4CAF50
�������6�   �� 5,      -   5        $	 viewLogsButton��5,      $!��Просмотр логов��61   $��10q�6J   $
��10 5q�6V   $��16(�6e   $
��Bold"�6s   ���#FFC107
���   �6�   �� 5-      -   5        $	 
exitButton��5-      $��
Выход��6-   $��10q�6=   $
��10 5q�6I   $��16(�6X   $
��Bold"�6f   ���#F44336
�������6�   5.      5/      50      51      