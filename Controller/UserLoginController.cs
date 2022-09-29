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

    }
}
