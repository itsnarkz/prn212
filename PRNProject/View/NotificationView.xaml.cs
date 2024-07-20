using PRNProject.Models;
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
    /// Interaction logic for NotificationView.xaml
    /// </summary>
    public partial class NotificationView : Window
    {
        private NotificationService notificationService;

        private void load()
        {
            dg.ItemsSource = notificationService.GetNotifications();
        }

        public NotificationView()
        {
            notificationService = new NotificationService();
            InitializeComponent();
            load();
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TeacherView main = new TeacherView();
            main.Show();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = new Notification();
            notification.Content = content.Text;

            notificationService.add(notification);
            load();
        }

        private void remove_btn_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = dg.SelectedItem as Notification;
            if (notification == null) return;

            notificationService.remove(notification);
            load();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notification notification = (Notification) dg.SelectedItem;
            if(notification == null) return;

            content.Text = notification.Content;
        }
    }
}
