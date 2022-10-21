using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Controller
{
    public class TicketCRUDController
    {
        private TicketCRUDDAO ticketCRUDDAO;
        private UserDAO userDAO;
        public TicketCRUDController()
        {
            userDAO = new UserDAO();
            ticketCRUDDAO = new TicketCRUDDAO();
        }

        public void DeleteTicket(string id)
        {
            ticketCRUDDAO.DeleteTicket(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)));
        }
        public void CreateTicket(IncidentTicket incidentTicket)
        {
            ticketCRUDDAO.CreateTicket(incidentTicket.ToBsonDocument());
        }
        public void UpdateTicket(IncidentTicket incidentTicket)
        {
            ticketCRUDDAO.UpdateTicket(incidentTicket.ToBsonDocument(), Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(incidentTicket._Id)));
        }
        public BsonDocument SearchTicket(string userInput)
        {
            return ticketCRUDDAO.SearchTicket(Builders<BsonDocument>.Filter.Regex("subject", new BsonRegularExpression(userInput)));
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
        public List<IncidentTicket> ReadOwnTicketsList(User user)
        {
            List<IncidentTicket> ownTickets = new List<IncidentTicket>();
            foreach (BsonDocument bsonDocument in ticketCRUDDAO.GetOwnTicketsList(Builders<BsonDocument>.Filter.Eq("user", user.FullName)))
            {
                ownTickets.Add(new IncidentTicket(bsonDocument));
            }
            return ownTickets;
        }
        public (int resolved, int unresolved) GetUnresolvedIncidents()
        {
            return ticketCRUDDAO.GetUnresolvedIncidents();
        }
        public int GetIncidentsPastDeadline()
        {
            return ticketCRUDDAO.GetIncidentsPastDeadline();
        }


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
        public List<string> getAllNames()
        {
            return userDAO.GetAllNames();
        }
    }
}
