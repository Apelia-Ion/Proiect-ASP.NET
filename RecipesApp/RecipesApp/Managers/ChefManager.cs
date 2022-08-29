
using RecipesApp.Entities;
using RecipesApp.Models;
using RecipesApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Managers
{
    public class ChefManager : IChefManager
    {
        private readonly IChefRepository chefRepository;

        public ChefManager(IChefRepository chefRepository)
        {
            this.chefRepository = chefRepository;
        }
        public List<Chef> GetChefs()
        {
            return chefRepository.GetChefsIQueryable().ToList();
        }
        public List<string> GetChefIdsList()
        {
            var chefs = chefRepository.GetChefsIQueryable();
            var idList = chefs.Select(x => x.Id)
                .ToList();

            return idList;
        }

        public List<Chef> GetChefWithRecipes()
        {
            var chefWithRecipes = chefRepository.ChefWithRecipes();

            return chefWithRecipes.ToList();
        }

        public Chef GetChefById(string id)
        {
            var chef = chefRepository.GetChefsIQueryable()
                .FirstOrDefault(x => x.Id == id);

            return chef;
        }

        public void Create(ChefModel model)
        {
            var newChef = new Chef
            {
                Id = model.Id,
                Name = model.Name,
                Description=model.Description,
                CulinarySchool=model.CulinarySchool
            };

            chefRepository.Create(newChef);
        }
        public void Update(ChefModel model)
        {
            var chef = GetChefById(model.Id);

            chef.Name = model.Name;
            chef.Description = model.Description;
            chef.CulinarySchool = model.CulinarySchool;
            chefRepository.Update(chef);
            
        }

        public void Delete(string id)
        {
            var chef = GetChefById(id);

            chefRepository.Delete(chef);
        }
    }
}
