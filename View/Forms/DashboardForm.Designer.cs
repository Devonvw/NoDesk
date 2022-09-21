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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UnresolvedBar = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deadlineBar = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 41);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(669, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 55);
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
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Incidents";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(812, 859);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UnresolvedBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(359, 367);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UnresolvedBar
            // 
            this.UnresolvedBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.UnresolvedBar.AnimationSpeed = 500;
            this.UnresolvedBar.BackColor = System.Drawing.Color.Transparent;
            this.UnresolvedBar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnresolvedBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnresolvedBar.InnerColor = System.Drawing.SystemColors.Control;
            this.UnresolvedBar.InnerMargin = 2;
            this.UnresolvedBar.InnerWidth = -1;
            this.UnresolvedBar.Location = new System.Drawing.Point(53, 80);
            this.UnresolvedBar.MarqueeAnimationSpeed = 2000;
            this.UnresolvedBar.Name = "UnresolvedBar";
            this.UnresolvedBar.OuterColor = System.Drawing.Color.Silver;
            this.UnresolvedBar.OuterMargin = -25;
            this.UnresolvedBar.OuterWidth = 26;
            this.UnresolvedBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UnresolvedBar.ProgressWidth = 22;
            this.UnresolvedBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnresolvedBar.Size = new System.Drawing.Size(247, 237);
            this.UnresolvedBar.StartAngle = 270;
            this.UnresolvedBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UnresolvedBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.UnresolvedBar.SubscriptText = "";
            this.UnresolvedBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UnresolvedBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.UnresolvedBar.SuperscriptText = "";
            this.UnresolvedBar.TabIndex = 3;
            this.UnresolvedBar.Text = "7/15";
            this.UnresolvedBar.TextMargin = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.UnresolvedBar.Value = 68;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "All tickets currently open";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unresolved Incidents";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deadlineBar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(385, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(420, 367);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // deadlineBar
            // 
            this.deadlineBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.deadlineBar.AnimationSpeed = 500;
            this.deadlineBar.BackColor = System.Drawing.Color.Transparent;
            this.deadlineBar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deadlineBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deadlineBar.InnerColor = System.Drawing.SystemColors.Control;
            this.deadlineBar.InnerMargin = 2;
            this.deadlineBar.InnerWidth = -1;
            this.deadlineBar.Location = new System.Drawing.Point(86, 98);
            this.deadlineBar.MarqueeAnimationSpeed = 2000;
            this.deadlineBar.Name = "deadlineBar";
            this.deadlineBar.OuterColor = System.Drawing.Color.Silver;
            this.deadlineBar.OuterMargin = -25;
            this.deadlineBar.OuterWidth = 26;
            this.deadlineBar.ProgressColor = System.Drawing.Color.Red;
            this.deadlineBar.ProgressWidth = 22;
            this.deadlineBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deadlineBar.Size = new System.Drawing.Size(247, 237);
            this.deadlineBar.StartAngle = 270;
            this.deadlineBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.deadlineBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.deadlineBar.SubscriptText = "";
            this.deadlineBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.deadlineBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.deadlineBar.SuperscriptText = "";
            this.deadlineBar.TabIndex = 4;
            this.deadlineBar.Text = "1";
            this.deadlineBar.TextMargin = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.deadlineBar.Value = 68;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "These tickets need your immediate attention";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Incidents past deadline";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 897);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private CircularProgressBar.CircularProgressBar UnresolvedBar;
        private CircularProgressBar.CircularProgressBar deadlineBar;
    }
}