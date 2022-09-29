using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Controller
{
    public class TicketCRUDController
    {
        private TicketCRUDDAO ticketCRUDDAO;
        public TicketCRUDController()
        {
            ticketCRUDDAO = new TicketCRUDDAO();
        }

        public void DeleteTicket(string id)
        {
            ticketCRUDDAO.DeleteTicket(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)));
        }
        public void CreateTicket(IncidentTicket incidentTicket)
        {
            ticketCRUDDAO.CreateTicket(IncidentTicketToBson(incidentTicket));
        }

        public void UpdateTicket(IncidentTicket incidentTicket)
        {
            ticketCRUDDAO.UpdateTicket(IncidentTicketToBson(incidentTicket), Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(incidentTicket.Id)));
        }

        public List<IncidentTicket> ReadTicketList()
        {
            List<IncidentTicket> incidentTickets = new List<IncidentTicket>();
            foreach (BsonDocument bsonDocument in ticketCRUDDAO.GetTicketList(Builders<BsonDocument>.Filter.Eq("resolved", false)))
            {
                incidentTickets.Add(new IncidentTicket(bsonDocument));
            }
            return incidentTickets;
        }

        public (int resolved, int unresolved) GetUnresolvedIncidents()
        {
            return ticketCRUDDAO.GetUnresolvedIncidents();
        }
        public int GetIncidentsPastDeadline()
        {
            return ticketCRUDDAO.GetIncidentsPastDeadline();
        }

        private BsonDocument IncidentTicketToBson(IncidentTicket incidentTicket)
        {
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", incidentTicket.dateTimeReported },
                {"subject", incidentTicket.subject },
                {"type", incidentTicket.incidentType },
                {"user", incidentTicket.reportedBy },
                {"priority", incidentTicket.priority },
                {"description", incidentTicket.description },
                {"resolved", incidentTicket.resolved },
                {"deadline", incidentTicket.deadlineFollowUp }
            };
            return newBsonDocument;
        }
    }
}
