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

        //public BsonDocument GetUser(FilterDefinition<BsonDocument> filter)
        //{
        //    return collection.Find(filter).First();
        //}

        public BsonDocument GetUser(FilterDefinition<BsonDocument> filter)
        {
            return collection.Find(filter).First();
        }
    }
}
