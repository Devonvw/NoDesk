using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View.Forms
{
    public partial class UserManagementForum : Form
    {
        MainForm mainForm;
        UserLoginController userLoginController;
        TicketCRUDController ticketCRUDController;
        public UserManagementForum(MainForm mainForm)
        {   
            ticketCRUDController = new TicketCRUDController();
            userLoginController = new UserLoginController();
            this.mainForm = mainForm;
            InitializeComponent();
            List<User> allUsers = userLoginController.GetUserList();
            LoadTable(allUsers);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void LoadTable(List<User> users)
        {
            listViewUsers.Items.Clear();
            foreach (User user in users)
            {
                ListViewItem li = new ListViewItem(user._id.ToString());
                li.SubItems.Add(user.Email);
                li.SubItems.Add(user.FirstName);
                li.SubItems.Add(user.LastName);
                li.SubItems.Add(ticketCRUDController.GetCountOfTicketsOnUser(user).ToString());
                li.Tag = user;
                listViewUsers.Items.Add(li);
            }
        }

        private void txtBoxFilterMail_TextChanged(object sender, EventArgs e)
        {
            listViewUsers.Items.Clear();
            LoadTable(userLoginController.GetUserEmail(txtBoxFilterMail.Text));
        }

        private void UserManagementForum_Load(object sender, EventArgs e)
        {

        }
    }
}
