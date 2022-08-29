using RecipesApp.Entities;
using RecipesApp.Models;
using System.Collections.Generic;

namespace RecipesApp.Managers
{
    public interface IChefManager
    {
        List<Chef> GetChefs();
        List<string> GetChefIdsList();
        List<Chef> GetChefWithRecipes();
        Chef GetChefById(string id);
        void Create(ChefModel model);
        void Update(ChefModel model);
        void Delete(string id);
    }
}
