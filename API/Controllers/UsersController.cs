using DAL;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private TicketCRUDDAO ticketCRUDDAO;
        public UsersController()
        {
            //ticketCRUDDAO = new TicketCRUDDAO();
        }
    }
}
