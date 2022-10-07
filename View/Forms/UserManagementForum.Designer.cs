namespace View.Forms
{
    partial class UserManagementForum
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFilterMail = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Firstname = new System.Windows.Forms.ColumnHeader();
            this.Lastname = new System.Windows.Forms.ColumnHeader();
            this.tickets = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "User management";
            // 
            // txtBoxFilterMail
            // 
            this.txtBoxFilterMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxFilterMail.Location = new System.Drawing.Point(96, 106);
            this.txtBoxFilterMail.Multiline = true;
            this.txtBoxFilterMail.Name = "txtBoxFilterMail";
            this.txtBoxFilterMail.Size = new System.Drawing.Size(180, 36);
            this.txtBoxFilterMail.TabIndex = 1;
            this.txtBoxFilterMail.Text = "Filer by email";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.Location = new System.Drawing.Point(645, 99);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(113, 43);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "+ADD NEW USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.Firstname,
            this.Lastname,
            this.tickets});
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(84, 168);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(709, 291);
            this.listViewUsers.TabIndex = 2;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 160;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 180;
            // 
            // Firstname
            // 
            this.Firstname.Text = "First name";
            this.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Firstname.Width = 150;
            // 
            // Lastname
            // 
            this.Lastname.Text = "Last name";
            this.Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lastname.Width = 150;
            // 
            // tickets
            // 
            this.tickets.Text = "# tickets";
            // 
            // UserManagementForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 592);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtBoxFilterMail);
            this.Controls.Add(this.label1);
            this.Name = "UserManagementForum";
            this.Text = "UserManagementForum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxFilterMail;
        private Button btnAddUser;
        private ListView listViewUsers;
        private ColumnHeader ID;
        private ColumnHeader Email;
        private ColumnHeader Firstname;
        private ColumnHeader Lastname;
        private ColumnHeader tickets;
    }
}