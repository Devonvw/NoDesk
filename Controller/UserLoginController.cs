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
        public void CreateUser(Model.User user)
        {
            userDAO.CreateUser(UserToBsonDocument(user));
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
    }
}
