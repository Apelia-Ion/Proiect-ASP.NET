
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Review
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public string ChefId { get; set; }
        public virtual Chef Chef { get; set; }
        
        public string RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

    }
}
