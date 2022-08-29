using RecipesApp.Entities;
using System.Linq;

namespace RecipesApp.Repositories
{
    public interface IReviewRepository
    {
        IQueryable<Review> GetReviewsIQueryable();
        void Create(Review review);
        void Update(Review review);
        void Delete(Review review);
    }
}
