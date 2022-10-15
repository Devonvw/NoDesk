using Controller;
using MongoDB.Bson.Serialization;
using User = Model.User;

namespace View.Forms
{
    public partial class LoginForm : Form
    {

        UserLoginController userLoginController;
        User user;

        public LoginForm()
        {
            userLoginController = new UserLoginController();
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtPass.Text == "" || txtUsername.Text == "")
                {
                    MessageBox.Show("You did not enter a username and/or password");
                    return;
                }
                

                string userName = txtUsername.Text;
                string passWord = txtPass.Text;


                user = BsonSerializer.Deserialize<Model.User>(userLoginController.GetUser(userName));
                

                ChechLoginInfo(userName, new Model.PasswordHasher(passWord).HashedPassword, user);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again", ex.Message);
            }

        }

        private void lblForgotLoginDetails_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length != 0)
            {
                ForgotPassword forgotPassword = new ForgotPassword(new User(userLoginController.GetUser(txtUsername.Text)));
                forgotPassword.ShowDialog();

            }
            else
            {
                ForgotPassword forgotPasswordForm = new ForgotPassword();
                forgotPasswordForm.ShowDialog();
                
            }
        }


        private void ChechLoginInfo(string userName, string passWord, User user)
        {
         
            

                if (userName == user.UserName && passWord == user.Password)
                {
                    CheckUserType(user);                
                }
                else
                {
                    MessageBox.Show("You entered the wrong user name and/or password. \nPlease try again.");
                }
            
        }

        public void CheckUserType(User user)
        {
            MainForm mainForm = new MainForm();
            ServiceDaskReadTickets serviceDaskReadTickets = new ServiceDaskReadTickets(mainForm);

            if (user.UserType == Model.UserType.Regular)
            {
                mainForm.Show();
                mainForm.btnUserManagement.Enabled = false;
                this.Hide();
            }
            else
            {
                mainForm.btnDashboard.Enabled = false;
                mainForm.Show();
                this.Hide();
            }

           
        }

        private void lblShowHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
