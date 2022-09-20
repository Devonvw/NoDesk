using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MongoDB.Driver;
using Microsoft.VisualBasic;
using MongoDB.Bson;

namespace BestelsysteemDAL
{
    public abstract class BaseDao
    {
        private MongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
        public BaseDao()
        {
            dbClient = new MongoClient("");
            db = dbClient.GetDatabase("");
            db.GetCollection<BsonDocument>("");
        }
    }
}