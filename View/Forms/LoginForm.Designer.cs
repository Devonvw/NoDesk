namespace View.Forms
{
    partial class LoginForm
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
            this.pnlChild = new System.Windows.Forms.Panel();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblForgotLoginDetails = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.MaskedTextBox();
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChild
            // 
            this.pnlChild.AutoScroll = true;
            this.pnlChild.Controls.Add(this.lblAddUser);
            this.pnlChild.Controls.Add(this.lblForgotLoginDetails);
            this.pnlChild.Controls.Add(this.btnLogin);
            this.pnlChild.Controls.Add(this.label5);
            this.pnlChild.Controls.Add(this.txtPass);
            this.pnlChild.Controls.Add(this.txtUsername);
            this.pnlChild.Controls.Add(this.label4);
            this.pnlChild.Controls.Add(this.label3);
            this.pnlChild.Controls.Add(this.label2);
            this.pnlChild.Controls.Add(this.label1);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(0, 48);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(800, 402);
            this.pnlChild.TabIndex = 3;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.ForeColor = System.Drawing.Color.Blue;
            this.lblAddUser.Location = new System.Drawing.Point(264, 288);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(48, 15);
            this.lblAddUser.TabIndex = 9;
            this.lblAddUser.Text = "Sign Up";
            this.lblAddUser.Click += new System.EventHandler(this.lblAddUser_Click);
            // 
            // lblForgotLoginDetails
            // 
            this.lblForgotLoginDetails.AutoSize = true;
            this.lblForgotLoginDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblForgotLoginDetails.Location = new System.Drawing.Point(411, 288);
            this.lblForgotLoginDetails.Name = "lblForgotLoginDetails";
            this.lblForgotLoginDetails.Size = new System.Drawing.Size(118, 15);
            this.lblForgotLoginDetails.TabIndex = 8;
            this.lblForgotLoginDetails.Text = "Forgot Login Details?";
            this.lblForgotLoginDetails.Click += new System.EventHandler(this.lblForgotLoginDetails_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(336, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(264, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(264, 262);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(265, 23);
            this.txtPass.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(264, 207);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 23);
            this.txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(301, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "NoDesk for the Garden Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(252, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please provide login credentials to login to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoDesk: TGG";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 48);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.pnlChild.ResumeLayout(false);
            this.pnlChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlChild;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblForgotLoginDetails;
        private Button btnLogin;
        private Label label5;
        private MaskedTextBox txtPass;
        private MaskedTextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblAddUser;
    }
}