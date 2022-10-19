using Model;

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
            User currentUser = CurrentUser.GetInstance().GetUser();


            RadioButton? incidentTypeRB = flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton? priorityRB = flowLayoutPanel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (CheckValues(incidentTypeRB!, priorityRB!))
            {
                IncidentTicket incidentTicket = GetTableInput(incidentTypeRB!, priorityRB!);
                ticketCRUDController.CreateTicket(incidentTicket);

                if (currentUser.UserType == UserType.Regular)
                {
                    MessageBox.Show("Ticket created successfully!");
                    mainForm.OpenChildForm(new DashboardForm(), sender);
                }
                else
                {
                    MessageBox.Show("Ticket created successfully!");
                    mainForm.OpenChildForm(new ServiceDaskReadTickets(mainForm), sender);
                    return;

                }
            }
        }
    }
}
