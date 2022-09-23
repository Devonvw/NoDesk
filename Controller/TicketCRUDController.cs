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
        //632df4600765ae3dd6a4b1ad 632df4600765ae3dd6a4b1ad
        public void DeleteTicket(string id)
        {
            ticketCRUDDAO.DeleteTicket(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)));
        }
        public void CreateTicket(DateTime dateTimeReported, string subjectOfIncident, string incidentType, string reportedBy, Priority priority, DateTime deadlineFollowUp, string description)
        {

            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", dateTimeReported },
                {"subject", subjectOfIncident },
                {"type", incidentType },
                {"user", reportedBy },
                {"priority", priority },
                {"description", description },
                {"resolved", false },
                {"deadline", deadlineFollowUp }
            };
            ticketCRUDDAO.CreateTicket(newBsonDocument);
        }

        public List<IncidentTicket> ReadTicketList()
        {
            List<IncidentTicket> incidentTickets = new List<IncidentTicket>();
            foreach (BsonDocument bsonDocument in ticketCRUDDAO.GetTicketList(Builders<BsonDocument>.Filter.Empty))
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
    }
}
