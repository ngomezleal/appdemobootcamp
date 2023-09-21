using Microsoft.AspNetCore.Mvc;

namespace appdemobootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { id = 1, name = "nelson" });
        }
    }
}