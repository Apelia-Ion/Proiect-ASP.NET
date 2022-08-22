
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }

       
       // public virtual ICollection< Chef> Chefs { get; set; }
       
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<ChefRecipe> ChefRecipe { get; set; }

    }

}
