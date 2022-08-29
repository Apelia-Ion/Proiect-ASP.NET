

using RecipesApp.Entities;
using RecipesApp.Models;
using System.Collections.Generic;
namespace RecipesApp.Managers
{
    public interface IRecipeManager
    {
        List<Recipe> GetRecipes();
        Recipe GetRecipeById(string id);
        List<Recipe> GetRecipeWithReviews(string id);
        void Create(RecipeModel model);
        void Update(RecipeModel model);
        void Delete(string id);
    }
}
