using DAL;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class TicketCRUDController
    {
        private TicketCRUDDAO ticketCRUDDAO;
        public TicketCRUDController()
        {
            ticketCRUDDAO = new TicketCRUDDAO();
        }

        public void DeleteTicket()
        {
            //ticketCRUDDAO.DeleteTicket();
        }
        public void CreateTicket(DateTime dateTimeReported, IncidentType incidentType, string reportedBy, Priority priority, DateTime deadlineFollowUp, string description)
        {
            
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", dateTimeReported },
                {"subject", incidentType },
                {"type", incidentType },
                {"user", reportedBy },
                {"priority", priority },
                {"description", description },
                {"resolved", false },
                {"deadline", deadlineFollowUp }
            };
            ticketCRUDDAO.CreateTicket(newBsonDocument);
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
