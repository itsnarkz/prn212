using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels
{
    public class AdminAddUserViewModel:ViewModel
    {
        private string _customerFullName;
        private string _telephone;
        private string _emailAddress;
        private DateOnly? _customerBirthday;
        private int _status;
        private string? _password;
        private CustomerService _customerService;
        public string CustomerFullName { get => _customerFullName; set => SetField(ref _customerFullName, value); }

        public string Telephone { get => _telephone; set => SetField(ref _telephone, value); }

        public string EmailAddress { get => _emailAddress; set => SetField(ref _emailAddress, value); }

        public DateOnly? CustomerBirthday { get => _customerBirthday; set => SetField(ref _customerBirthday, value); }

        public string? Password { get => _password; set => SetField(ref _password,value); }

        public int Status
        {
            get => _status;
            set => SetField(ref _status, value);
        }

        public ICommand Confirm { get; set; }
        public ICommand Cancel { get; set; }

        public AdminAddUserViewModel(Navigation navigation)
        {
            _customerService = new CustomerService();
            Confirm = new BaseCommand(() => DoConfirm(navigation));
            Cancel = new BaseCommand(() => DoCancel(navigation));
        }
        
        void DoConfirm(Navigation navigation)
        {
            _customerService.AddCustomer(_customerFullName, _telephone, _emailAddress, _customerBirthday, _status, _password);
            navigation.ViewModel = new UserManageViewModel(navigation);
        }

        void DoCancel(Navigation navigation)
        {
            navigation.ViewModel = new UserManageViewModel(navigation);
        }
    }
}
