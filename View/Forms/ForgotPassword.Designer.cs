namespace View.Forms
{
    partial class ForgotPassword
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
            this.lblShowHidePass = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretToken = new System.Windows.Forms.MaskedTextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChild
            // 
            this.pnlChild.AutoScroll = true;
            this.pnlChild.Controls.Add(this.label5);
            this.pnlChild.Controls.Add(this.lblShowHidePass);
            this.pnlChild.Controls.Add(this.btnResetPassword);
            this.pnlChild.Controls.Add(this.label3);
            this.pnlChild.Controls.Add(this.txtNewPassword);
            this.pnlChild.Controls.Add(this.label4);
            this.pnlChild.Controls.Add(this.txtSecretToken);
            this.pnlChild.Controls.Add(this.btnForgotPass);
            this.pnlChild.Controls.Add(this.label2);
            this.pnlChild.Controls.Add(this.txtUsername);
            this.pnlChild.Controls.Add(this.label1);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(0, 0);
            this.pnlChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(914, 600);
            this.pnlChild.TabIndex = 5;
            // 
            // lblShowHidePass
            // 
            this.lblShowHidePass.AutoSize = true;
            this.lblShowHidePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowHidePass.Location = new System.Drawing.Point(543, 356);
            this.lblShowHidePass.Name = "lblShowHidePass";
            this.lblShowHidePass.Size = new System.Drawing.Size(39, 28);
            this.lblShowHidePass.TabIndex = 10;
            this.lblShowHidePass.Text = "👁";
            this.lblShowHidePass.Click += new System.EventHandler(this.lblShowHidePass_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetPassword.Location = new System.Drawing.Point(303, 392);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(233, 44);
            this.btnResetPassword.TabIndex = 9;
            this.btnResetPassword.Text = "reset password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "New password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(303, 353);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(233, 27);
            this.txtNewPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(303, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secret token (check your email dont forget to check spam!)";
            // 
            // txtSecretToken
            // 
            this.txtSecretToken.Location = new System.Drawing.Point(303, 281);
            this.txtSecretToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecretToken.Name = "txtSecretToken";
            this.txtSecretToken.Size = new System.Drawing.Size(233, 27);
            this.txtSecretToken.TabIndex = 5;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForgotPass.Location = new System.Drawing.Point(303, 163);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(233, 51);
            this.btnForgotPass.TabIndex = 3;
            this.btnForgotPass.Text = "Send secret token to mail";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(303, 124);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoDesk: TGG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "(Case sensitive!)";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pnlChild);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.pnlChild.ResumeLayout(false);
            this.pnlChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlChild;
        private Button btnForgotPass;
        private Label label2;
        private MaskedTextBox txtUsername;
        private Label label1;
        private Label label4;
        private MaskedTextBox txtSecretToken;
        private Button btnResetPassword;
        private Label label3;
        private TextBox txtNewPassword;
        private Label lblShowHidePass;
        private Label label5;
    }
}