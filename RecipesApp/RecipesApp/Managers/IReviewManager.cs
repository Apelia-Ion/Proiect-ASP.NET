using RecipesApp.Entities;
using RecipesApp.Models;
using System.Collections.Generic;

namespace RecipesApp.Managers
{
    public interface IReviewManager
    {
        List<Review> GetReviews();
        Review GetReviewById(string id);
        void Create(ReviewModel model);
        void Update(ReviewModel model);
        void Delete(string id);
    }
}
