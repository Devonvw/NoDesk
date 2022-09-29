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
            submitTicketButton.Click += SubmitTicketButton_Click!;
        }

        private void SubmitTicketButton_Click(object sender, EventArgs e)
        {
            RadioButton? incidentTypeRB = flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton? priorityRB = flowLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (CheckValues(incidentTypeRB!, priorityRB!))
            {
                IncidentTicket incidentTicket = GetTableInput(incidentTypeRB!, priorityRB!);
                ticketCRUDController.CreateTicket(incidentTicket);
                MessageBox.Show("Ticket created successfully!");
                mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
                return;
            }
        }
    }
}
