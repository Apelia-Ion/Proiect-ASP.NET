using RecipesApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {

        private RecipesAppContext db;
        public RecipeRepository(RecipesAppContext db)
        {
            this.db = db;
        }

        public IQueryable<Recipe> GetRecipesIQueryable()
        {
            var recipes = db.Recipes;

            return recipes;
        }

        
            public IQueryable<Recipe> GetRecipeWithReviews()
        {
            var recipeWithReviews = db.Recipes
                .Include(r => r.Reviews)
                .AsNoTracking();

            return recipeWithReviews;
        }
        public void Create(Recipe recipe)
        {
            db.Recipes.Add(recipe);

            db.SaveChanges();
        }

        public void Update(Recipe recipe)
        {
            db.Recipes.Update(recipe);

            db.SaveChanges();
        }

        public void Delete(Recipe recipe)
        {
            db.Recipes.Remove(recipe);

            db.SaveChanges();
        }
    }
}
