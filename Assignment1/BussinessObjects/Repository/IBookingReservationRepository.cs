using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public interface IBookingReservationRepository
    {
        public List<BookingReservation> GetAll();
        public BookingReservation GetBookingReservationById(int id);
        public void SaveBookingReservation(BookingReservation bookingReservation);

        public List<BookingReservation> GetAllByCustomerId(int id);
        public void UpdateBookingReservation(BookingReservation bookingReservation);
    }
}
