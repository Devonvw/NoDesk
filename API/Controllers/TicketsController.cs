using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
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
        public IActionResult DeleteTicket(string id)
        {
            try
            {
                ticketCRUDDAO.DeleteTicket(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)));
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to delete ticket" }); }
        }

        [HttpPost]
        public IActionResult CreateTicket([FromBody]object incidentTicket)
        {
            try
            {
                IncidentTicket ticket = BsonSerializer.Deserialize<IncidentTicket>(((JsonElement)incidentTicket).GetRawText());

                ticketCRUDDAO.CreateTicket(IncidentTicketToBson(ticket));
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to create ticket" }); }
        }

        [HttpPut]
        public IActionResult UpdateTicket([FromBody] object incidentTicket)
        {
            try
            {
                IncidentTicket ticket = BsonSerializer.Deserialize<IncidentTicket>(((JsonElement)incidentTicket).GetRawText());

                ticketCRUDDAO.UpdateTicket(IncidentTicketToBson(ticket), Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(ticket._id)));
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to update ticket" }); }
        }

        [HttpGet]
        [Route("past-deadline")]
        public IActionResult GetIncidentsPastDeadline()
        {
            try
            {
                return StatusCode(200, new {incidents = ticketCRUDDAO.GetIncidentsPastDeadline()});
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve incidents" }); }
        }

        [HttpGet]
        [Route("unresolved")]
        public IActionResult GetUnresolvedIncidents()
        {
            try
            {
                (int total, int unresolved) = ticketCRUDDAO.GetUnresolvedIncidents();
                return StatusCode(200, new { total = total, unresolved = unresolved });
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve unresolved incidents" }); }
        }

        [HttpGet]
        public IActionResult ReadTicketList()
        {
            try
            {
                List<IncidentTicket> incidentTickets = new List<IncidentTicket>();
                foreach (BsonDocument bsonDocument in ticketCRUDDAO.GetTicketList(Builders<BsonDocument>.Filter.Eq("resolved", false)))
                {
                    incidentTickets.Add(new IncidentTicket(bsonDocument));
                }
                return StatusCode(200, new { tickets = incidentTickets });
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve tickets" }); }
        }

        [HttpGet]
        [Route("{input}")]
        public IActionResult GetAllTicketsBasedOnSearch(string input)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Regex("subject", new BsonRegularExpression(input));
                filter |= Builders<BsonDocument>.Filter.Regex("description", new BsonRegularExpression(input));
                filter &= Builders<BsonDocument>.Filter.Eq("resolved", false);

                List<IncidentTicket> incidentTickets = new List<IncidentTicket>();

                foreach (BsonDocument doc in ticketCRUDDAO.GetAllTicketsBasedOnSearch(filter))
                {
                    incidentTickets.Add(new IncidentTicket(doc));
                }

                return StatusCode(200, new { tickets = incidentTickets });
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve tickets" }); }
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