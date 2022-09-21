namespace View
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }
        //Open a child form
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChild.Controls.Add(childForm);
            this.pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardForm(), sender);
        }
    }

}