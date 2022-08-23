using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChefs()
        {
            var db = new RecipesAppContext();
            var chefs = db.Chef.ToList();
            return Ok(chefs);
        }

    }
}
