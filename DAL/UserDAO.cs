using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class UserDAO : BaseDao
    {
        public UserDAO()
        {
            collection = db.GetCollection<BsonDocument>("Users");
        }

        public void CreateUser(BsonDocument User)
        {
            collection.InsertOne(User);
        }

        public BsonDocument GetUser(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).First();
        }

        public List<BsonDocument> GetUserList(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).ToList();

        }
        public void UpdateUser(BsonDocument update, FilterDefinition<BsonDocument> filter)
        {
            collection.ReplaceOne(filter, update);
        }

        public List<string> GetAllNames()
        {
            List<string> names = new List<string>();
            foreach (BsonDocument bson in collection.Find(new BsonDocument()).ToList())
            {
                names.Add($"{bson[1]} {bson[2]}");
            }
            return names;
        }
    }
}
