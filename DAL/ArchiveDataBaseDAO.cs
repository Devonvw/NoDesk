﻿using MongoDB.Bson;
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

        public void ArchiveOldResolvedTickets()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("resolved", true) & Builders<BsonDocument>.Filter.Lt("reportedDate", DateTime.Today.AddYears(-2));
            archive.InsertMany(collection.Find(filter).ToList());
            collection.DeleteMany(filter);
        }
    }
}