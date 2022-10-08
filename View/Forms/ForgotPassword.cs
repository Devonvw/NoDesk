using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;
using MongoDB.Bson.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace View.Forms
{
    public partial class ForgotPassword : Form
    {
        UserLoginController userLoginController;
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
            string randomToken = RandomString();

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
    }
}
