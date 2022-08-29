using RecipesApp.Entities;
using RecipesApp.Managers;
using RecipesApp.Models;
using RecipesApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RecipesApp.Managers
{
    public class ReviewManager : IReviewManager
    {
        private readonly IReviewRepository reviewRepository;
        public ReviewManager(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }
        public List<Review> GetReviews()
        {
            return reviewRepository.GetReviewsIQueryable().ToList();
        }
        public Review GetReviewById(string id)
        {
            var review = reviewRepository.GetReviewsIQueryable()
                .FirstOrDefault(x => x.Id == id);

            return review;
        }
        public void Create(ReviewModel model)
        {
            var newReview = new Review
            {
                Id = model.Id,
                Comment = model.Comment,
                Rating = model.Rating
            };

            reviewRepository.Create(newReview);
        }
        public void Update(ReviewModel model)
        {
            var review = GetReviewById(model.Id);

            review.Id = model.Id;
            review.Comment = model.Comment;
            review.Rating = model.Rating;
            reviewRepository.Update(review);

        }

        public void Delete(string id)
        {
            var review = GetReviewById(id);

            reviewRepository.Delete(review);
        }
    }
}
