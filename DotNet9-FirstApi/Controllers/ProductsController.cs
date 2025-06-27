using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet9_FirstApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Http Get Request");
        }

        [HttpGet("Categories")]
        public IActionResult Get(int id) 
        {
            return Ok("Http Get Request (Categories)");
        }

        [HttpPost("add")]
        public IActionResult Create(int id)
        {
            return Ok("Http Post Request");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id)
        {
            return Ok("Http Put Request");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Http Delete Request");
        }

    }
}
