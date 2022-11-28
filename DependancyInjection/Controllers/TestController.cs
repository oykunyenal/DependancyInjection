using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependancyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {

            return "OK";

        }

    }
}
