using Model;
using System.Security.Cryptography.X509Certificates;
using View.Forms;

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
            User currentUser = CurrentUser.GetInstance().GetUser();
            if (currentUser.UserType == UserType.ServiceDesk)
            {
                OpenChildForm(new Forms.ServiceDaskReadTickets(this), sender);
            }
            else
            {
                OpenChildForm(new Forms.DashboardForm(), sender);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServiceDaskReadTickets(this), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserManagementForum(this),sender);
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServiceDaskCreateTickets(this), sender);
        }
    }

}