using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HE181099_Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace BussinessObjects.Models
{
    public class MyDbContext:FuminiHotelManagementContext
    {
        public DbSet<RoomInformation> RoomInformations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<BookingReservation> Bookings { get; set; }
        public DbSet<BookingDetail> BookingsDetails { get; set; }

    }
}
