﻿using MongoDB.Bson;
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

        public int GetCountOfTicketsOnUser(FilterDefinition<BsonDocument> filter)
        {
            return Convert.ToInt32(collection.Find(filter).CountDocuments());

        }
    }
}
