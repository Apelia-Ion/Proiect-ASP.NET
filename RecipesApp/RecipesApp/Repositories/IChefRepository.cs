using RecipesApp.Entities;
using System.Linq;

namespace RecipesApp.Repositories
{
    public interface IChefRepository
    {
        IQueryable<Chef> GetChefsIQueryable();
        IQueryable<Chef> ChefWithRecipes();
        void Create(Chef chef);
        void Update(Chef chef);
        void Delete(Chef chef);

    }
}
