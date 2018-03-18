using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Core.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult TestGet()
        {
            return Ok("Get");
        }

        [HttpPost]
        public IActionResult TestPost()
        {
            return Ok("Post");
        }

        [HttpPut]
        public IActionResult TestPut()
        {
            return Ok("Put");
        }

        [HttpDelete]
        public IActionResult TestDelete()
        {
            return Ok("Delete");
        }
    }
}
