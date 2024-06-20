using Assignment1PRN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.Service
{
    public class Report
    {
        public string CustomerFullName { get; set; }
        public string EmailAddress { get; set; }
        public DateOnly? BookingDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public int RoomID { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public Report(string customerFullName, string emailAddress, DateOnly? bookingDate, decimal? totalPrice, int roomID, DateOnly startDate, DateOnly endDate)
        {
            CustomerFullName = customerFullName;
            EmailAddress = emailAddress;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
        public class ReportService
    {
        FuminiHotelManagementContext repository = FuminiHotelManagementContext.Instance();
        public List<Report> GetAllReports()
        {
            List<BookingDetail> detailList = repository.BookingDetails.Include(c=>c.BookingReservation).ThenInclude(c=>c.Customer).ToList();
            List<Report> list = detailList.Select(d=>new Report(
                d.BookingReservation.Customer.CustomerFullName,
                d.BookingReservation.Customer.EmailAddress,
                d.BookingReservation.BookingDate,
                d.BookingReservation.TotalPrice,
                d.RoomId,
                d.StartDate,
                d.EndDate
                )).ToList();
            return list;
        }

        public List<Report> ReportsWithinDate(DateOnly startDate, DateOnly endDate)
        {
            return GetAllReports().Where(r=>r.BookingDate >= startDate && r.BookingDate <= endDate).ToList();
        }
    }
}
