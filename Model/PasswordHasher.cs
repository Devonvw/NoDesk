using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PasswordHasher
    {
        public string Password { get; set; }
        public string HashedPassword { get; set; }
        public PasswordHasher(string password)
        {
            Password = password;
            HashedPassword = hashPassword(Password);
        }

        private string hashPassword(string password)
        {
            var asByteArray = Encoding.UTF8.GetBytes(password);
            var hashedPassword = SHA256.Create().ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }
         
    }
}
