   M S B A M L   `   `   `  ����G  CAssignment 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment1PRN.ViewsAssignment1PRN.Views  5      &     Assignment1PRN.Views.UserProfile   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Assignment1PRN.Views     5      
�������.��5
      � .+�5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   $��10q�6?   .+�5      �� $��Customer Details��6   $��20(�64   $
��Bold"�6B   5      � 5      $��1��6   $��10q�6     � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $��
Full Name:��6   $	��Top=�6.   �� 5      $	��Top=�6G   $��	100 0 0 0q�6_   ��6   �� *Customer.CustomerFullName+6_   �� 5      $��
Telephone:��6   $	��Top=�6.   $��0 30 0 0q�6F   �� 5      $	��Top=�6@   $��
100 30 0 0q�6X   ��6   �� *Customer.Telephone+6X   �� 5!      $��Email:��6   $	��Top=�6*   $��0 60 0 0q�6B   �� 5"      $	��Top=�6C   $��
100 60 0 0q�6[   ��6   �� *Customer.EmailAddress+6[   �� 5$      $��	Birth Day��6   $	��Top=�6-   $��0 90 0 0q�6E   �� 5%      $	��Top=�6G   $��
100 90 0 0q�6_   ��6   �� *Customer.CustomerBirthday+6_   5'      5(      �� 5)   
   $��Edit profile��6   $��118,192,599,212q�6H   $��40��6a   ��6(   �� *EditProfile+6a   �� 5*   
   $��View Booking��6   $��237,192,470,212q�6H   $��40��6a   ��6(   �� *ViewBooking+6a   �� 5+   
   
���  ��
�������$��Logout��65   $��27,373,53,27q�6a   $��40��6w   ��6F   �� *Logout+6w   5-      5.      