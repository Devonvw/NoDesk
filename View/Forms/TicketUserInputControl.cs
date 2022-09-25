using Controller;
using DnsClient.Protocol;
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
    public abstract partial class TicketUserInputControl : Form
    {
        protected MainForm mainForm;
        protected TicketCRUDController ticketCRUDController;

        public TicketUserInputControl(MainForm mainForm, string pageTitle, string submitTicketText)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
        }

        protected IncidentTicket GetTableInput()
        {
            return new IncidentTicket(dateTimeReportedDTP.Value, subjectOfIncidentTB.Text, typeOfIncidentCB.Text, reportedByUserCB.Text, (Priority)priorityCB.SelectedIndex, deadlineFollowUpDTP.Value, descriptionTB.Text);
            //TicketCRUDController.CreateTicket(dateTimeReported, subjectOfIncidentTB.Text, typeOfIncidentCB.Text, reportedByUserCB.Text, (Priority)priorityCB.SelectedIndex, deadlineFollowUpDate, descriptionTB.Text);
            //MessageBox.Show("Ticket created successfully!");
            //mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);            
        }

        protected void submitTicketButton_Click(object sender, EventArgs e)
        {

        }
    }
}
