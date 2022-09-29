using Controller;
using MongoDB.Bson.Serialization;
using User = Model.User;

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
            if (txtPass.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("You did not enter a username and/or password");
                return;
            }

            string userName = txtUsername.Text;
            string passWord = txtPass.Text;


            User user = BsonSerializer.Deserialize<Model.User>(userLoginController.GetUser(userName));

            ChechLoginInfo(userName, passWord, user);

        }



        private void ChechLoginInfo(string userName, string passWord, User user)
        {
            

            if (userName == user.UserName && passWord == user.Password)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You entered the wrong user name and/or password. \nPlease try again.");
            }


        }
    }
}
