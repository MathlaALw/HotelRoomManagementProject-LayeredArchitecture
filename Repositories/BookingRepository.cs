using HotelRoomManagementProject_LayeredArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public class BookingRepository : IBookingRepository
    {

        private readonly HotelDbContext _context; // private field to hold the database context
        public BookingRepository(HotelDbContext context) // constructor that takes a HotelDbContext object as a parameter
        {
            _context = context; // initialize the context with the provided context
        }


        // Method to add a new booking
        public void AddBooking(Booking booking)
        {
            _context.bookings.Add(booking); // add the booking to the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to get all bookings

        public List<Booking> GetAllBookings()
        {
            return _context.bookings.ToList(); // return all bookings from the context
        }

        // Method to get a booking by ID

        public Booking GetBookingById(int id)
        {
            return _context.bookings.Find(id); // find the booking by ID
        }

        // Method to update a booking

        public void UpdateBooking(Booking booking)
        {
            _context.bookings.Update(booking); // update the booking in the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to delete a booking

        public void DeleteBooking(int id)
        {
            var book = _context.bookings.Find(id); // find the guest by ID
            if (book != null)
            {
                _context.bookings.Remove(book); // remove the booking from the context
                _context.SaveChanges(); // save changes to the database
            }
        }

    }
}
