using Microsoft.AspNetCore.Mvc;
using ValidationInterface.Model;

namespace ValidationInterface.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] IFruit fruit)
        {

            return Ok(ModelState.IsValid);
        }
    }
}