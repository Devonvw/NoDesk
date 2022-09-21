using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class DashboardForm : Form
    {
        public static HttpClient client = new HttpClient();
        public DashboardForm()
        {
            InitializeComponent();

            //Init();
            panel2.Width = flowLayoutPanel1.Width / 2 - 16;
            panel3.Width = flowLayoutPanel1.Width / 2 - 16;

            UnresolvedBar.Value = 25;
            UnresolvedBar.Location = new Point((panel2.Width - UnresolvedBar.Width) / 2, (panel2.Height - UnresolvedBar.Height) / 2 + 20);

            deadlineBar.Value = 25;
            deadlineBar.Location = new Point((panel3.Width - deadlineBar.Width) / 2, (panel3.Height - deadlineBar.Height) / 2 + 20);

        }
        private async void Init()
        {
            HttpClient client = new HttpClient();

            await DownloadPageAsync();
        }
        static async Task DownloadPageAsync()
        {
            // Use static HttpClient to avoid exhausting system resources for network connections.
            var result = await client.GetAsync("https://localhost:7151/WeatherForecast");
            // Write status code.
            Debug.WriteLine("STATUS CODE: " + result.StatusCode);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Magenta, ButtonBorderStyle.Solid);

        }
    }
}
