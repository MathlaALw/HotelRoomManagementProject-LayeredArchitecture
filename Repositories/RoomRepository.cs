using HotelRoomManagementProject_LayeredArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public class RoomRepository
    {

        private readonly HotelDbContext _context; // private field to hold the database context
        public RoomRepository(HotelDbContext context) // constructor that takes a HotelDbContext object as a parameter
        {
            _context = context; // initialize the context with the provided context
        }

        // Method to add a new room

        public void AddRoom(Room room)
        {
            _context.rooms.Add(room); // add the room to the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to get all rooms
        public List<Room> GetAllRooms()
        {
            return _context.rooms.ToList(); // return all rooms from the context
        }

        // Method to get a room by ID
        public Room GetRoomById(int id)
        {
            return _context.rooms.Find(id); // find the room by ID
        }


        // Method to update a room
        public void UpdateRoom(Room room)
        {
            _context.rooms.Update(room); // update the room in the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to delete a room

        public void DeleteRoom(int id)
        {
            var room = _context.rooms.Find(id); // find the room by ID
            if (room != null) // check if the room exists
            {
                _context.rooms.Remove(room); // remove the room from the context
                _context.SaveChanges(); // save changes to the database
            }
        }



        }
}
