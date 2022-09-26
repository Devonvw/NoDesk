using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Forms
{
    class ServiceDaskCreateTickets : CreateUpdateUserInput
    {
        public ServiceDaskCreateTickets(MainForm mainForm) : base(mainForm, "Create new incident ticket", "submit ticket")
        {
            submitTicketButton.Click += SubmitTicketButton_Click;
        }

        private void SubmitTicketButton_Click(object sender, EventArgs e)
        {

            if (CheckValues())
            {
                IncidentTicket incidentTicket = GetTableInput();
                ticketCRUDController.CreateTicket(incidentTicket);
                MessageBox.Show("Ticket created successfully!");
                mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
                return;
            }
            MessageBox.Show("Please fill in all tables");
        }

        
    }
}
