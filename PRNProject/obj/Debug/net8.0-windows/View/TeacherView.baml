   M S B A M L   `   `   `  ����E  APRNProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PRNProject.ViewPRNProject.View  5   	   !    PRNProject.View.TeacherView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PRNProject.View     5   	   -   5          � Title$  Teacher Page��5	   	   $	��486��6   $	��800��6+   .��5
      � .+�5   
   � $
��Left=�6   $��81��6*   $	��Top=�66   $	��619��6N   $��	10,10,0,0q�6Z   .+�5      �� $��
RollNumber��6   $
��Left=�6)   $	��Top=�6D   �� 5      $
��Name��6   $
��Left=�6#   $��0,26,0,0q�6>   $	��Top=�6P   �� 5      $	��DOB��6   $
��Left=�6"   $��0,52,0,0q�6=   $	��Top=�6O   �� 5      $��Major��6   $
��Left=�6$   $��	223,0,0,0q�6?   $	��Top=�6R   �� 5      $��Class��6   $
��Left=�6$   $��
223,26,0,0q�6?   $	��Top=�6S    J� RenderTransformOrigin$ 0.197,0.549&�6k   �� 5      -   5         ��Name$ 
rollNumber��5      $
��Left=�6*   $��78,4,0,0q�6E    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��107��6�   $��22��6�   ${�False��6�   �� 5      -   5        $
 name��5      $
��Left=�6$   $��78,0,0,0q�6?   $
 Wrap=�6Q   $��Center=�6e   $	��107��6�   $��22��6�   �� 5      -   5        $ major��5      $
��Left=�6%   $��	283,4,0,0q�6@   $
 Wrap=�6S   $	��Top=�6g   $	��107��6   $��22��6�   �� 5      -   5        $ classtxt��5      $
��Left=�6(   $��	283,0,0,0q�6C   $
 Wrap=�6V   $��Center=�6j   $	��107��6�   $��22��6�   �� 5      $��Phone��6   $
��Left=�6$   $��	452,0,0,0q�6?   $	��Top=�6R   �� 5      $��Email��6   $
��Left=�6$   $��
452,26,0,0q�6?   $	��Top=�6S   $ 0.197,0.549&�6k   �� 5      -   5        $ phone��5      $
��Left=�6%   $��	512,4,0,0q�6@   $
 Wrap=�6S   $	��Top=�6g   $	��107��6   $��22��6�   �� 5      -   5        $ email��5      $
��Left=�6%   $��	512,0,0,0q�6@   $
 Wrap=�6S   $��Center=�6g   $	��107��6�   $��22��6�   �� 5      $	��GPA��6   $
��Left=�6"   $��
452,55,0,0q�6=   $	��Top=�6Q   $ 0.197,0.549&�6i   �� 5      -   5        $	 gpa��5      $
��Left=�6#   $��
512,57,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��107��6~   $��22��6�   (  "System.Windows.Controls.DatePicker  5      -	   5          Name$	 dob��5      $
��Left=�6&   $��	78,56,0,0q�6A   $	��Top=�6T   5      &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dg��5   "      	RowHeight$ 30Q�6      AutoGenerateColumns$ False��6.      HeadersVisibility$ Column=�6J   	   CanUserAddRows$	 False��6e   $��26,96,30,65q�6|   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Roll Number��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	RollNum+6V     5       $
 Name��6%   $ * 6L    63   �� *Name+6L     5!      $ Date of Birth��6%   $ * 6T    6<   �� *Dob+6T     5"      $ Email��6%   $ * 6N    64   �� *Email+6N     5#      $ Phone��6%   $ * 6N    64   �� *Phone+6N     5$      $ Class��6%   $ * 6N    64   �� *Class+6N     5%      $ Major��6%   $ * 6N    64   �� *Major+6N     5&      $	 GPA��6%   $ * 6J    62   �� *Gpa+6J   5(      �� 5)   
   -   5         ��Name$ add_btn��5)      $	��Add��6"   $
��Left=�60   $��
26,410,0,0q�6K   $	��Top=�6_   $��30��6w   $��91��6�   6�   �� 5*   
   -   5        $ 
remove_btn��5*      $��Remove��6%   $
��Left=�66   $��182,410,0,0q�6Q   $	��Top=�6f   $��30��6~   $��91��6�   6�   �� 5+   
   -   5        $ edit_btn��5+      $
��Edit��6#   $
��Left=�62   $��345,410,0,0q�6M   $	��Top=�6b   $��30��6z   $��91��6�   6�   �� 5,   
   -   5        $ 
logout_btn��5,      $��Logout��6%   $
��Left=�66   $��	679,8,0,0q�6Q   $	��Top=�6d   $��30��6|   $��91��6�   6�   �� 5-   
   -   5        $
 noti��5-      $��Notifications��6   $
��Left=�67   $��506,410,0,0q�6R   $	��Top=�6g   $��30��6   $��91��6�   6�   5/      50      