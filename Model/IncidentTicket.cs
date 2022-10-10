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
        public string? Id;
        public DateTime dateTimeReported;
        public string? subject;
        public string? incidentType;
        public string? reportedBy;
        public Priority priority;
        public DateTime deadlineFollowUp;
        public string? description;
        public bool resolved;

        public IncidentTicket(DateTime dateTimeReported, string subject, string incidentType, string reportedBy, Priority priority, DateTime deadlineFollowUp, string description)
        {
            this.dateTimeReported = dateTimeReported;
            this.subject = subject;
            this.incidentType = incidentType;
            this.reportedBy = reportedBy;
            this.priority = priority;
            this.deadlineFollowUp = deadlineFollowUp;
            this.description = description;
        }

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
                        dateTimeReported = DateTime.Parse(element.Value.ToString()!);
                        break;
                    case ("subject"):
                        subject = element.Value.ToString();
                        break;
                    case ("type"):
                        incidentType = element.Value.ToString();
                        break;
                    case ("user"):
                        reportedBy = element.Value.ToString();
                        break;
                    case ("priority"):
                        priority = Enum.Parse<Priority>(element.Value.ToString()!);
                        break;
                    case ("deadline"):
                        deadlineFollowUp = DateTime.Parse(element.Value.ToString()!);
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

        public BsonDocument ToBsonDocument()
        {
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", dateTimeReported },
                {"subject", subject },
                {"type", incidentType },
                {"user", reportedBy },
                {"priority", priority },
                {"description", description },
                {"resolved", resolved },
                {"deadline", deadlineFollowUp }
            };
            return newBsonDocument;
        }
    }
}
