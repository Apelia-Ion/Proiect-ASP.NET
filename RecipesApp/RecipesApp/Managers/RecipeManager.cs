using RecipesApp.Entities;
using RecipesApp.Models;
using RecipesApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RecipesApp.Managers
{
    public class RecipeManager : IRecipeManager
    {
        private readonly IRecipeRepository recipeRepository;
        public RecipeManager(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }
        public List<Recipe> GetRecipes()
        {
            return recipeRepository.GetRecipesIQueryable().ToList();
        }
        public Recipe GetRecipeById(string id)
        {
            var recipe = recipeRepository.GetRecipesIQueryable()
                .FirstOrDefault(x => x.Id == id);

            return recipe;
        }

        public List<Recipe> GetRecipeWithReviews(string id)
        {
            var recipeWithReviews = recipeRepository.GetRecipeWithReviews().Where(r => r.Id.Equals(id));

            return recipeWithReviews.ToList();
        }


        public void Create(RecipeModel model)
        {
            var newRecipe = new Recipe
            {
                Id = model.Id,
                Title = model.Title,
                Ingredients = model.Ingredients,
                Description = model.Description,
                Steps = model.Steps
            };

            recipeRepository.Create(newRecipe);
        }
        public void Update(RecipeModel model)
        {
            var recipe = GetRecipeById(model.Id);

            recipe.Id=model.Id;
            recipe.Title=model.Title;
            recipe.Ingredients=model.Ingredients;
            recipe.Description=model.Description;
            recipe.Steps=model.Steps;
            recipeRepository.Update(recipe);

        }

        public void Delete(string id)
        {
            var recipe = GetRecipeById(id);

            recipeRepository.Delete(recipe);
        }
    }
}
