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
            ticketCRUDController = new TicketCRUDController();
            ticketsOfUser = ticketCRUDController.ReadOwnTicketsList(currentUser);
        }
        private void FillListViewOwnTickets()
        {
            foreach (IncidentTicket ticket in ticketsOfUser)
            {
                string[] arr = new string[6];
                arr[0] = ticket._Id;
                arr[1] = ticket.subject;
                arr[2] = ticket.reportedDate.ToString("dd/MM/yyyy");
                arr[3] = ticket.resolved.ToString();
                arr[4] = ticket.priority.ToString();
                arr[5] = ticket.deadline.ToString("dd/MM/yyyy");
                LstViewOwnTickets.Tag = ticket;
                ListViewItem li = new ListViewItem(arr);
                LstViewOwnTickets.Items.Add(li);
            }
        }
        private void ViewOwnTicketsForm_Load(object sender, EventArgs e)
        {
            lblViewOwnTickets.Text = $"These are your tickets {currentUser.FullName}";
            FillListViewOwnTickets();
        }

        private void LstViewOwnTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string description = "";
            for (int i = 0; i < LstViewOwnTickets.Items.Count; i++)
            {
                txtBoxOwnTicketDescription.Clear();

                if (LstViewOwnTickets.Items[i].Selected)
                {
                    foreach (IncidentTicket ticket in ticketsOfUser)
                    {
                    description = ticket.description;
                        if (description == "")
                        {
                            txtBoxOwnTicketDescription.Text = "";
                        }
                        else
                            txtBoxOwnTicketDescription.Text = description.ToString();
                    }
                }

            }
        }
    }
}