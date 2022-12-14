using Controller;
using Model;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace View.Forms
{
    public abstract partial class CreateUpdateUserInput : Form
    {
        protected MainForm mainForm;
        protected TicketCRUDController ticketCRUDController;
        protected UserLoginController userLoginController;

        public CreateUpdateUserInput(MainForm mainForm, string pageTitle, string submitTicketText)
        {
            this.mainForm = mainForm;
            ticketCRUDController = new TicketCRUDController();
            userLoginController = new UserLoginController();
            InitializeComponent();
            pageTitleLabel.Text = pageTitle;
            submitTicketButton.Text = submitTicketText;
            SetReportedUserName();
       
        }

        private void SetReportedUserName()
        {
            foreach (string name in ticketCRUDController.getAllNames())
            {
                reportedByUserCB.Items.Add(name);
            }
        }

        protected bool CheckValues(RadioButton incidentTypeRB, RadioButton priorityRB)
        {
            if (subjectOfIncidentTB.Text == string.Empty || reportedByUserCB.Text == string.Empty || descriptionTB.Text == string.Empty || incidentTypeRB == null || priorityRB == null)
            {
                MessageBox.Show("Please fill in all tables");
                return false;
            }
            if (deadlineFollowUpDTP.Value < DateTime.Now)
            {
                MessageBox.Show("The deadline is in the past");
                return false;
            }
            else if (deadlineFollowUpDTP.Value < dateTimeReportedDTP.Value)
            {
                MessageBox.Show("The deadline is earlier than the reported date");
                return false;
            }
            return true;
        }



        protected virtual IncidentTicket GetTableInput(RadioButton incidentTypeRB, RadioButton priorityRB)
        {
            return new IncidentTicket(dateTimeReportedDTP.Value, subjectOfIncidentTB.Text, incidentTypeRB.Text, reportedByUserCB.Text, (Priority)priorityRB.Tag, deadlineFollowUpDTP.Value, descriptionTB.Text);
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
        }

        //private void LoadUsers()
        //{
        //    foreach (User user in userLoginController.GetServiceDeskUsers())
        //    {
        //        reportedByUserCB.Items.Add(user.FullName);
        //    }
        //}


    }
}
