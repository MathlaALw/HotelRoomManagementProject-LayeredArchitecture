using HotelRoomManagementProject_LayeredArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Repositories
{
    public class ReviewRepository : IReviewRepository
    {

        private readonly HotelDbContext _context; // private field to hold the database context
        public ReviewRepository(HotelDbContext context) // constructor that takes a HotelDbContext object as a parameter
        {
            _context = context; // initialize the context with the provided context
        }

        // Method to add a new review
        public void AddReview(Review review)
        {
            _context.reviews.Add(review); // add the review to the context
            _context.SaveChanges(); // save changes to the database
        }
        // Method to get all reviews
        public List<Review> GetAllReviews()
        {
            return _context.reviews.ToList(); // return all reviews from the context
        }

        // Method to get a review by ID

        public Review GetReviewById(int id)
        {
            return _context.reviews.Find(id); // find the review by ID
        }

        // Method to update a review

        public void UpdateReview(Review review)
        {
            _context.reviews.Update(review); // update the review in the context
            _context.SaveChanges(); // save changes to the database
        }

        // Method to delete a review

        public void DeleteReview(int id)
        {
            var review = _context.reviews.Find(id); // find the review by ID
            if (review != null) // check if the review exists
            {
                _context.reviews.Remove(review); // remove the review from the context
                _context.SaveChanges(); // save changes to the database
            }

        }

    }
}
