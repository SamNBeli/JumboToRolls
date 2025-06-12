using JumboToRolls.API.DTOs;
using JumboToRolls.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JumboToRolls.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JumboToRollsController : ControllerBase
    {
        private readonly IJumboToRollsCalculator _service;

        public JumboToRollsController(IJumboToRollsCalculator service)
        {
            _service = service;
        }
        
        [HttpGet(Name = "Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }
        
        [HttpPost(Name = "calculate-from-jumbo")]
        public IActionResult CalculateFromJumbo([FromBody] JumboCalculationRequest request)
        {
            var result = _service.CalculateFromJumbo(request.JumboPaperRadius, request.CoreType);
            return Ok(result);
        }
        
        // [HttpPost(Name = "calculate-from-snapoff")]
        // public IActionResult CalculateFromSnapoff([FromBody] SnapoffCalculationRequest request)
        // {
        //     return Ok();
        // }
    }
}
