using HotelRoomManagementProject_LayeredArchitecture.Models;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public interface IRoomRepository
    {
        void AddRoom(Room room);
        void DeleteRoom(int id);
        List<Room> GetAllRooms();
        Room GetRoomById(int id);
        void UpdateRoom(Room room);
    }
}