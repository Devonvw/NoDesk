using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class ServiceDaskUpdateTicket : TicketUserInputControl
    {
        public ServiceDaskUpdateTicket(MainForm mainForm, IncidentTicket incidentTicket)
            : base(mainForm, "Update incident ticket", "update ticket")
        {            
            InitializeComponent();
            dateTimeReportedDTP.Value = incidentTicket.dateTimeReported;
            subjectOfIncidentTB.Text = incidentTicket.subject;
            typeOfIncidentCB.Text = incidentTicket.incidentType;
            reportedByUserCB.Text = incidentTicket.reportedBy;
            priorityCB.Text = incidentTicket.priority.ToString();
            //
            deadlineFollowUpDTP.Value = incidentTicket.deadlineFollowUp;
            descriptionTB.Text = incidentTicket.description;
            submitTicketButton.Click += SubmitTicketButton_Click;
        }

        private void SubmitTicketButton_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                IncidentTicket incidentTicket = GetTableInput();
                ticketCRUDController.CreateTicket(incidentTicket);
                MessageBox.Show("Ticket updated successfully!");
                mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
                return;
            }
        }

    }
}
