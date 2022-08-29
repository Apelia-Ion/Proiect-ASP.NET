using RecipesApp.Entities;
using System.Linq;

namespace RecipesApp.Repositories
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> GetRecipesIQueryable();
        IQueryable<Recipe> GetRecipeWithReviews();
        void Create(Recipe recipe);
        void Update (Recipe recipe);
        void Delete(Recipe recipe);
    }
}
