using Model;

namespace View.Forms
{
    partial class CreateUpdateUserInput
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
            this.reportedByUserCB = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineFollowUpLabel = new System.Windows.Forms.Label();
            this.typeOfIncidentLabel = new System.Windows.Forms.Label();
            this.reportedByUserLabel = new System.Windows.Forms.Label();
            this.pryorityLabel = new System.Windows.Forms.Label();
            this.subjectOfIincidentLabel = new System.Windows.Forms.Label();
            this.dateTimeReportedLabel = new System.Windows.Forms.Label();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.deadlineFollowUpDTP = new System.Windows.Forms.DateTimePicker();
            this.softwareRB = new System.Windows.Forms.RadioButton();
            this.hardwareRB = new System.Windows.Forms.RadioButton();
            this.ServiceRB = new System.Windows.Forms.RadioButton();
            this.HighRB = new System.Windows.Forms.RadioButton();
            this.normalRB = new System.Windows.Forms.RadioButton();
            this.lowRB = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
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
            // reportedByUserCB
            // 
            this.reportedByUserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportedByUserCB.FormattingEnabled = true;
            this.reportedByUserCB.Location = new System.Drawing.Point(357, 256);
            this.reportedByUserCB.Name = "reportedByUserCB";
            this.reportedByUserCB.Size = new System.Drawing.Size(300, 23);
            this.reportedByUserCB.TabIndex = 26;
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
            // softwareRB
            // 
            this.softwareRB.AutoSize = true;
            this.softwareRB.Location = new System.Drawing.Point(3, 2);
            this.softwareRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.softwareRB.Name = "softwareRB";
            this.softwareRB.Size = new System.Drawing.Size(71, 19);
            this.softwareRB.TabIndex = 36;
            this.softwareRB.Text = "Software";
            this.softwareRB.UseVisualStyleBackColor = true;
            // 
            // hardwareRB
            // 
            this.hardwareRB.AutoSize = true;
            this.hardwareRB.Location = new System.Drawing.Point(80, 2);
            this.hardwareRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hardwareRB.Name = "hardwareRB";
            this.hardwareRB.Size = new System.Drawing.Size(76, 19);
            this.hardwareRB.TabIndex = 37;
            this.hardwareRB.Text = "Hardware";
            this.hardwareRB.UseVisualStyleBackColor = true;
            // 
            // ServiceRB
            // 
            this.ServiceRB.AutoSize = true;
            this.ServiceRB.Location = new System.Drawing.Point(162, 2);
            this.ServiceRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceRB.Name = "ServiceRB";
            this.ServiceRB.Size = new System.Drawing.Size(62, 19);
            this.ServiceRB.TabIndex = 38;
            this.ServiceRB.Text = "Service";
            this.ServiceRB.UseVisualStyleBackColor = true;
            // 
            // HighRB
            // 
            this.HighRB.AutoSize = true;
            this.HighRB.Location = new System.Drawing.Point(127, 2);
            this.HighRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HighRB.Name = "HighRB";
            this.HighRB.Size = new System.Drawing.Size(51, 19);
            this.HighRB.TabIndex = 41;
            this.HighRB.Tag = Model.Priority.High;
            this.HighRB.Text = "High";
            this.HighRB.UseVisualStyleBackColor = true;
            // 
            // normalRB
            // 
            this.normalRB.AutoSize = true;
            this.normalRB.Location = new System.Drawing.Point(56, 2);
            this.normalRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.normalRB.Name = "normalRB";
            this.normalRB.Size = new System.Drawing.Size(65, 19);
            this.normalRB.TabIndex = 40;
            this.normalRB.Tag = Model.Priority.Normal;
            this.normalRB.Text = "Normal";
            this.normalRB.UseVisualStyleBackColor = true;
            // 
            // lowRB
            // 
            this.lowRB.AutoSize = true;
            this.lowRB.Location = new System.Drawing.Point(3, 2);
            this.lowRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowRB.Name = "lowRB";
            this.lowRB.Size = new System.Drawing.Size(47, 19);
            this.lowRB.TabIndex = 39;
            this.lowRB.Tag = Model.Priority.Low;
            this.lowRB.Text = "Low";
            this.lowRB.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.softwareRB);
            this.flowLayoutPanel1.Controls.Add(this.hardwareRB);
            this.flowLayoutPanel1.Controls.Add(this.ServiceRB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(358, 216);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 21);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lowRB);
            this.flowLayoutPanel2.Controls.Add(this.normalRB);
            this.flowLayoutPanel2.Controls.Add(this.HighRB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(357, 296);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(247, 21);
            this.flowLayoutPanel2.TabIndex = 43;
            // 
            // CreateUpdateUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 646);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deadlineFollowUpDTP);
            this.Controls.Add(this.pageTitleLabel);
            this.Controls.Add(this.submitTicketButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dateTimeReportedDTP);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.subjectOfIncidentTB);
            this.Controls.Add(this.reportedByUserCB);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.deadlineFollowUpLabel);
            this.Controls.Add(this.typeOfIncidentLabel);
            this.Controls.Add(this.reportedByUserLabel);
            this.Controls.Add(this.pryorityLabel);
            this.Controls.Add(this.subjectOfIincidentLabel);
            this.Controls.Add(this.dateTimeReportedLabel);
            this.Name = "CreateUpdateUserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketUserInputControl";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Button submitTicketButton;
        private new Button CancelButton;
        protected DateTimePicker dateTimeReportedDTP;
        protected TextBox descriptionTB;
        protected TextBox subjectOfIncidentTB;
        protected ComboBox reportedByUserCB;
        private Label descriptionLabel;
        private Label deadlineFollowUpLabel;
        private Label typeOfIncidentLabel;
        private Label reportedByUserLabel;
        private Label pryorityLabel;
        private Label subjectOfIincidentLabel;
        private Label dateTimeReportedLabel;
        private Label pageTitleLabel;
        protected DateTimePicker deadlineFollowUpDTP;
        protected RadioButton softwareRB;
        protected RadioButton hardwareRB;
        protected RadioButton ServiceRB;
        protected RadioButton HighRB;
        protected RadioButton normalRB;
        protected RadioButton lowRB;
        protected FlowLayoutPanel flowLayoutPanel1;
        protected FlowLayoutPanel flowLayoutPanel2;
    }
}