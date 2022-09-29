namespace View.Forms
{
    partial class AddUser
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
            this.lblCreateUserHeader = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblTypeOfUser = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFirstname = new System.Windows.Forms.TextBox();
            this.txtBoxLastname = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCreateUserHeader
            // 
            this.lblCreateUserHeader.AutoSize = true;
            this.lblCreateUserHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateUserHeader.Location = new System.Drawing.Point(186, 103);
            this.lblCreateUserHeader.Name = "lblCreateUserHeader";
            this.lblCreateUserHeader.Size = new System.Drawing.Size(171, 30);
            this.lblCreateUserHeader.TabIndex = 0;
            this.lblCreateUserHeader.Text = "Create new User";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(198, 161);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(65, 15);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname: ";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(198, 195);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 15);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname: ";
            // 
            // lblTypeOfUser
            // 
            this.lblTypeOfUser.AutoSize = true;
            this.lblTypeOfUser.Location = new System.Drawing.Point(198, 231);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(73, 15);
            this.lblTypeOfUser.TabIndex = 3;
            this.lblTypeOfUser.Text = "Type of user:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(198, 264);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email address: ";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(198, 297);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(92, 15);
            this.lblPhonenumber.TabIndex = 5;
            this.lblPhonenumber.Text = "Phone number: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(198, 326);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(95, 15);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location/branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // txtBoxFirstname
            // 
            this.txtBoxFirstname.Location = new System.Drawing.Point(322, 153);
            this.txtBoxFirstname.Name = "txtBoxFirstname";
            this.txtBoxFirstname.Size = new System.Drawing.Size(135, 23);
            this.txtBoxFirstname.TabIndex = 8;
            // 
            // txtBoxLastname
            // 
            this.txtBoxLastname.Location = new System.Drawing.Point(322, 187);
            this.txtBoxLastname.Name = "txtBoxLastname";
            this.txtBoxLastname.Size = new System.Drawing.Size(135, 23);
            this.txtBoxLastname.TabIndex = 9;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(322, 256);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(135, 23);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // txtBoxPhonenumber
            // 
            this.txtBoxPhonenumber.Location = new System.Drawing.Point(322, 289);
            this.txtBoxPhonenumber.Name = "txtBoxPhonenumber";
            this.txtBoxPhonenumber.Size = new System.Drawing.Size(135, 23);
            this.txtBoxPhonenumber.TabIndex = 11;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(322, 318);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(135, 23);
            this.txtBoxLocation.TabIndex = 12;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(322, 356);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(135, 23);
            this.txtBoxPassword.TabIndex = 13;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.Location = new System.Drawing.Point(331, 425);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(126, 47);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(198, 425);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 47);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Regular ",
            "Service Desk"});
            this.comboBox1.Location = new System.Drawing.Point(321, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 535);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.txtBoxPhonenumber);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLastname);
            this.Controls.Add(this.txtBoxFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTypeOfUser);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblCreateUserHeader);
            this.Name = "AddUser";
            this.Text = "Add User ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreateUserHeader;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblTypeOfUser;
        private Label lblEmail;
        private Label lblPhonenumber;
        private Label lblLocation;
        private Label label1;
        private TextBox txtBoxFirstname;
        private TextBox txtBoxLastname;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPhonenumber;
        private TextBox txtBoxLocation;
        private TextBox txtBoxPassword;
        private Button btnAddUser;
        private Button btnBack;
        private ComboBox comboBox1;
    }
}