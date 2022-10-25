using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class EscalateTicketForm : Form
    {
        UserLoginController userLoginController;

        IncidentTicket ticketToBeEscalated;
        ViewOwnTicketsForm form;

        public EscalateTicketForm(IncidentTicket ticketToBeEscalated, ViewOwnTicketsForm form)
        {
            this.form = form;
            userLoginController = new UserLoginController();
            this.ticketToBeEscalated = ticketToBeEscalated;
            InitializeComponent();
            loadComboBox();

            labelShowTicket.Text += $"\nReported date: {ticketToBeEscalated.reportedDate}\nSubject: {ticketToBeEscalated.subject}\nId: {ticketToBeEscalated._id}";
        }


        public void loadComboBox()
        {
            List<User> serviceDeskUsers = userLoginController.GetServiceDeskUsers();

            foreach (User u in serviceDeskUsers)
                comboBoxServiceDeskUser.Items.Add(u);

            comboBoxServiceDeskUser.DisplayMember = "FullName";
        }

        private void btnEscalate_Click(object sender, EventArgs e)
        {
            if (comboBoxServiceDeskUser.SelectedIndex != -1)
            {
                var user = (User)comboBoxServiceDeskUser.SelectedItem;
                ticketToBeEscalated.user = user.FullName;
                new TicketCRUDController().UpdateTicket(ticketToBeEscalated);

                MessageBox.Show($"TICKET ESCALTED \n to : {user.FullName}");

                this.Close();
                form.FillListViewOwnTickets();
            }
            else
                MessageBox.Show("Please select a service desk user");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
