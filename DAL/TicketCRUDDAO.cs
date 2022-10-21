using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketCRUDDAO : BaseDao
    {
        public TicketCRUDDAO()
        {
            collection = db.GetCollection<BsonDocument>("Tickets");
        }
        public void CreateTicket(BsonDocument insidentTicket)
        {
            collection.InsertOne(insidentTicket);
        }

        public void UpdateTicket(BsonDocument update, FilterDefinition<BsonDocument> filter)
        {
            collection.ReplaceOne(filter, update);
        }
        public BsonDocument SearchTicket(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).First();                                                             
        }

        public BsonDocument GetTicket(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).First();
        }

        public List<BsonDocument> GetTicketList(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).ToList();
        }
        public List<BsonDocument> GetOwnTicketsList(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).ToList();
        }

        public void DeleteTicket(FilterDefinition<BsonDocument> filter)
        {
            collection.DeleteOne(filter);
        }

        public (int total, int unresolved) GetUnresolvedIncidents()
        {
            List<BsonDocument> unresolved = collection.Find(doc => doc["resolved"] != true).ToList();
            List<BsonDocument> total = collection.Find(_ => true).ToList();

            return (total: total.Count, unresolved: unresolved.Count);
        }
        public int GetIncidentsPastDeadline()
        {
            List<BsonDocument> incidents = collection.Find(doc => doc["resolved"] != true && doc["deadline"] < DateTime.Now).ToList();

            return incidents.Count;
        }

        public List<BsonDocument> GetAllTicketsBasedOnSearch(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).ToList();
        }
    }
}
