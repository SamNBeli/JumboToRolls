using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JumboToRolls.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JumboToRollsController : ControllerBase
    {
        [HttpGet(Name = "HelloWorld")]
        public IActionResult Get()
        {
            return Ok("This is jumbo to roll");
        }
    }
}
