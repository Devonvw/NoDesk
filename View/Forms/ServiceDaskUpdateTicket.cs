using Model;
using System.Configuration;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class ServiceDaskUpdateTicket : CreateUpdateUserInput
    {
        private IncidentTicket oldIncidentTicket;
        public ServiceDaskUpdateTicket(MainForm mainForm, IncidentTicket oldIncidentTicket)
            : base(mainForm, "Update incident ticket", "update ticket")
        {
            this.oldIncidentTicket = oldIncidentTicket;
            InitializeComponent();
            dateTimeReportedDTP.Value = oldIncidentTicket.dateTimeReported;
            subjectOfIncidentTB.Text = oldIncidentTicket.subject;
            switch (oldIncidentTicket.incidentType)
            {
                case "Software":
                    softwareRB.Checked = true;
                    break;
                case "Hardware":
                    hardwareRB.Checked = true;
                    break;
                case "Service":
                    ServiceRB.Checked = true;
                    break;
                default:
                    break;
            }
            reportedByUserCB.Text = oldIncidentTicket.reportedBy;
            switch (oldIncidentTicket.priority)
            {
                case Priority.Low:
                    lowRB.Checked = true;
                    break;
                case Priority.Normal:
                    normalRB.Checked = true;
                    break;
                case Priority.High:
                    HighRB.Checked = true;
                    break;
                default:
                    break;
            }
            deadlineFollowUpDTP.Value = oldIncidentTicket.deadlineFollowUp;
            descriptionTB.Text = oldIncidentTicket.description;
            submitTicketButton.Click += SubmitTicketButton_Click!;
        }

        private void SubmitTicketButton_Click(object sender, EventArgs e)
        {
            RadioButton? incidentTypeRB = flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton? priorityRB = flowLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (CheckValues(incidentTypeRB!, priorityRB!))
            {
                IncidentTicket incidentTicket = GetTableInput(incidentTypeRB!, priorityRB!);
                ticketCRUDController.UpdateTicket(incidentTicket);
                MessageBox.Show("Ticket updated successfully!");
                mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
                return;
            }
        }

        protected override IncidentTicket GetTableInput(RadioButton incidentType, RadioButton priorityRB)
        {
            IncidentTicket incidentTicket = base.GetTableInput(incidentType, priorityRB);
            incidentTicket._Id = oldIncidentTicket._Id;
            return incidentTicket;
        }

    }
}
