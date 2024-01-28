using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nerwork.web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet("GetOll")]
        public IActionResult  GetOll()
        {
            var News = new
            {
                Title = "test",
                Descritions = "dfsd",
                Text = "test"
            };
            return Ok();
        }
    }
}
