using System.Web.Http;

namespace TopshelfDemo
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [HttpPost]
        [Route("test")]
        public IHttpActionResult Test()
        {
            return Ok("well done");
        }
    }
}
