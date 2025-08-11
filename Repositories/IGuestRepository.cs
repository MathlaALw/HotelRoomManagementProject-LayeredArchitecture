using HotelRoomManagementProject_LayeredArchitecture.Models;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public interface IGuestRepository
    {
        void AddGuest(Guest guest);
        void DeleteGuest(int id);
        List<Guest> GetAllGuests();
        Guest GetGuestById(int id);
        void UpdateGuest(Guest guest);
    }
}