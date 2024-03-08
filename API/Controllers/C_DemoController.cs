using API._Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class C_DemoController : ControllerBase
    {
       private readonly I_Demo _service;

        public C_DemoController(I_Demo service)
        {
            _service = service;
        }

        [HttpGet("Demo")]
        public async Task<IActionResult> Demo(){
            var result = await _service.Demo();
            return Ok(result);
        }
    }
}