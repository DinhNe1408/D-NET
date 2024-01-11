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

        [HttpGet("Demo1")]
        public async Task<IActionResult> Demo1(){
            var result = await _service.Demo1();
            return Ok(result);
        }

        [HttpGet("Demo2")]
        public async Task<IActionResult> Demo2(){
            var result = await _service.Demo2();
            return Ok(result);
        }
    }
}