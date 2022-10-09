using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Controller
{
    public class UserLoginController
    {
        private UserDAO userDAO;
        public UserLoginController()
        {
            userDAO = new UserDAO();
        }
  
        public BsonDocument GetUser(string userName)
        {
           return userDAO.GetUser(Builders<BsonDocument>.Filter.Eq("UserName", userName));
        }

        public void UpdateUser(User user)
        {
            userDAO.UpdateUser(UserToBsonDocument(user), Builders<BsonDocument>.Filter.Eq("_id", user._id));
        }

        public void CreateUser(Model.User user)
        {
            userDAO.CreateUser(UserToBsonDocument(user));
        }

        public List<User> GetUserList()
        {
            List<User> users = new List<User>();

            foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Empty))
            {
                users.Add(new User(doc));
            }

            return users;               
        }

        public BsonDocument UserToBsonDocument(Model.User user)
        {
            BsonDocument newBsonDocument = new BsonDocument
            {
                {"FirstName", user.FirstName},
                {"LastName",user.LastName},
                {"UserName", user.UserName},
                {"Email", user.Email},
                {"Password", user.Password},
                {"Location",user.Location},
                {"PhoneNumber",user.PhoneNumber},
                {"UserType", user.UserType.ToString()},
                
            };
            return newBsonDocument;
        }

        public List<User> GetUserEmail(string email)
        {
            List<User> users = new List<User>();

            foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Regex("Email", new BsonRegularExpression(email))))
            {
                users.Add(new User(doc));
            }

            return users;
        }

        public List<User> SearchOnEmail(string email)
        {
            List<User> allUSers = GetUserList();

            foreach (User u in allUSers)
            {
                if (!(u.Email.Contains(email)))
                {
                    allUSers.Remove(u);
                }
            }
            return allUSers;
        }
    }
}
