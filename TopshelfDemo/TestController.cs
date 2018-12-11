using System.Web.Http;

namespace JWTTest
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
