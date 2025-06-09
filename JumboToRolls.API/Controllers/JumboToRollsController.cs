using JumboToRolls.API.DTOs;
using JumboToRolls.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JumboToRolls.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JumboToRollsController : ControllerBase
    {
        private readonly IJumboToRollsCalculator _service;

        public JumboToRollsController(IJumboToRollsCalculator service)
        {
            _service = service;
        }
        
        [HttpPost(Name = "calculate-from-jumbo")]
        public IActionResult CalculateFromJumbo([FromBody] JumboCalculationRequest request)
        {
            return Ok();
        }

        [HttpPost(Name = "calculate-from-snapoff")]
        public IActionResult CalculateFromSnapoff([FromBody] SnapoffCalculationRequest request)
        {
            return Ok();
        }
    }
}
