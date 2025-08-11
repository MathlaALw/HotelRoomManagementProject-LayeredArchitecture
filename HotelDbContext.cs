using HotelRoomManagementProject_LayeredArchitecture.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelRoomManagementProject_LayeredArchitecture
{
    class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=BankingDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Guest> guests { get; set; }
        public DbSet<Room>  rooms { get; set; }

        public DbSet<Booking> bookings { get; set; }

        public DbSet<Review> reviews { get; set; }

    }
}
