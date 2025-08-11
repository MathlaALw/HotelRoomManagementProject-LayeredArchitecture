using HotelRoomManagementProject_LayeredArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public class GuestRepository : IGuestRepository
    {
   
        private readonly HotelDbContext _context; // private field to hold the database context
        public GuestRepository(HotelDbContext context) // constructor that takes a HotelDbContext object as a parameter
        {
            _context = context; // initialize the context with the provided context
        }




        // Method to add a new guest
        public void AddGuest(Guest guest)
        {
            _context.guests.Add(guest); // add the guest to the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to get all guests
        public List<Guest> GetAllGuests()
        {
            return _context.guests.ToList(); // return all guests from the context
        }


        // Method to get a guest by ID
        public Guest GetGuestById(int id)
        {
            return _context.guests.Find(id); // find the guest by ID
        }


        // Method to update a guest
        public void UpdateGuest(Guest guest)
        {
            _context.guests.Update(guest); // update the guest in the context
            _context.SaveChanges(); // save changes to the database

        }

        // Method to delete a guest
        public void DeleteGuest(int id)
        {
            var guest = _context.guests.Find(id); // find the guest by ID
            if (guest != null) // check if the guest exists
            {
                _context.guests.Remove(guest); // remove the guest from the context
                _context.SaveChanges(); // save changes to the database
            }

        }
    }
}
