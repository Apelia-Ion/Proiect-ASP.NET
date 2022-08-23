
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Address
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string ChefId { get; set; }
        public virtual Chef Chef { get; set; }


    }
}

