using System.Web.Http;

namespace CustomMiddleware.Framework.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TestGet()
        {
            return Ok("Get");
        }

        [HttpPost]
        public IHttpActionResult TestPost()
        {
            return Ok("Post");
        }

        [HttpPut]
        public IHttpActionResult TestPut()
        {
            return Ok("Put");
        }

        [HttpDelete]
        public IHttpActionResult TestDelete()
        {
            return Ok("Delete");
        }
    }
}
