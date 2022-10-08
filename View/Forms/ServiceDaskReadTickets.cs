using Controller;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
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
    public partial class ServiceDaskReadTickets : Form
    {
        MainForm mainForm;
        TicketCRUDController ticketCRUDController;
        ArchiveDataBaseController archiveDataBaseController;
        public ServiceDaskReadTickets(MainForm mainForm)
        {
            this.mainForm = mainForm;
            ticketCRUDController = new TicketCRUDController();
            archiveDataBaseController = new ArchiveDataBaseController();
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            listView1.Items.Clear();
            List<IncidentTicket> tickets = ticketCRUDController.ReadTicketList();
            foreach (IncidentTicket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket.Id);
                li.SubItems.Add(ticket.subject);
                li.SubItems.Add(ticket.reportedBy);
                li.SubItems.Add(ticket.dateTimeReported.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.resolved.ToString());
                li.Tag = ticket;
                listView1.Items.Add(li);
            }
        }
        private void SearchTable(BsonDocument bsonDocument)
        {
            listView1.Items.Clear();
            List<IncidentTicket> tickets = ticketCRUDController.ReadTicketList();
            foreach (IncidentTicket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket.Id);
                li.SubItems.Add(ticket.subject);
                li.SubItems.Add(ticket.reportedBy);
                li.SubItems.Add(ticket.dateTimeReported.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.resolved.ToString());
                li.Tag = ticket;
                listView1.Items.Add(li);
            }
        }
        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                IncidentTicket incidentTicket = (IncidentTicket)listView1.SelectedItems[0].Tag;
                mainForm.OpenChildForm(new ServiceDaskUpdateTicket(mainForm, incidentTicket), sender);
            }
            else
            {
                MessageBox.Show("please select a ticket to update");
            }
        }

        private void createIncidentButton_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ServiceDaskCreateTickets(mainForm), sender);
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete these tickets?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        IncidentTicket incidentTicket = (IncidentTicket)item.Tag;
                        ticketCRUDController.DeleteTicket(incidentTicket.Id!);
                    }
                    LoadTable();
                    return;
                }
            }
            MessageBox.Show("please select a ticket");
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            archiveDataBaseController.ArchiveOldResolvedTicketes();
            LoadTable();
        }
        private void searchThroughTickets_TextChanged(object sender, EventArgs e)
        {
            string userInput = searchThroughTickets.Text;
            listView1.Items.Clear();
            SearchTable(ticketCRUDController.SearchTicket(userInput));
        }
    }
}