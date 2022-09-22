using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MongoDB.Driver;
using Microsoft.VisualBasic;
using MongoDB.Bson;

namespace DAL
{
    public abstract class BaseDao
    {
        private MongoClient dbClient;
        protected IMongoDatabase db;
        protected IMongoCollection<BsonDocument> collection;
        public BaseDao()
        {
            dbClient = new MongoClient("mongodb + srv://KoenWijchers:nosql@cluster0.fb34nwv.mongodb.net/?retryWrites=true&w=majority");
            db = dbClient.GetDatabase("");
            db.GetCollection<BsonDocument>("");
        }
    }
}