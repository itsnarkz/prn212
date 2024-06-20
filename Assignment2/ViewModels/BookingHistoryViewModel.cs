using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels;

public class BookingHistoryViewModel:ViewModel
{
    private readonly BookingReservationService _reservationService;
    public ObservableCollection<BookingReservation> Reservations { get; set; }
    public ICommand GoBack { get; set; }
    public BookingHistoryViewModel(Customer customer,Navigation navigation)
    {
        _reservationService = new BookingReservationService();
        Reservations = new ObservableCollection<BookingReservation>(_reservationService.GetByUser(customer.CustomerId));
        GoBack = new BaseCommand(() => DoGoBack(customer, navigation));
    }
    void DoGoBack(Customer customer,Navigation navigation)
    {
        navigation.ViewModel = new UserProfileViewModel(customer,navigation);
    }
}