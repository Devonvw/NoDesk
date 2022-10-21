namespace View.Forms
{
    partial class ViewOwnTicketsForm
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
            this.LstViewOwnTickets = new System.Windows.Forms.ListView();
            this.cHId = new System.Windows.Forms.ColumnHeader();
            this.cHSubject = new System.Windows.Forms.ColumnHeader();
            this.cHDate = new System.Windows.Forms.ColumnHeader();
            this.cHResolvedOrNot = new System.Windows.Forms.ColumnHeader();
            this.cHPriority = new System.Windows.Forms.ColumnHeader();
            this.chDeadline = new System.Windows.Forms.ColumnHeader();
            this.lblViewOwnTickets = new System.Windows.Forms.Label();
            this.lblTicketDescription = new System.Windows.Forms.Label();
            this.txtBoxOwnTicketDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstViewOwnTickets
            // 
            this.LstViewOwnTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHId,
            this.cHSubject,
            this.cHDate,
            this.cHResolvedOrNot,
            this.cHPriority,
            this.chDeadline});
            this.LstViewOwnTickets.FullRowSelect = true;
            this.LstViewOwnTickets.GridLines = true;
            this.LstViewOwnTickets.Location = new System.Drawing.Point(54, 51);
            this.LstViewOwnTickets.Name = "LstViewOwnTickets";
            this.LstViewOwnTickets.Size = new System.Drawing.Size(678, 249);
            this.LstViewOwnTickets.TabIndex = 0;
            this.LstViewOwnTickets.UseCompatibleStateImageBehavior = false;
            this.LstViewOwnTickets.View = System.Windows.Forms.View.Details;
            this.LstViewOwnTickets.SelectedIndexChanged += new System.EventHandler(this.LstViewOwnTickets_SelectedIndexChanged);
            // 
            // cHId
            // 
            this.cHId.Text = "ID";
            this.cHId.Width = 90;
            // 
            // cHSubject
            // 
            this.cHSubject.Text = "Subject";
            this.cHSubject.Width = 150;
            // 
            // cHDate
            // 
            this.cHDate.Text = "Date";
            this.cHDate.Width = 150;
            // 
            // cHResolvedOrNot
            // 
            this.cHResolvedOrNot.Text = "Resolved or not";
            this.cHResolvedOrNot.Width = 100;
            // 
            // cHPriority
            // 
            this.cHPriority.Text = "Priority";
            this.cHPriority.Width = 80;
            // 
            // chDeadline
            // 
            this.chDeadline.Text = "Deadline";
            this.chDeadline.Width = 104;
            // 
            // lblViewOwnTickets
            // 
            this.lblViewOwnTickets.AutoSize = true;
            this.lblViewOwnTickets.Location = new System.Drawing.Point(329, 20);
            this.lblViewOwnTickets.Name = "lblViewOwnTickets";
            this.lblViewOwnTickets.Size = new System.Drawing.Size(0, 15);
            this.lblViewOwnTickets.TabIndex = 1;
            // 
            // lblTicketDescription
            // 
            this.lblTicketDescription.AutoSize = true;
            this.lblTicketDescription.Location = new System.Drawing.Point(348, 312);
            this.lblTicketDescription.Name = "lblTicketDescription";
            this.lblTicketDescription.Size = new System.Drawing.Size(100, 15);
            this.lblTicketDescription.TabIndex = 2;
            this.lblTicketDescription.Text = "Ticket description";
            // 
            // txtBoxOwnTicketDescription
            // 
            this.txtBoxOwnTicketDescription.Location = new System.Drawing.Point(54, 339);
            this.txtBoxOwnTicketDescription.Multiline = true;
            this.txtBoxOwnTicketDescription.Name = "txtBoxOwnTicketDescription";
            this.txtBoxOwnTicketDescription.ReadOnly = true;
            this.txtBoxOwnTicketDescription.Size = new System.Drawing.Size(678, 99);
            this.txtBoxOwnTicketDescription.TabIndex = 3;
            // 
            // ViewOwnTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxOwnTicketDescription);
            this.Controls.Add(this.lblTicketDescription);
            this.Controls.Add(this.lblViewOwnTickets);
            this.Controls.Add(this.LstViewOwnTickets);
            this.Name = "ViewOwnTicketsForm";
            this.Text = "ViewOwnTicketsForm";
            this.Load += new System.EventHandler(this.ViewOwnTicketsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView LstViewOwnTickets;
        private Label lblViewOwnTickets;
        private ColumnHeader cHId;
        private ColumnHeader cHSubject;
        private ColumnHeader cHDate;
        private ColumnHeader cHResolvedOrNot;
        private ColumnHeader cHPriority;
        private ColumnHeader chDeadline;
        private Label lblTicketDescription;
        private TextBox txtBoxOwnTicketDescription;
    }
}