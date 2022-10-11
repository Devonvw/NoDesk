﻿using Controller;
using Model;
using MongoDB.Bson;
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
        List<IncidentTicket> allIncidentTickets;

        

        
        public ServiceDaskReadTickets(MainForm mainForm)
        {            
            this.mainForm = mainForm;
            ticketCRUDController = new TicketCRUDController();
            archiveDataBaseController = new ArchiveDataBaseController();
            allIncidentTickets = ticketCRUDController.ReadTicketList();

            InitializeComponent();
            FillTables(allIncidentTickets);
            
        }


        private void FillTables(List<IncidentTicket> tickets)
        {
            OverviewTicketsLV.Items.Clear();
            foreach (IncidentTicket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket._Id);
                li.SubItems.Add(ticket.subject);
                li.SubItems.Add(ticket.user);
                li.SubItems.Add(ticket.reportedDate.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.resolved.ToString());
                li.SubItems.Add(ticket.priority.ToString());
                li.SubItems.Add(ticket.deadline.ToString("dd/MM/yyyy"));
                li.Tag = ticket;
                OverviewTicketsLV.Items.Add(li);
            }            
        }

        private void SortTable()
        {
            FillTables(GetTableTickets().OrderBy(p=>p.priority).ToList());
        }

        private List<IncidentTicket> GetTableTickets()
        {
            List<IncidentTicket> tickets = new List<IncidentTicket>();
            foreach (ListViewItem item in OverviewTicketsLV.Items)
            {
                tickets.Add((IncidentTicket)item.Tag);
            }
            return tickets;
        }

        private void LoadTableForSearch(List<IncidentTicket> tickets)
        {
            foreach (IncidentTicket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket._Id);
                li.SubItems.Add(ticket.subject);
                li.SubItems.Add(ticket.user);
                li.SubItems.Add(ticket.reportedDate.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.resolved.ToString());
                li.Tag = ticket;
                OverviewTicketsLV.Items.Add(li);
            }
        }

        private void updateTicketButton_Click(object sender, EventArgs e)
        {
           
            if(OverviewTicketsLV.SelectedItems.Count != 0)
            {
                IncidentTicket incidentTicket = (IncidentTicket)OverviewTicketsLV.SelectedItems[0].Tag;
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
            if (OverviewTicketsLV.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete these tickets?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in OverviewTicketsLV.SelectedItems)
                    {
                        IncidentTicket incidentTicket = (IncidentTicket)item.Tag;
                        ticketCRUDController.DeleteTicket(incidentTicket._Id!);
                    }
                    FillTables(allIncidentTickets);
                    return;
                }
            }
            MessageBox.Show("please select a ticket");
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(archiveDataBaseController.ArchiveOldResolvedTicketes());
            FillTables(allIncidentTickets);
        }

        private void buttonCloseTicket_Click(object sender, EventArgs e)
        {
            if (OverviewTicketsLV.SelectedItems.Count == 0 || OverviewTicketsLV.SelectedItems.Count >= 2)
            {
                MessageBox.Show("Please select one ticket");
            }
            else
            {
                IncidentTicket incidentTicket = (IncidentTicket)(OverviewTicketsLV.FocusedItem).Tag;
                incidentTicket.resolved = true;
                ticketCRUDController.UpdateTicket(incidentTicket);
                FillTables(allIncidentTickets);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case ("Search..."):
                    {
                        FillTables(allIncidentTickets);
                        break; }
                case (""):
                    {
                        FillTables(allIncidentTickets);
                        break; }
                default:
                    {
                        OverviewTicketsLV.Items.Clear();
                        LoadTableForSearch(ticketCRUDController.GetAllTicketsBasedOnSearch(textBox1.Text));
                        break;
                    }  
            }
           
        }

        private void OverviewTicketsLV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortTable();
        }
    }
}
