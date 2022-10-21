using Controller;
using MongoDB.Bson.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Model;

namespace View.Forms
{
    public partial class LoginForm : Form
    {

        UserLoginController userLoginController;
        User user;
        MainForm mainForm;

        public LoginForm()
        {
            mainForm = new MainForm();
            userLoginController = new UserLoginController();
            InitializeComponent();
            

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.GetInstance();
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
                currentUser.SetUser(user);

                ChechLoginInfo(userName, new Model.PasswordHasher(passWord).HashedPassword, user);



            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("This user does not exist. \nUsername and password are case sensitive!");
            }

        }

        private void lblForgotLoginDetails_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length != 0)
            {
                try
                {
                    ForgotPassword forgotPassword = new ForgotPassword(new User(userLoginController.GetUser(txtUsername.Text)));
                    forgotPassword.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("This username does not exist. The username is needed for reseting the password");
                }

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
            

            if (user.UserType == Model.UserType.Regular)
            {
                mainForm.Show();
                mainForm.btnUserManagement.Enabled = false;
                mainForm.btnIncident.Enabled = false;
                this.Hide();
            }
            else
            {
                mainForm.btnAddTicket.Enabled = false;
                mainForm.btnDashboard.Enabled = false;
                mainForm.btnViewMyTickets.Enabled = false;
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
