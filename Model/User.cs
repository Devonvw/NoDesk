using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    public class User
    {
        public ObjectId _id;
        private string firstname;
        private string lastname;
        private UserType userType;
        private string email;
        private string username;
        private string password;
        private int phoneNumber;
        private string location;

        public User(string firstname, string lastname,string username, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
        }
         
        public User(BsonDocument bsonDoc)
        {
            BsonSerializer.Deserialize<User>(bsonDoc);

            _id = bsonDoc["_id"].AsObjectId;
            firstname = bsonDoc["FirstName"].AsString;
            lastname = bsonDoc["LastName"].AsString;
            username = bsonDoc["UserName"].AsString;
            email = bsonDoc["Email"].AsString;
            password = bsonDoc["Password"].AsString;
            location = bsonDoc["Location"].AsString;
            phoneNumber = bsonDoc["PhoneNumber"].AsInt32;
            userType = (UserType)Enum.Parse(typeof(UserType), bsonDoc["UserType"].AsString, true);
        }
        public string FirstName { get { return firstname; } set { firstname = value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
        public string FullName { get { return $"{firstname} {lastname}"; }}
        public string Email { get { return email;} set { email = value; } }
        
        public string Password { get { return password; } set { password = value; } }

        public string UserName { get { return username; } set { username = value; } }

        public UserType UserType { get => userType; set => userType = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Location { get => location; set => location = value; }
        public ObjectId _Id { get => _id; set => _id = value; }


        public override string ToString()
        {
            return $"{FullName} {password} {Email} {phoneNumber} {username} {location} {userType}";
        }
    }
}
