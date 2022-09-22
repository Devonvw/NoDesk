using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketCRUDDAO : BaseDao
    {
        public void CreateTicket(BsonDocument insidentTicket)
        {
            collection.InsertOne(insidentTicket);
        }

        public void UpdateTicket(UpdateDefinition<BsonDocument> update, FilterDefinition<BsonDocument> filter)
        {
            collection.UpdateMany(filter, update);
        }

        public BsonDocument GetTicket(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).First();

        }

        public List<BsonDocument> GetTicketList(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).ToList();

        }

        public void DeleteTicket(FilterDefinition<BsonDocument> filter)
        {
            collection.DeleteMany(filter);
        }

        public (int resolved, int unresolved) GetUnresolvedIncidents()
        {
            collection = db.GetCollection<BsonDocument>("Tickets");

            List< BsonDocument> unresolved = collection.Find(doc => doc["resolved"] != true).ToList();
            List<BsonDocument> resolved = collection.Find(doc => doc["resolved"] == true).ToList();

            return (resolved: resolved.Count, unresolved: unresolved.Count);
        }
        public int GetIncidentsPastDeadline()
        {
            collection = db.GetCollection<BsonDocument>("Tickets");
            List<BsonDocument> incidents = collection.Find(doc => doc["resolved"] != true && doc["deadline"] > DateTime.Now).ToList();

            return incidents.Count;
        }
    }
}
