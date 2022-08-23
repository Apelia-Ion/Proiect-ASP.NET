
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Chef
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CulinarySchool { get; set; }

        public virtual Address Address { get; set; }
        
        public virtual ICollection<ChefRecipe> ChefRecipe { get; set; }
    }
}
