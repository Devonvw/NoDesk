using Controller;
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
    public partial class TransferTicketForm : Form
    {   
        private TicketCRUDController ticketCRUDController;
        private UserLoginController userLoginController;
        private IncidentTicket ticket;
        private ServiceDaskReadTickets form;
        public TransferTicketForm(IncidentTicket ticket,ServiceDaskReadTickets form)
        {
            this.form = form;
            this.ticket = ticket;
            ticketCRUDController = new TicketCRUDController();
            userLoginController = new UserLoginController();
            InitializeComponent();
            LoadUsers();
            lblChosenTicketShow.Text = ticket.ToString();
        }

        private void LoadUsers()
        {
            foreach (User user in userLoginController.GetServiceDeskUsers())
            {
                comboBox1.Items.Add(user.FullName);
            }
        }

        private void btnTransferTicket_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Please select new user to tranfer ticket");
                return;
            }
            ticket.reportedBy = comboBox1.Text;
            ticketCRUDController.UpdateTicket(ticket);
            form.LoadTable();
            this.Hide();
        }
    }
}
