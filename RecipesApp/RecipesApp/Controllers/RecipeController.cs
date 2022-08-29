using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Managers;
using RecipesApp.Models;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeManager manager;

        public RecipeController(IRecipeManager recipeManager)
        {
            this.manager = recipeManager;
        }

       
        // returneaza toate retetele din baza de date
        [HttpGet]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetRecipes()
        {

            var recipes = manager.GetRecipes();
            return Ok(recipes);
        }

        //returneaza o lista cu reteta a carui id a fost dat si review-urile acesteia
        [HttpGet("id")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetRecipeWithReviews([FromRoute] string id)
        {

            var recipes = manager.GetRecipeWithReviews(id);
            return Ok(recipes);
        }


        //adauga o noua reteta in baza de date
        [HttpPost()]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Create([FromBody] RecipeModel recipeModel)
        {
            manager.Create(recipeModel);

            return Ok();
        }

        //moddifica o reteta din baza de date
        [HttpPut]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Update([FromBody] RecipeModel recipeModel)
        {
            manager.Update(recipeModel);

            return Ok();
        }

        //sterge o reteda din baza de date pe baza unui id precizat
        [HttpDelete("{id}")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }
    }
}
