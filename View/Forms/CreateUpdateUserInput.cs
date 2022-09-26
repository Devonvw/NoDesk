using Controller;
using Model;

namespace View.Forms
{
    public abstract partial class CreateUpdateUserInput : Form
    {
        protected MainForm mainForm;
        protected TicketCRUDController ticketCRUDController;

        public CreateUpdateUserInput(MainForm mainForm, string pageTitle, string submitTicketText)
        {
            this.mainForm = mainForm;
            ticketCRUDController = new TicketCRUDController();
            InitializeComponent();
            pageTitleLabel.Text = pageTitle;
            submitTicketButton.Text = submitTicketText;
        }


        protected bool CheckValues()
        {
            if (subjectOfIncidentTB.Text != string.Empty && typeOfIncidentCB.Text != string.Empty && reportedByUserCB.Text != string.Empty && priorityCB.Text != string.Empty && descriptionTB.Text != string.Empty)
            {
                if (deadlineFollowUpDTP.Value > DateTime.Now)
                {
                    if (deadlineFollowUpDTP.Value > dateTimeReportedDTP.Value)
                    {
                        return true;
                    }
                    MessageBox.Show("The deadline is earlier than the reported date");
                    return false;
                }
                MessageBox.Show("The deadline is in the past");
                return false;
            }
            MessageBox.Show("Please fill in all tables");
            return false;
        }



        protected IncidentTicket GetTableInput()
        {
            return new IncidentTicket(dateTimeReportedDTP.Value, subjectOfIncidentTB.Text, typeOfIncidentCB.Text, reportedByUserCB.Text, (Priority)priorityCB.SelectedIndex, deadlineFollowUpDTP.Value, descriptionTB.Text);
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
        }
    }
}
