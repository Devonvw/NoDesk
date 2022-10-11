using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ArchiveDataBaseDAO : BaseDao
    {
        private IMongoCollection<BsonDocument> archive;

        public ArchiveDataBaseDAO()
        {
            archive = db.GetCollection<BsonDocument>("Archive");
        }

        public string ArchiveOldResolvedTickets()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("resolved", true) & Builders<BsonDocument>.Filter.Lt("reportedDate", DateTime.Today.AddYears(-2));

            List<BsonDocument> list = collection.Find(filter).ToList();
            if (list.Count != 0)
            {
                archive.InsertMany(list);
                collection.DeleteMany(filter);
                return "Tickets archived succesfully!";
            }
            return "There were no Tickets To archive\nTickets must be 2 years old and resolved";

        }
    }
}
