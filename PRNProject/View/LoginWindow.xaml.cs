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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginService loginService;
        public LoginWindow()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            string username1 = username.Text;
            string password1 = password.Password;

            if(loginService.canLogin(username1, password1)) {
                if (loginService.getByUsername(username1).Role == "Student")
                {
                    this.Hide();
                    StudentView main = new StudentView();
                    main.Show();
                } else
                {
                    this.Hide();
                    TeacherView main = new TeacherView();
                    main.Show();
                }
            } else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
    }
}
