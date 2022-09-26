using Model;

namespace View.Forms
{
    public partial class ServiceDaskUpdateTicket : CreateUpdateUserInput
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
