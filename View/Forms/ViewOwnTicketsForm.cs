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
using Controller;
using MongoDB.Bson;

namespace View.Forms
{
    public partial class ViewOwnTicketsForm : Form
    {
        User currentUser = CurrentUser.GetInstance().GetUser();
        TicketCRUDController ticketCRUDController;
        List<IncidentTicket> ticketsOfUser;
        public ViewOwnTicketsForm()
        {
            InitializeComponent();
            
        }

        public void FillListViewOwnTickets()
        {
            LstViewOwnTickets.Items.Clear();

            ticketCRUDController = new TicketCRUDController();
            ticketsOfUser = ticketCRUDController.ReadOwnTicketsList(currentUser);
         
            foreach (IncidentTicket ticket in ticketsOfUser)
            {
                ListViewItem li = new ListViewItem(ticket._Id);
                li.SubItems.Add(ticket.subject);
                li.SubItems.Add(ticket.reportedDate.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.resolved.ToString());
                li.SubItems.Add(ticket.priority.ToString());
                li.SubItems.Add(ticket.deadline.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.description.ToString());
                li.Tag = ticket;
                LstViewOwnTickets.Items.Add(li);

                if (ticket.resolved)
                   li.SubItems[3].Text = "Yes";
                else
                    li.SubItems[3].Text = "No";
            }
        }
        private void ViewOwnTicketsForm_Load(object sender, EventArgs e)
        {
            lblViewOwnTickets.Text = $"These are your tickets {currentUser.FullName}";
            FillListViewOwnTickets();
        }

        private void LstViewOwnTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstViewOwnTickets.SelectedItems.Count > 0)
            {
                ListViewItem item = LstViewOwnTickets.SelectedItems[0];
                txtBoxOwnTicketDescription.Text = item.SubItems[6].Text;
            }
            else
            {
                txtBoxOwnTicketDescription.Text = string.Empty;
            }
        }

        private void buttonEscalateTicket_Click(object sender, EventArgs e)
        {
            if (LstViewOwnTickets.SelectedItems.Count > 0)
            {
                IncidentTicket ticketToBeEscalated  = ticketCRUDController.GetTicketById(ObjectId.Parse(LstViewOwnTickets.SelectedItems[0].Text));
                EscalateTicketForm escalateTicketForm = new EscalateTicketForm(ticketToBeEscalated,this);
                escalateTicketForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose a ticket");
            }
        }
    }
}