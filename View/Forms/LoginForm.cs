using Controller;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using User = Model.User;
using MongoDB.Bson.Serialization;

namespace View.Forms
{
    public partial class LoginForm : Form
    {

        UserLoginController userLoginController;

        public LoginForm()
        {
            userLoginController = new UserLoginController();
            InitializeComponent();
        }

        private void lblForgotLoginDetails_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();

        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = txtUsername.Text;

            User user = BsonSerializer.Deserialize<Model.User>(userLoginController.GetUser(userName));

            
            if (userName == user.UserName)
            {
                MessageBox.Show(user.ToString());
            }
            else
            {
                MessageBox.Show("Fail");
            }
            
            
        
        }
    }
}
