using Assignment1PRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment1PRN.Command;
using Assignment1PRN.Util;
using Assignment1PRN.Views;

namespace Assignment1PRN.ViewModels
{
    public class UserProfileViewModel:ViewModel
    {
        private Customer _customer;
        public ICommand EditProfile { get; set; }
        public ICommand ViewBooking { get; set; }
        public ICommand Logout { get; set; }
        public Customer Customer { get => _customer; set => SetField(ref _customer,value); }
        public UserProfileViewModel(Customer customer,Navigation navigation)
        {
            Customer = customer;
            EditProfile = new BaseCommand(()=>ToEditProfile(customer,navigation));
            ViewBooking = new BaseCommand(() => ToViewBooking(customer,navigation));

            Logout = new BaseCommand(() => DoLogout(navigation));
        }

        private void ToEditProfile(Customer customer, Navigation navigation)
        {
            EditProfileWindow editProfileWindow = new EditProfileWindow();
            navigation.ViewModel = new EditProfileViewModel(customer,navigation);
        }

        private void ToViewBooking(Customer customer, Navigation navigation)
        {
            navigation.ViewModel = new BookingHistoryViewModel(customer,navigation);
        }

        private void DoLogout(Navigation navigation)
        {
            navigation.ViewModel = new LoginPageViewModel(navigation);
        }
    }
}
