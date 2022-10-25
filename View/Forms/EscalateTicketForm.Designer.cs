namespace View.Forms
{
    partial class EscalateTicketForm
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
            this.comboBoxServiceDeskUser = new System.Windows.Forms.ComboBox();
            this.btnEscalate = new System.Windows.Forms.Button();
            this.labelShowTicket = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxServiceDeskUser
            // 
            this.comboBoxServiceDeskUser.FormattingEnabled = true;
            this.comboBoxServiceDeskUser.Location = new System.Drawing.Point(66, 144);
            this.comboBoxServiceDeskUser.Name = "comboBoxServiceDeskUser";
            this.comboBoxServiceDeskUser.Size = new System.Drawing.Size(183, 23);
            this.comboBoxServiceDeskUser.TabIndex = 0;
            // 
            // btnEscalate
            // 
            this.btnEscalate.Location = new System.Drawing.Point(12, 190);
            this.btnEscalate.Name = "btnEscalate";
            this.btnEscalate.Size = new System.Drawing.Size(143, 51);
            this.btnEscalate.TabIndex = 1;
            this.btnEscalate.Text = "ESCALATE";
            this.btnEscalate.UseVisualStyleBackColor = true;
            this.btnEscalate.Click += new System.EventHandler(this.btnEscalate_Click);
            // 
            // labelShowTicket
            // 
            this.labelShowTicket.AutoSize = true;
            this.labelShowTicket.Location = new System.Drawing.Point(12, 19);
            this.labelShowTicket.Name = "labelShowTicket";
            this.labelShowTicket.Size = new System.Drawing.Size(86, 15);
            this.labelShowTicket.TabIndex = 2;
            this.labelShowTicket.Text = "Selected ticket:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(161, 190);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 51);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EscalateTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelShowTicket);
            this.Controls.Add(this.btnEscalate);
            this.Controls.Add(this.comboBoxServiceDeskUser);
            this.Name = "EscalateTicketForm";
            this.Text = "EscalateTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxServiceDeskUser;
        private Button btnEscalate;
        private Label labelShowTicket;
        private Button buttonBack;
    }
}