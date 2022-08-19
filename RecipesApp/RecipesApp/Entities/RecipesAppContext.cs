using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class RecipesAppContext : DbContext
    {
        public RecipesAppContext (DbContextOptions<RecipesAppContext> options) : base(options) { }
        public DbSet<Adress> Adresses { get; set; }

    }
}
