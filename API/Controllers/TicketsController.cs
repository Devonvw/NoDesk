using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [Route("api/tickets")]
        public string Get()
        {
            return "kaas";
        }
    }
}