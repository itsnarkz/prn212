   M S B A M L   `   `   `  ����G  CAssignment 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment1PRN.ViewsAssignment1PRN.Views  5   	   ,    &Assignment1PRN.Views.EditProfileWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   4local"clr-namespace:Assignment1PRN.Views     5   	   $	��600��5      $	��800��6'   .��5      � .+�5	   
   �   � RowDefinitions  5
      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   $��10q�6?   .+�5      �� $��Edit Profile��6   $��20(�60   $
��Bold"�6>   5      � 5      $��1��6   $��10q�6     � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $��
Full Name:��6   $	��Top=�6.   �� 5      $	��200��6<   $	��Top=�6H   $��	100 0 0 0q�6`   ��6   �� *CustomerFullName+6`   �� 5      $��
Telephone:��6   $	��Top=�6.   $��0 30 0 0q�6F   �� 5      $	��Top=�65   $��
100 30 0 0q�6M   ��6   �� *	Telephone+6M   �� 5      $��Email:��6   $	��Top=�6*   $��0 60 0 0q�6B   �� 5       $	��Top=�68   $��
100 60 0 0q�6P   ��6   �� *EmailAddress+6P   �� 5"      $��	Birth Day��6   $	��Top=�6-   $��0 90 0 0q�6E   �� 5#      $	��Top=�6<   $��
100 90 0 0q�6T   ��6   �� *CustomerBirthday+6T   5&      5'      �� 5(   
   $��Confirm��6   
��� � �$��38,200,650,336q�6R   ��66   �� *	Confirm+6l   �� 5)   
   $��Cancel��6   
���  ��$��200,200,500,336q�6N   ��63   �� *Cancel+6N   5+      5,      