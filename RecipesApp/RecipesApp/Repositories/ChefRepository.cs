
using RecipesApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories
{
    public class ChefRepository : IChefRepository
    {
        private RecipesAppContext db;
        public ChefRepository(RecipesAppContext db)
        {
            this.db = db;
        }

        public IQueryable<Chef> GetChefsIQueryable()
        {
            var chefs = db.Chef;

            return chefs;
        }
        public IQueryable<Chef> ChefWithRecipes()
        {
            var chefWithRecipes= db.Chef
                .Include(c => c.ChefRecipe)
                .ThenInclude(r => r.Recipe)
                .AsNoTracking(); 

            return chefWithRecipes;
        }

        public void Create(Chef chef)
        {
            db.Chef.Add(chef);

            db.SaveChanges();
        }

        public void Update(Chef chef)
        {
            db.Chef.Update(chef);

            db.SaveChanges();
        }

        public void Delete(Chef chef)
        {
            db.Chef.Remove(chef);

            db.SaveChanges();
        }
    }
}
 
