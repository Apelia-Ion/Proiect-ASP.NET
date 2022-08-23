using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities


    //Add-Migration
    //Update-Database
{
    public class RecipesAppContext : DbContext
    {
        
      //  public RecipesAppContext(DbContextOptions<RecipesAppContext> options) : base(options) { }
        
        
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Chef> Chef { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<ChefRecipe> ChefRecipe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //Comment/Uncomment when not using/using lazy loading
                //.UseLazyLoadingProxies() 
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=RecipesDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            //one to one database relationship
            //un bucatar are o adresa
            builder.Entity<Chef>()
                .HasOne(c => c.Address)
                .WithOne(a => a.Chef);

            //One to many database relationship
            //o reteta are mai multe recenzii
            builder.Entity<Recipe>()
                .HasMany(a => a.Reviews)
                .WithOne(b => b.Recipe);

            //Many to many database relationship
            //mai multi bucatari pot adauga mai multe retete
            builder.Entity<ChefRecipe>().HasKey(cr => new { cr.ChefId, cr.RecipeId });

            builder.Entity<ChefRecipe>()
                .HasOne(cr => cr.Chef)
                .WithMany(c => c.ChefRecipe)
                .HasForeignKey(cr => cr.ChefId);

            builder.Entity<ChefRecipe>()
                .HasOne(cr => cr.Recipe)
                .WithMany(r => r.ChefRecipe)
                .HasForeignKey(cr => cr.RecipeId);
        


        }
  
    }
}
