using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TicketsController : ControllerBase
    {
        private TicketCRUDDAO ticketCRUDDAO;
        public TicketsController()
        {
            ticketCRUDDAO = new TicketCRUDDAO();
        }

        [HttpGet]
        [Route("past-deadline")]
        public int GetIncidentsPastDeadline()
        {
            return ticketCRUDDAO.GetIncidentsPastDeadline();
        }

        [HttpGet]
        [Route("unresolved")]
        public Tuple<int,int> GetUnresolvedIncidents()
        {
            (int total, int unresolved) data =  ticketCRUDDAO.GetUnresolvedIncidents();
            return new Tuple<int, int>(data.total, data.unresolved);
        }
    }
}