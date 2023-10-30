using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample1.Controllers
{

    [ApiController]
    public class Home : ControllerBase
    {
        [Route("hc2")]
        public IActionResult hc2()
        {
            return Ok();
        }
    }
}
