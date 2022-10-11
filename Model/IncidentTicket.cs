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
        public string? Id { get; set; }
        public DateTime dateTimeReported { get; set; }
        public string? subject { get; set; }
        public string? incidentType { get; set; }
        public string? reportedBy { get; set; }
        public Priority priority { get; set; }
        public DateTime deadlineFollowUp { get; set; }
        public string? description { get; set; }
        public bool resolved { get; set; }

        public IncidentTicket() { }
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

        public override string ToString()
        {
            return $"{dateTimeReported.ToString("dd/mm/yyyy")} {subject} {incidentType} {reportedBy}";
        }
    }
}
