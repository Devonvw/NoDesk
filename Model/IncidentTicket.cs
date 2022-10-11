using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Model
{
    public class IncidentTicket
    {
        public string? _Id { get; set; }
        public DateTime reportedDate { get; set; }
        public string? subject { get; set; }
        public string? type { get; set; }
        public string? user { get; set; }
        public Priority priority { get; set; }
        public DateTime deadline { get; set; }
        public string? description { get; set; }
        public bool resolved { get; set; }


        public IncidentTicket(BsonDocument bsonDocument)
        {
            foreach (BsonElement element in bsonDocument)
            {
                switch (element.Name)
                {
                    case "_id":
                        _Id = element.Value.ToString();
                        break;
                    case ("reportedDate"):
                        reportedDate = DateTime.Parse(element.Value.ToString()!);
                        break;
                    case ("subject"):
                        subject = element.Value.ToString();
                        break;
                    case ("type"):
                        type = element.Value.ToString();
                        break;
                    case ("user"):
                        user = element.Value.ToString();
                        break;
                    case ("priority"):
                        priority = Enum.Parse<Priority>(element.Value.ToString()!);
                        break;
                    case ("deadline"):
                        deadline = DateTime.Parse(element.Value.ToString()!);
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

        public IncidentTicket(DateTime reportedDate, string? subject, string? type, string? user, Priority priority, DateTime deadline, string? description)
        {
            this.reportedDate = reportedDate;
            this.subject = subject;
            this.type = type;
            this.user = user;
            this.priority = priority;
            this.deadline = deadline;
            this.description = description;
            this.resolved = false;
        }

        public BsonDocument ToBsonDocument()
        {
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"reportedDate", reportedDate },
                {"subject", subject },
                {"type", type },
                {"user", user },
                {"priority", priority },
                {"description", description },
                {"resolved", resolved },
                {"deadline", deadline }
            };
            return newBsonDocument;
        }

        public override string ToString()
        {
            return $"{reportedDate.ToString("dd/mm/yyyy")} {subject} {type} {user}";
        }
    }
}
