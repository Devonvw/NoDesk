namespace View.Forms
{
    partial class TransferTicketForm
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
            this.lblCurrentTicket = new System.Windows.Forms.Label();
            this.lblChosenTicketShow = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransferTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentTicket
            // 
            this.lblCurrentTicket.AutoSize = true;
            this.lblCurrentTicket.Location = new System.Drawing.Point(64, 9);
            this.lblCurrentTicket.Name = "lblCurrentTicket";
            this.lblCurrentTicket.Size = new System.Drawing.Size(156, 15);
            this.lblCurrentTicket.TabIndex = 0;
            this.lblCurrentTicket.Text = "The ticket you have chosen: ";
            // 
            // lblChosenTicketShow
            // 
            this.lblChosenTicketShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChosenTicketShow.Location = new System.Drawing.Point(0, 0);
            this.lblChosenTicketShow.Name = "lblChosenTicketShow";
            this.lblChosenTicketShow.Size = new System.Drawing.Size(292, 229);
            this.lblChosenTicketShow.TabIndex = 1;
            this.lblChosenTicketShow.Text = "...";
            this.lblChosenTicketShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "To who would you like to transfer this ticket to";
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTransferTicket.Location = new System.Drawing.Point(64, 151);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(156, 45);
            this.btnTransferTicket.TabIndex = 4;
            this.btnTransferTicket.Text = "TRANSFER TICKET";
            this.btnTransferTicket.UseVisualStyleBackColor = false;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // TransferTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 229);
            this.Controls.Add(this.btnTransferTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChosenTicketShow);
            this.Controls.Add(this.lblCurrentTicket);
            this.Name = "TransferTicketForm";
            this.Text = "TransferTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCurrentTicket;
        private Label lblChosenTicketShow;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnTransferTicket;
    }
}