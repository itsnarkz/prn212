   M S B A M L   `   `   `  ����E  APRNProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PRNProject.ViewPRNProject.View  5   	   &     PRNProject.View.NotificationView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PRNProject.View     5   	     � Title$  Notification��5   	   $	��500��6   $	��800��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5
   8      	RowHeight$ 30Q�6   $��10,119,47,97q�6"      AutoGenerateColumns$ False��6D      HeadersVisibility$ Column=�6`      CanUserAddRows$ False��6{      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+6H     5      $ Content��6%   $ * 6R   	 66   �� *	Content+6R   5      �� 5   
   -   5        
 ��Name$
 add_btn��5      $	��Add��6"   $
��Left=�60   $��235,412,0,0q�6K   $	��Top=�6`   $��30��6x   $��84��6�   6�   �� 5   
   -   5        $
 
remove_btn��5      $��Remove��6%   $
��Left=�66   $��400,410,0,0q�6Q   $	��Top=�6f   $��32��6~   $��92��6�    J� RenderTransformOrigin$ -0.227,-0.463&�6�   6�   �� 5   
   $��Content��6   $
��Left=�6"   $��	72,45,0,0q�6=   $	��Top=�6P   $��39��6h   $��75��6t   $��16(�6   �� 5   
   -   5         ��Name$ content��5      $
��Left=�6#   $��
165,21,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��379��6~   $��87��6�   �� 5   
   -   5        $
 back_btn��5      $
��Back��6#   $
��Left=�62   $��
63,412,0,0q�6M   $	��Top=�6a   $��30��6y   $��84��6�   6�   5      5      