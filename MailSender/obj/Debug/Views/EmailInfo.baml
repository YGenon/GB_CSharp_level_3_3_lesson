   M S B A M L   `   `   `  ����  
MailSender     MailSender.Views.EmailInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      $
��Auto��5      $
��Auto��6     � DataContext  5
      �� *Main+   Locator �� Source# [  .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *ReadAllMailsCommand+5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $-��'Получатели сообщений��6   $��Center=�60   $
��Bold"�5      ]� 5   
   $��1��6   $��5q�6!   .+�5      � .+�5      �� $!��Поиск по имени:��6   �� 5      -   5        $��Search��5      $��15,0,0,0q�6J   $	��100��6\   5      5      &   System.Windows.Controls.DataGrid  5   
   $��2��6      AutoGenerateColumns .     
IsReadOnly . 	 �� SelectedItem	 6    �� *CurrentEmail+��5       �� *Emails+
   Columns
 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5$   %   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 5#   0   �� *Id+5$   %     5%      $ 
Почта��6%   $
 Auto 5&   	    5%   4   �� *Email+5&   	     5'      $# Имя отправителя��6%   $ * 5(   >    6%   �� *Name+6>   5*      �� 5+   
   $��3��6   $'��!Отобразить данные��6F   $
��Bold"�6b   ��6   �� *ReadAllMailsCommand+6b   5,      5-      