namespace View.Forms
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUnresolved = new System.Windows.Forms.Panel();
            this.unresolvedBar = new View.ExtraControl.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDeadline = new System.Windows.Forms.Panel();
            this.deadlineBar = new View.ExtraControl.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlUnresolved.SuspendLayout();
            this.pnlDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 51);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(851, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Incidents";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlUnresolved);
            this.flowLayoutPanel1.Controls.Add(this.pnlDeadline);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1055, 1074);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlUnresolved
            // 
            this.pnlUnresolved.Controls.Add(this.unresolvedBar);
            this.pnlUnresolved.Controls.Add(this.label3);
            this.pnlUnresolved.Controls.Add(this.label2);
            this.pnlUnresolved.Location = new System.Drawing.Point(4, 54);
            this.pnlUnresolved.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUnresolved.Name = "pnlUnresolved";
            this.pnlUnresolved.Padding = new System.Windows.Forms.Padding(5);
            this.pnlUnresolved.Size = new System.Drawing.Size(449, 459);
            this.pnlUnresolved.TabIndex = 0;
            // 
            // unresolvedBar
            // 
            this.unresolvedBar.BackColor = System.Drawing.SystemColors.Control;
            this.unresolvedBar.BarColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unresolvedBar.BarColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unresolvedBar.BarWidth = 14F;
            this.unresolvedBar.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unresolvedBar.ForeColor = System.Drawing.Color.Black;
            this.unresolvedBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.unresolvedBar.LineColor = System.Drawing.Color.DimGray;
            this.unresolvedBar.LineWidth = 1;
            this.unresolvedBar.Location = new System.Drawing.Point(75, 119);
            this.unresolvedBar.Maximum = ((long)(100));
            this.unresolvedBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.unresolvedBar.Name = "unresolvedBar";
            this.unresolvedBar.ProgressShape = View.ExtraControl.CircularProgressBar._ProgressShape.Round;
            this.unresolvedBar.Size = new System.Drawing.Size(285, 285);
            this.unresolvedBar.TabIndex = 3;
            this.unresolvedBar.Text = "57";
            this.unresolvedBar.TextMode = View.ExtraControl.CircularProgressBar._TextMode.Custom;
            this.unresolvedBar.Value = ((long)(57));
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "All tickets currently open";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unresolved Incidents";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDeadline
            // 
            this.pnlDeadline.Controls.Add(this.deadlineBar);
            this.pnlDeadline.Controls.Add(this.label5);
            this.pnlDeadline.Controls.Add(this.label4);
            this.pnlDeadline.Location = new System.Drawing.Point(482, 54);
            this.pnlDeadline.Margin = new System.Windows.Forms.Padding(25, 4, 4, 4);
            this.pnlDeadline.Name = "pnlDeadline";
            this.pnlDeadline.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDeadline.Size = new System.Drawing.Size(525, 459);
            this.pnlDeadline.TabIndex = 1;
            // 
            // deadlineBar
            // 
            this.deadlineBar.BackColor = System.Drawing.SystemColors.Control;
            this.deadlineBar.BarColor1 = System.Drawing.Color.Red;
            this.deadlineBar.BarColor2 = System.Drawing.Color.Red;
            this.deadlineBar.BarWidth = 14F;
            this.deadlineBar.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deadlineBar.ForeColor = System.Drawing.Color.Black;
            this.deadlineBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.deadlineBar.LineColor = System.Drawing.Color.DimGray;
            this.deadlineBar.LineWidth = 1;
            this.deadlineBar.Location = new System.Drawing.Point(101, 137);
            this.deadlineBar.Maximum = ((long)(100));
            this.deadlineBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.deadlineBar.Name = "deadlineBar";
            this.deadlineBar.ProgressShape = View.ExtraControl.CircularProgressBar._ProgressShape.Round;
            this.deadlineBar.Size = new System.Drawing.Size(285, 285);
            this.deadlineBar.TabIndex = 4;
            this.deadlineBar.Text = "57";
            this.deadlineBar.TextMode = View.ExtraControl.CircularProgressBar._TextMode.Custom;
            this.deadlineBar.Value = ((long)(57));
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(5, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "These tickets need your immediate attention";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Incidents past deadline";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 1121);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlUnresolved.ResumeLayout(false);
            this.pnlDeadline.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlUnresolved;
        private Panel pnlDeadline;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ExtraControl.CircularProgressBar unresolvedBar;
        private ExtraControl.CircularProgressBar deadlineBar;
    }
}