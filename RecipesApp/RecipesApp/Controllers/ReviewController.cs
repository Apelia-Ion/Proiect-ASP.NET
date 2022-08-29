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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewManager manager;

        public ReviewController(IReviewManager reviewManager)
        {
            this.manager = reviewManager;
        }


        // returneaza toate retetele din baza de date
        [HttpGet]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> GetReviews()
        {

            var reviews = manager.GetReviews();
            return Ok(reviews);
        }


        [HttpPost()]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Create([FromBody] ReviewModel reviewModel)
        {
            manager.Create(reviewModel);

            return Ok();
        }

        [HttpPut]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Update([FromBody] ReviewModel reviewModel)
        {
            manager.Update(reviewModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Chef")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }
    }
}
