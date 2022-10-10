using Controller;
using Model;
using MongoDB.Bson.Serialization;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace View.Forms
{
    public partial class ForgotPassword : Form
    {
        UserLoginController userLoginController;
        private string randomToken = RandomString();

        public ForgotPassword()
        {

            InitializeComponent();
            userLoginController = new UserLoginController();
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            string fromMail = "nodeskreset@gmail.com";
            string fromPassword = "ljczunynomiqfpmw";

            SendMail(fromMail, fromPassword);
        }

        private void SendMail(string fromMail, string fromPassword)
        {

            User user = BsonSerializer.Deserialize<Model.User>(userLoginController.GetUser(txtUsername.Text));

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Wachtwoord reset email";
            message.To.Add(new MailAddress(user.Email));
            message.Body = $"<html><body> Hallo gebruik deze code om uw wachtwoord te reseten. <br> Code: {randomToken} </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);

            MessageBox.Show("Email send!");



        }

        private static string RandomString()
        {
            Random random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                char c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtSecretToken.Text == randomToken)
            {

                User user = BsonSerializer.Deserialize<Model.User>(userLoginController.GetUser(txtUsername.Text));
                user.Password = new Model.PasswordHasher(txtNewPassword.Text).HashedPassword;
                userLoginController.UpdateUser(user);

                MessageBox.Show("Password updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The entered token is not correct please try again!");
            }
        }

        private void lblShowHidePass_Click(object sender, EventArgs e)
        {

            if (txtNewPassword.PasswordChar == '*')
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }

        }
    }
}
