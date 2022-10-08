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

        public UserManagementForum(MainForm mainForm)
        {   
            userLoginController = new UserLoginController();
            this.mainForm = mainForm;
            InitializeComponent();
            LoadTable();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void LoadTable()
        {
            listViewUsers.Items.Clear();
            List<User> users = userLoginController.GetUserList();
            foreach (User user in users)
            {
                ListViewItem li = new ListViewItem(user._id.ToString());
                li.SubItems.Add(user.Email);
                li.SubItems.Add(user.FirstName);
                li.SubItems.Add(user.LastName);
                li.SubItems.Add("NOT AVAILABLE YET! ");
                li.Tag = user;
                listViewUsers.Items.Add(li);
            }
        }
    }
}
