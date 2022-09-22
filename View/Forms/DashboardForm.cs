using Controller;
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
        private TicketCRUDController controller;
        public DashboardForm()
        {
            InitializeComponent();

            controller = new TicketCRUDController();

            pnlUnresolved.Width = flowLayoutPanel1.Width / 2 - 16;
            pnlDeadline.Width = flowLayoutPanel1.Width / 2 - 16;

            unresolvedBar.Value = 25;
            unresolvedBar.Location = new Point((pnlUnresolved.Width - unresolvedBar.Width) / 2, (pnlUnresolved.Height - unresolvedBar.Height) / 2 + 20);

            deadlineBar.Value = 25;
            deadlineBar.Location = new Point((pnlDeadline.Width - deadlineBar.Width) / 2, (pnlDeadline.Height - deadlineBar.Height) / 2 + 20);
            Init();

        }
        private void Init()
        {
            (int total, int unresolved) unresolvedData = controller.GetUnresolvedIncidents();
            int incidentsPastDeadline = controller.GetIncidentsPastDeadline();

            unresolvedBar.Value = unresolvedData.unresolved;
            unresolvedBar.Maximum = unresolvedData.total;
            unresolvedBar.Text = $"{unresolvedData.unresolved}/{unresolvedData.total}";

            deadlineBar.Value = incidentsPastDeadline;
            deadlineBar.Maximum = unresolvedData.unresolved;
            deadlineBar.Text = $"{incidentsPastDeadline}/{unresolvedData.unresolved}";


            /*HttpClient client = new HttpClient();

            await DownloadPageAsync();*/
        }
        static async Task DownloadPageAsync()
        {
            // Use static HttpClient to avoid exhausting system resources for network connections.
            var result = await client.GetAsync("https://localhost:7151/WeatherForecast");
            // Write status code.
            Debug.WriteLine("STATUS CODE: " + result.StatusCode);
        }
    }
}
