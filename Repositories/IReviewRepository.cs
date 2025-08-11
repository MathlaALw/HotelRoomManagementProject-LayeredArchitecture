using HotelRoomManagementProject_LayeredArchitecture.Models;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
        void DeleteReview(int id);
        List<Review> GetAllReviews();
        Review GetReviewById(int id);
        void UpdateReview(Review review);
    }
}