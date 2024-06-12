using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Repository;
using HE181099_Assignment1.Models;

namespace BussinessObjects.ViewModel
{
    public class BookingReservationViewModel
    {
        public static readonly BookingReservationViewModel Instance;
        public ObservableCollection<BookingReservation> Bookings { get; private set; }
        static BookingReservationViewModel()
        {
            if (Instance==null) Instance = new BookingReservationViewModel();
        }
        public void LoadBookingReservation()
        {
            Bookings = new ObservableCollection<BookingReservation>(new BookingReservationRepository().GetAll());
        }
    }
}
