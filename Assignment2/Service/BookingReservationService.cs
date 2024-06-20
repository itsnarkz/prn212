using Assignment1PRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.Service
{
    public class BookingReservationService
    {
        public BookingReservationService() { }
        public List<BookingReservation> GetByUser(int userId)
        {
            return FuminiHotelManagementContext.Instance().BookingReservations.Where(br=>br.CustomerId == userId).ToList();
        }
    }
}
