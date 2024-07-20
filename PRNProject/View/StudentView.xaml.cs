using PRNProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRNProject.View
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : Window
    {
        private NotificationService notificationService;
        public StudentView()
        {
            notificationService = new NotificationService();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = notificationService.GetNotifications();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginWindow main = new LoginWindow();
            main.Show();
        }
    }
}
