using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IncidentTicket
    {
        public DateTime DateTimeReported;
        public string Subject;
        public IncidentType IncidentType;
        public string reportedBy;
        public DateTime deadlineFollowUp;
        public string description;
    }
}
