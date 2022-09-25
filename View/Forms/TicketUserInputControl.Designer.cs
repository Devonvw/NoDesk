namespace View.Forms
{
    partial class TicketUserInputControl
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
            this.submitTicketButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.dateTimeReportedDTP = new System.Windows.Forms.DateTimePicker();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.subjectOfIncidentTB = new System.Windows.Forms.TextBox();
            this.priorityCB = new System.Windows.Forms.ComboBox();
            this.reportedByUserCB = new System.Windows.Forms.ComboBox();
            this.typeOfIncidentCB = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineFollowUpLabel = new System.Windows.Forms.Label();
            this.typeOfIncidentLabel = new System.Windows.Forms.Label();
            this.reportedByUserLabel = new System.Windows.Forms.Label();
            this.pryorityLabel = new System.Windows.Forms.Label();
            this.subjectOfIincidentLabel = new System.Windows.Forms.Label();
            this.dateTimeReportedLabel = new System.Windows.Forms.Label();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.deadlineFollowUpDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitTicketButton
            // 
            this.submitTicketButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitTicketButton.Location = new System.Drawing.Point(517, 553);
            this.submitTicketButton.Name = "submitTicketButton";
            this.submitTicketButton.Size = new System.Drawing.Size(140, 40);
            this.submitTicketButton.TabIndex = 33;
            this.submitTicketButton.Text = "submit ticket";
            this.submitTicketButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(357, 553);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 32;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // dateTimeReportedDTP
            // 
            this.dateTimeReportedDTP.Location = new System.Drawing.Point(357, 136);
            this.dateTimeReportedDTP.Name = "dateTimeReportedDTP";
            this.dateTimeReportedDTP.Size = new System.Drawing.Size(300, 23);
            this.dateTimeReportedDTP.TabIndex = 31;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(357, 377);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(300, 170);
            this.descriptionTB.TabIndex = 29;
            // 
            // subjectOfIncidentTB
            // 
            this.subjectOfIncidentTB.Location = new System.Drawing.Point(357, 177);
            this.subjectOfIncidentTB.Name = "subjectOfIncidentTB";
            this.subjectOfIncidentTB.Size = new System.Drawing.Size(300, 23);
            this.subjectOfIncidentTB.TabIndex = 28;
            // 
            // priorityCB
            // 
            this.priorityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityCB.FormattingEnabled = true;
            this.priorityCB.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.priorityCB.Location = new System.Drawing.Point(357, 297);
            this.priorityCB.Name = "priorityCB";
            this.priorityCB.Size = new System.Drawing.Size(300, 23);
            this.priorityCB.TabIndex = 27;
            // 
            // reportedByUserCB
            // 
            this.reportedByUserCB.FormattingEnabled = true;
            this.reportedByUserCB.Location = new System.Drawing.Point(357, 256);
            this.reportedByUserCB.Name = "reportedByUserCB";
            this.reportedByUserCB.Size = new System.Drawing.Size(300, 23);
            this.reportedByUserCB.TabIndex = 26;
            // 
            // typeOfIncidentCB
            // 
            this.typeOfIncidentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfIncidentCB.FormattingEnabled = true;
            this.typeOfIncidentCB.Items.AddRange(new object[] {
            "Software",
            "HardWare",
            "Service"});
            this.typeOfIncidentCB.Location = new System.Drawing.Point(357, 216);
            this.typeOfIncidentCB.Name = "typeOfIncidentCB";
            this.typeOfIncidentCB.Size = new System.Drawing.Size(300, 23);
            this.typeOfIncidentCB.TabIndex = 25;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(171, 377);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(116, 22);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Description :";
            // 
            // deadlineFollowUpLabel
            // 
            this.deadlineFollowUpLabel.AutoSize = true;
            this.deadlineFollowUpLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deadlineFollowUpLabel.Location = new System.Drawing.Point(171, 337);
            this.deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            this.deadlineFollowUpLabel.Size = new System.Drawing.Size(180, 22);
            this.deadlineFollowUpLabel.TabIndex = 23;
            this.deadlineFollowUpLabel.Text = "Deadline/ follow up :";
            // 
            // typeOfIncidentLabel
            // 
            this.typeOfIncidentLabel.AutoSize = true;
            this.typeOfIncidentLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeOfIncidentLabel.Location = new System.Drawing.Point(171, 217);
            this.typeOfIncidentLabel.Name = "typeOfIncidentLabel";
            this.typeOfIncidentLabel.Size = new System.Drawing.Size(159, 22);
            this.typeOfIncidentLabel.TabIndex = 22;
            this.typeOfIncidentLabel.Text = "Type of incident : ";
            // 
            // reportedByUserLabel
            // 
            this.reportedByUserLabel.AutoSize = true;
            this.reportedByUserLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportedByUserLabel.Location = new System.Drawing.Point(171, 257);
            this.reportedByUserLabel.Name = "reportedByUserLabel";
            this.reportedByUserLabel.Size = new System.Drawing.Size(167, 22);
            this.reportedByUserLabel.TabIndex = 21;
            this.reportedByUserLabel.Text = "Reported by user :";
            // 
            // pryorityLabel
            // 
            this.pryorityLabel.AutoSize = true;
            this.pryorityLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pryorityLabel.Location = new System.Drawing.Point(171, 297);
            this.pryorityLabel.Name = "pryorityLabel";
            this.pryorityLabel.Size = new System.Drawing.Size(78, 22);
            this.pryorityLabel.TabIndex = 20;
            this.pryorityLabel.Text = "Priority :";
            // 
            // subjectOfIincidentLabel
            // 
            this.subjectOfIincidentLabel.AutoSize = true;
            this.subjectOfIincidentLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectOfIincidentLabel.Location = new System.Drawing.Point(171, 177);
            this.subjectOfIincidentLabel.Name = "subjectOfIincidentLabel";
            this.subjectOfIincidentLabel.Size = new System.Drawing.Size(181, 22);
            this.subjectOfIincidentLabel.TabIndex = 19;
            this.subjectOfIincidentLabel.Text = "Subject of incident : ";
            // 
            // dateTimeReportedLabel
            // 
            this.dateTimeReportedLabel.AutoSize = true;
            this.dateTimeReportedLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeReportedLabel.Location = new System.Drawing.Point(171, 137);
            this.dateTimeReportedLabel.Name = "dateTimeReportedLabel";
            this.dateTimeReportedLabel.Size = new System.Drawing.Size(183, 22);
            this.dateTimeReportedLabel.TabIndex = 18;
            this.dateTimeReportedLabel.Text = "Date/time reported : ";
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageTitleLabel.Location = new System.Drawing.Point(156, 34);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(144, 51);
            this.pageTitleLabel.TabIndex = 34;
            this.pageTitleLabel.Text = "label1";
            // 
            // deadlineFollowUpDTP
            // 
            this.deadlineFollowUpDTP.Location = new System.Drawing.Point(357, 337);
            this.deadlineFollowUpDTP.Name = "deadlineFollowUpDTP";
            this.deadlineFollowUpDTP.Size = new System.Drawing.Size(300, 23);
            this.deadlineFollowUpDTP.TabIndex = 35;
            // 
            // TicketUserInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 646);
            this.Controls.Add(this.deadlineFollowUpDTP);
            this.Controls.Add(this.pageTitleLabel);
            this.Controls.Add(this.submitTicketButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dateTimeReportedDTP);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.subjectOfIncidentTB);
            this.Controls.Add(this.priorityCB);
            this.Controls.Add(this.reportedByUserCB);
            this.Controls.Add(this.typeOfIncidentCB);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.deadlineFollowUpLabel);
            this.Controls.Add(this.typeOfIncidentLabel);
            this.Controls.Add(this.reportedByUserLabel);
            this.Controls.Add(this.pryorityLabel);
            this.Controls.Add(this.subjectOfIincidentLabel);
            this.Controls.Add(this.dateTimeReportedLabel);
            this.Name = "TicketUserInputControl";
            this.Text = "TicketUserInputControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Button submitTicketButton;
        private Button CancelButton;
        protected DateTimePicker dateTimeReportedDTP;
        protected TextBox descriptionTB;
        protected TextBox subjectOfIncidentTB;
        protected ComboBox priorityCB;
        protected ComboBox reportedByUserCB;
        protected ComboBox typeOfIncidentCB;
        private Label descriptionLabel;
        private Label deadlineFollowUpLabel;
        private Label typeOfIncidentLabel;
        private Label reportedByUserLabel;
        private Label pryorityLabel;
        private Label subjectOfIincidentLabel;
        private Label dateTimeReportedLabel;
        private Label pageTitleLabel;
        protected DateTimePicker deadlineFollowUpDTP;
    }
}