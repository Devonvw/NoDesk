namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnViewMyTickets = new System.Windows.Forms.Button();
            this.btnIncident = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnViewMyTickets);
            this.flowLayoutPanel1.Controls.Add(this.btnAddTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnIncident);
            this.flowLayoutPanel1.Controls.Add(this.btnUserManagement);
            this.flowLayoutPanel1.Controls.Add(this.btnLogOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 13);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1009, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(3, 4);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(125, 43);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(260, 4);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(134, 43);
            this.btnAddTicket.TabIndex = 0;
            this.btnAddTicket.Text = "Add ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // btnViewMyTickets
            // 
            this.btnViewMyTickets.Location = new System.Drawing.Point(134, 4);
            this.btnViewMyTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewMyTickets.Name = "btnViewMyTickets";
            this.btnViewMyTickets.Size = new System.Drawing.Size(120, 43);
            this.btnViewMyTickets.TabIndex = 4;
            this.btnViewMyTickets.Text = "View my tickets";
            this.btnViewMyTickets.UseVisualStyleBackColor = true;
            this.btnViewMyTickets.Click += new System.EventHandler(this.btnViewMyTickets_Click);
            // 
            // btnIncident
            // 
            this.btnIncident.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncident.Location = new System.Drawing.Point(400, 4);
            this.btnIncident.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(160, 43);
            this.btnIncident.TabIndex = 1;
            this.btnIncident.Text = "Incident Management";
            this.btnIncident.UseVisualStyleBackColor = true;
            this.btnIncident.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(566, 4);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(146, 43);
            this.btnUserManagement.TabIndex = 2;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogOut.Location = new System.Drawing.Point(718, 4);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 43);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlChild
            // 
            this.pnlChild.AutoScroll = true;
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(11, 77);
            this.pnlChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1009, 667);
            this.pnlChild.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1031, 757);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "NoDesk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnDashboard;
        public Button btnIncident;
        public Button btnUserManagement;
        private Panel pnlChild;
        private Button btnLogOut;
        private Button btnAddIncidentReg;
        public Button btnAddTicket;
        public Button btnViewMyTickets;
    }
}