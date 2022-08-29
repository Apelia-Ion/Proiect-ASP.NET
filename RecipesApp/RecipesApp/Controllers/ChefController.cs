using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Managers;
using RecipesApp.Models;
using System.Linq;
using System.Threading.Tasks;


namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly IChefManager manager;

        public ChefController(IChefManager chefManager)
        {
            this.manager = chefManager;
        }


        // returneaza toti bucatarii din baza de date
        [HttpGet]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetChefs()
        {

            var chefs = manager.GetChefs();
            return Ok(chefs);
        }

        //returneasza toate id-urile bucatatirilor din baza de date
        //eager-loading
        [HttpGet("select-id")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetIds()
        {
            var idList = manager.GetChefIdsList();

            return Ok(idList);
        }

        //returneaza o lista cu bucatarii si retetele acestora [(bucatar, reteta)]
        [HttpGet("Chef&Recipe")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> JoinEager()
        {
            var chefWithRecipes = manager.GetChefWithRecipes();

            return Ok(chefWithRecipes);
        }

        //returneaza un bucatar pe baza id-ului acestuia
        [HttpGet("byId/{id}")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var chef = manager.GetChefById(id);

            return Ok(chef);
        }

        //adauga un nou bucatar in baza de date conform informatiilor introduse de user
        [HttpPost()]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Create([FromBody] ChefModel chefModel)
        {
            manager.Create(chefModel);

            return Ok();
        }

        [HttpPut]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Update([FromBody] ChefModel chefModel)
        {
            manager.Update(chefModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }

    }
}
