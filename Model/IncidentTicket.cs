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
        public string? _id { get; set; }
        public DateTime reportedDate { get; set; }
        public string? subject { get; set; }
        public string? type { get; set; }
        public string? user { get; set; }
        public Priority priority { get; set; }
        public DateTime deadline { get; set; }
        public string? description { get; set; }
        public bool resolved { get; set; }

        public IncidentTicket() { }
        public IncidentTicket(DateTime dateTimeReported, string subject, string incidentType, string reportedBy, Priority priority, DateTime deadlineFollowUp, string description)
        {
            this.reportedDate = dateTimeReported;
            this.subject = subject;
            this.type = incidentType;
            this.user = reportedBy;
            this.priority = priority;
            this.deadline = deadlineFollowUp;
            this.description = description;
        }

        public IncidentTicket(BsonDocument bsonDocument)
        {
            foreach (BsonElement element in bsonDocument)
            {
                switch (element.Name)
                {
                    case "_id":
                        _id = element.Value.ToString();
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
    }
}
