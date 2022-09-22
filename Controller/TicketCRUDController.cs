using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TicketCRUDController
    {
        private TicketCRUDDAO ticketCRUDDAO;
        public TicketCRUDController()
        {
            ticketCRUDDAO = new TicketCRUDDAO();
        }

        private void DeleteTicket()
        {
            //ticketCRUDDAO.DeleteTicket();
        }
        private void CreateTicket()
        {
            //ticketCRUDDAO.CreateTicket();
        }
        public (int resolved, int unresolved) GetUnresolvedIncidents()
        {
            return ticketCRUDDAO.GetUnresolvedIncidents();
        }
        public int GetIncidentsPastDeadline()
        {
            return ticketCRUDDAO.GetIncidentsPastDeadline();
        }
    }
}
