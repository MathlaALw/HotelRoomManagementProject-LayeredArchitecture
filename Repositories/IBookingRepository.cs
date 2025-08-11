using HotelRoomManagementProject_LayeredArchitecture.Models;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        void DeleteBooking(int id);
        List<Booking> GetAllBookings();
        Booking GetBookingById(int id);
        void UpdateBooking(Booking booking);
    }
}