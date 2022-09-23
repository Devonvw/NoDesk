using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Model
{
    public class IncidentTicket
    {
        public string Id;
        public DateTime DateTimeReported;
        public string Subject;
        public string IncidentType;
        public string reportedBy;
        public DateTime deadlineFollowUp;
        public string description;
        public bool resolved;

        public IncidentTicket(BsonDocument bsonDocument)
        {          
            foreach (BsonElement element in bsonDocument)
            {
                switch (element.Name)
                {
                    case "_id":
                        Id = element.Value.ToString();
                        break;
                    case ("reportedDate"):
                        DateTimeReported = DateTime.Parse(element.Value.ToString());
                        break;
                    case ("subject"):
                        Subject = element.Value.ToString();
                        break;
                    case ("type"):
                        IncidentType = element.Value.ToString();
                        break;
                    case ("user"):
                        reportedBy = element.Value.ToString();
                        break;
                    case ("deadline"):
                        deadlineFollowUp = DateTime.Parse(element.Value.ToString());
                        break;
                    case ("description"):
                        description = element.Value.ToString();
                        break;
                    case ("resolved"):
                        resolved = element.Value.ToBoolean();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
