using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class AddUser : Form
    {
       
        public AddUser( )
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //UserManagementForum userManagementForum = new UserManagementForum();
            //userManagementForum.Show();
        }

        public bool EmailValidator(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }


        private void lblShowPassword_Click_1(object sender, EventArgs e)
        {
            if (txtBoxPassword.PasswordChar == '*')
            {
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void txtBoxPhonenumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtBoxFirstname.Text.Length != 0 && txtBoxLastname.Text.Length != 0 && txtBoxEmail.Text.Length != 0 && txtBoxPassword.Text.Length != 0 && txtBoxUsername.Text.Length != 0 && txtBoxPhonenumber.Text.Length != 0 && txtBoxLocation.Text.Length != 0 && comboBoxUserType.SelectedIndex > -1)
            {
                Model.User userToBeCreated = new Model.User(txtBoxFirstname.Text, txtBoxLastname.Text, txtBoxUsername.Text, txtBoxPassword.Text);
                if (EmailValidator(txtBoxEmail.Text))
                {
                    userToBeCreated.Email = txtBoxEmail.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Email Please try again");
                    return;
                }

                if (comboBoxUserType.Text == "Service Desk")
                    userToBeCreated.UserType = Model.UserType.ServiceDesk;
                else
                {
                    userToBeCreated.UserType = Model.UserType.Regular;
                }
                
                userToBeCreated.PhoneNumber = int.Parse(txtBoxPhonenumber.Text);

                userToBeCreated.Location = txtBoxLocation.Text;

                UserLoginController loginController = new UserLoginController();
                loginController.CreateUser(userToBeCreated);
                MessageBox.Show($"User created \nUsername: {userToBeCreated.UserName} \nEmail: {userToBeCreated.Email} \nUser type: {userToBeCreated.UserType.ToString()}");
                this.Close();
            }
            else
                MessageBox.Show("Please fill every box!");
        }
    }
}
