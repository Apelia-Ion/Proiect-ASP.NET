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
        public virtual Adress Adress { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
