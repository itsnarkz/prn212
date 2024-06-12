using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Models;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        public List<BookingReservation> GetAll()
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    List<BookingReservation> list = dbContext.BookingReservations.ToList();
                    foreach (BookingReservation reservation in list) {
                        reservation.BookingDetails = dbContext.BookingDetails.Where(d=>(d.BookingReservationId == reservation.BookingReservationId)).ToList();
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    throw new Exception("RI repo :" + ex.Message);
                }
            }
        }

        public BookingReservation GetBookingReservationById(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    BookingReservation reserv = dbContext.BookingReservations.SingleOrDefault(d=>d.BookingReservationId==id);
                    if (reserv == null) return null;
                    List<BookingDetail> details = dbContext.BookingDetails.Where(
                        d => (d.BookingReservationId == reserv.BookingReservationId)
                        ).ToList();
                    foreach (BookingDetail detail in details)
                    {
                        detail.Room = dbContext.RoomInformations.SingleOrDefault(
                            r => r.RoomId == detail.RoomId);
                    }
                    reserv.BookingDetails = details;
                    return reserv;
                }
                catch (Exception ex)
                {
                    throw new Exception("RI repo :" + ex.Message);
                }
            }
        }

        public void SaveBookingReservation(BookingReservation bookingReservation)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    dbContext.BookingReservations.Add(bookingReservation);
                    foreach (BookingDetail detail in bookingReservation.BookingDetails)
                    {
                        dbContext.BookingDetails.Add(detail);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("RI repo :" + ex.Message);
                }
            }
        }

        public List<BookingReservation> GetAllByCustomerId(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    List<BookingReservation> list = dbContext.BookingReservations.Where(c=>c.CustomerId==id).ToList();
                    foreach (BookingReservation reservation in list)
                    {
                        reservation.BookingDetails = dbContext.BookingDetails.Where(d => (d.BookingReservationId == reservation.BookingReservationId)).ToList();
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    throw new Exception("RI repo :" + ex.Message);
                }
            }
        }

        public void UpdateBookingReservation(BookingReservation bookingReservation)
        {
            throw new NotImplementedException();
        }
    }
}
