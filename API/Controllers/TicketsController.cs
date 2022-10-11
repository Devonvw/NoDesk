using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.Diagnostics;
using System.Net;
using System.Text.Json;


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

        [HttpDelete]
        [Route("{id}")]
        public void DeleteTicket(string id)
        {
            ticketCRUDDAO.DeleteTicket(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)));
        }

        [HttpPost]
        public void CreateTicket([FromBody]IncidentTicket incidentTicket)
        {
            //BsonDocument.Parse(((JsonElement)incidentTicket).GetRawText())
            ticketCRUDDAO.CreateTicket(IncidentTicketToBson(incidentTicket));
        }

        [HttpPut]
        public void UpdateTicket([FromBody]IncidentTicket incidentTicket)
        {
            ticketCRUDDAO.UpdateTicket(IncidentTicketToBson(incidentTicket), Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(incidentTicket._Id)));
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

        [HttpGet]
        public List<IncidentTicket> ReadTicketList()
        {
            List<IncidentTicket> incidentTickets = new List<IncidentTicket>();
            foreach (BsonDocument bsonDocument in ticketCRUDDAO.GetTicketList(Builders<BsonDocument>.Filter.Eq("resolved", false)))
            {
                incidentTickets.Add(new IncidentTicket(bsonDocument));
            }
            return incidentTickets;
        }

        [HttpGet]
        [Route("{input}")]
        public List<IncidentTicket> GetAllTicketsBasedOnSearch(string input)
        {
            var filter = Builders<BsonDocument>.Filter.Regex("subject", new BsonRegularExpression(input));
            filter |= Builders<BsonDocument>.Filter.Regex("description", new BsonRegularExpression(input));
            filter &= Builders<BsonDocument>.Filter.Eq("resolved", false);

            List<IncidentTicket> incidentTickets = new List<IncidentTicket>();

            foreach (BsonDocument doc in ticketCRUDDAO.GetAllTicketsBasedOnSearch(filter))
            {
                incidentTickets.Add(new IncidentTicket(doc));
            }

            return incidentTickets;
        }
        private BsonDocument IncidentTicketToBson(IncidentTicket incidentTicket)
        {
            Debug.WriteLine(incidentTicket?.subject);
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", incidentTicket.reportedDate },
                {"subject", incidentTicket.subject },
                {"type", incidentTicket.type },
                {"user", incidentTicket.user },
                {"priority", incidentTicket.priority },
                {"description", incidentTicket.description },
                {"resolved", incidentTicket.resolved },
                {"deadline", incidentTicket.deadline }
            };
            return newBsonDocument;
        }
    }
}