using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment1PRN.Views;

namespace Assignment1PRN.ViewModels
{
    public class LoginPageViewModel : ViewModel
    {
        private CustomerService customerService;
        private string email;
        private string password;
        private string errorMessage;
        public ObservableCollection<Customer> customers { get; set; }
        public string ErrorMessage { get => errorMessage; set => SetField(ref errorMessage,value); }
        public ICommand LoginCommand { get; set; }
        public string Email
        {
            get => email;
            set
            {
                SetField(ref email, value);
            }
        }
        public string Password 
        { 
            get => password;
            set
            {
                SetField(ref password, value);
            }
        }
        public LoginPageViewModel(Navigation navigation)
        {
            email = "";
            password = "";
            ErrorMessage = "";
            customerService = new CustomerService();
            LoginCommand = new BaseCommand(()=>Login(navigation));
        }

        bool CanLogin()
        {
            return customerService.HasCustomer(email,password);
        }
        void Login(Navigation navigation)
        {
            if (!CanLogin())
            {
                ErrorMessage = "Wrong email or password";
                return;
            }
            Customer customer = customerService.GetCustomer(email,password);
            if(customer.CustomerStatus==1)
                navigation.ViewModel = new UserProfileViewModel(customer,navigation);
            else
            {
                navigation.ViewModel = new AdminWorkSpaceViewModel(navigation);
            }
        }
    }
}
