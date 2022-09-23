using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.Forms
{
    public partial class ServiceDaskCreateTicket : Form
    {
        MainForm mainForm;
        TicketCRUDController TicketCRUDController;
        
        public ServiceDaskCreateTicket(MainForm mainForm)
        {
            this.mainForm = mainForm;
            TicketCRUDController = new TicketCRUDController();
            InitializeComponent();
        }

        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                DateTime dateTimeReported = dateTimeReportedDTP.Value.Date;
                DateTime deadlineFollowUpDate = dateTimeReported;
                switch (deadLineFollowUpCB.SelectedIndex)
                {
                    case (0):
                        deadlineFollowUpDate = dateTimeReported.AddDays(7);
                        break;
                    case (1):
                        deadlineFollowUpDate = dateTimeReported.AddDays(14);
                        break;
                    case (2):
                        deadlineFollowUpDate = dateTimeReported.AddDays(28);
                        break;
                    case (3):
                        deadlineFollowUpDate = dateTimeReported.AddMonths(6);
                        break;
                    default:
                        break;
                }
                TicketCRUDController.CreateTicket(dateTimeReported, subjectOfIncidentTB.Text, typeOfIncidentCB.Text, reportedByUserCB.Text, (Priority)priorityCB.SelectedIndex, deadlineFollowUpDate, descriptionTB.Text);
                MessageBox.Show("Ticket created successfully!");
                mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
            }
        }

        private bool CheckValues()
        {
            if (subjectOfIncidentTB.Text != string.Empty && typeOfIncidentCB.Text != string.Empty && reportedByUserCB.Text != string.Empty && priorityCB.Text != string.Empty && deadLineFollowUpCB.Text != string.Empty && descriptionTB.Text != string.Empty)
            {
                return true;
            }
            MessageBox.Show("Please fill in all tables");
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
        }
    }
}
