using BusinessObjects;
using Services;
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

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAccountService accountService;
        public LoginWindow()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountMember accountMember = accountService.GetAccountById(txtUser.Text);
            if(accountMember != null && accountMember.memberPassword.Equals(txtPass.Password) && accountMember.role == 1) {
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            } else
            {
                MessageBox.Show("You have no permissions!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
