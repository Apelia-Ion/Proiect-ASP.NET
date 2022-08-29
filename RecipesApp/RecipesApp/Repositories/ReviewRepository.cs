using RecipesApp.Entities;
using RecipesApp.Repositories;
using System.Linq;

namespace RecipesApp.Repositories
{
   
        public class ReviewRepository : IReviewRepository
        {

            private RecipesAppContext db;
            public ReviewRepository(RecipesAppContext db)
            {
                this.db = db;
            }

            public IQueryable<Review> GetReviewsIQueryable()
            {
                var reviews = db.Review;

                return reviews;
            }

            public void Create(Review review)
            {
                db.Review.Add(review);

                db.SaveChanges();
            }

            public void Update(Review review)
            {
                db.Review.Update(review);

                db.SaveChanges();
            }

            public void Delete(Review review)
            {
                db.Review.Remove(review);

                db.SaveChanges();
            }


        }
    
}
