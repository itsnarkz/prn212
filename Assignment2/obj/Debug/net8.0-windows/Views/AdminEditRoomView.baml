   M S B A M L   `   `   `  ����G  CAssignment 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment1PRN.ViewsAssignment1PRN.Views  5      ,    &Assignment1PRN.Views.AdminEditRoomView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Assignment1PRN.Views     5      .��5	      � .+�5
   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   $��10q�6?   .+�5      �� $��Edit Room Information��6   $��20(�69   $
��Bold"�6G   5      � 5      $��1��6   $��10q�6     � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $��Room number:��6   $	��Top=�60   �� 5      $	��200��66   $	��Top=�6B   $��	100 0 0 0q�6Z   ��6   �� *
RoomNumber+6Z   �� 5      $��Description:��6   $	��Top=�60   $��0 30 0 0q�6H   �� 5      $	��Top=�6A   $��
100 30 0 0q�6Y   ��6   �� *RoomDetailDescription+6Y   �� 5       $��Room capacity:��6   $	��Top=�62   $��0 60 0 0q�6J   �� 5!      $	��Top=�6;   $��
100 60 0 0q�6S   ��6   �� *RoomMaxCapacity+6S   �� 5#      $��Room type id:��6   $	��Top=�61   $��0 90 0 0q�6I   �� 5$      $	��Top=�66   $��
100 90 0 0q�6N   ��6   �� *
RoomTypeId+6N   �� 5&      $��Status��6   $	��Top=�6*   $��	0 120 0 0q�6B   �� 5'      $	��Top=�62   $��100 120 0 0q�6J   ��6   �� *Status+6J   �� 5)      $��Price��6   $	��Top=�6)   $��	0 150 0 0q�6A   �� 5*      $	��Top=�6;   $��100 150 0 0q�6S   ��6   �� *RoomPricePerDay+6S   5+      5,      �� 5-   
   $��Confirm��6   
��� � �$��38,250,650,465q�6R   ��66   �� *	Confirm+6l   �� 5.   
   $��Cancel��6   
���  ��$��200,250,500,465q�6N   ��63   �� *Cancel+6N   50      51      