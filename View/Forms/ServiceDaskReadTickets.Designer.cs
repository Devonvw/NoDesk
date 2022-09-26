﻿namespace View.Forms
{
    partial class ServiceDaskReadTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overviewTicketsLabel = new System.Windows.Forms.Label();
            this.createIncidentButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Resolved = new System.Windows.Forms.ColumnHeader();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.updateTicketButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.archiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overviewTicketsLabel
            // 
            this.overviewTicketsLabel.AutoSize = true;
            this.overviewTicketsLabel.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.overviewTicketsLabel.Location = new System.Drawing.Point(120, 89);
            this.overviewTicketsLabel.Name = "overviewTicketsLabel";
            this.overviewTicketsLabel.Size = new System.Drawing.Size(452, 63);
            this.overviewTicketsLabel.TabIndex = 0;
            this.overviewTicketsLabel.Text = "Overview tickets";
            // 
            // createIncidentButton
            // 
            this.createIncidentButton.Location = new System.Drawing.Point(245, 170);
            this.createIncidentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createIncidentButton.Name = "createIncidentButton";
            this.createIncidentButton.Size = new System.Drawing.Size(144, 52);
            this.createIncidentButton.TabIndex = 1;
            this.createIncidentButton.Text = "CREATE INCIDENT";
            this.createIncidentButton.UseVisualStyleBackColor = true;
            this.createIncidentButton.Click += new System.EventHandler(this.createIncidentButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Subject,
            this.User,
            this.Date,
            this.Resolved});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(120, 251);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(662, 427);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 120;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Resolved
            // 
            this.Resolved.Text = "Resolved";
            this.Resolved.Width = 100;
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.Location = new System.Drawing.Point(545, 170);
            this.deleteTicketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(144, 52);
            this.deleteTicketButton.TabIndex = 3;
            this.deleteTicketButton.Text = "DELETE TICKET";
            this.deleteTicketButton.UseVisualStyleBackColor = true;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // updateTicketButton
            // 
            this.updateTicketButton.Location = new System.Drawing.Point(395, 170);
            this.updateTicketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateTicketButton.Name = "updateTicketButton";
            this.updateTicketButton.Size = new System.Drawing.Size(144, 52);
            this.updateTicketButton.TabIndex = 4;
            this.updateTicketButton.Text = "UPDATE TICKET";
            this.updateTicketButton.UseVisualStyleBackColor = true;
            this.updateTicketButton.Click += new System.EventHandler(this.updateTicketButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(62, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 51);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Search...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(695, 171);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(144, 51);
            this.archiveButton.TabIndex = 6;
            this.archiveButton.Text = "ARCHIVE TICKETS";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // ServiceDaskReadTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 764);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateTicketButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.createIncidentButton);
            this.Controls.Add(this.overviewTicketsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ServiceDaskReadTickets";
            this.Text = "ServiceDask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label overviewTicketsLabel;
        private Button createIncidentButton;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Subject;
        private ColumnHeader User;
        private ColumnHeader Date;
        private ColumnHeader Resolved;
        private Button deleteTicketButton;
        private Button updateTicketButton;
        private TextBox textBox1;
        private Button archiveButton;
    }
}