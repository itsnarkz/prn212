using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BussinessObjects.Repository;
using HE181099_Assignment1.Models;

namespace HE181099_Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICustomerRepository customerRepository;
        public MainWindow()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text=="")
            {
                this.Hide();
                Booking mainWindow = new Booking(3);
                mainWindow.Show();
                return;
            }
            Customer customer = customerRepository.GetCustomerByEmail(txtUser.Text);
            if (customer != null && customer.Password.Equals(txtPass.Password)
                && customer.CustomerStatus==1)
            {
                this.Hide();
                Booking mainWindow = new Booking(customer.CustomerId);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("You are not permitted!");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}