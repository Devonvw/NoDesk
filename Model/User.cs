using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    class User
    {
        private string firstname;
        private string lastname;
        private UserType userType;
        private string email;
        private string username;
        private string password;
        private int phoneNumber;
        private string location;
        public User(string firstname, string lastname, string email, string username, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string FullName { get { return $"{firstname} {lastname}"; }}
        public string Email { get { return email;} set { email = value; } }
        
        public string Password { get { return password; } set { password = value; } }

        public string Username { get { return username; } set { username = value; } }

        public UserType UserType { get => userType; set => userType = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Location { get => location; set => location = value; }
    }
}
