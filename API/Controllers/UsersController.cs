using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private UserDAO userDAO;
        public UsersController()
        {
            userDAO = new UserDAO();
        }

        [HttpGet]
        [Route("{username}")]
        public object GetUser(string username)
        {
            return BsonTypeMapper.MapToDotNetValue(userDAO.GetUser(Builders<BsonDocument>.Filter.Eq("UserName", username)));
        }

        [HttpPut]
        public void UpdateUser([FromBody]object userInput)
        {
            User user = BsonSerializer.Deserialize<User>(((JsonElement)userInput).GetRawText());

            userDAO.UpdateUser(UserToBsonDocument(user), Builders<BsonDocument>.Filter.Eq("_id", user._id));
        }

        [HttpPost]
        public void CreateUser([FromBody]object userInput)
        {
            User user = BsonSerializer.Deserialize<User>(((JsonElement)userInput).GetRawText());

            userDAO.CreateUser(UserToBsonDocument(user));
        }

        [HttpGet]
        public List<User> GetUserList()
        {
            List<User> users = new List<User>();

            foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Empty))
            {
                users.Add(new User(doc));
            }

            return users;
        }
        private BsonDocument UserToBsonDocument(User user)
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

        [HttpGet]
        [Route("email/{email}")]
        public List<User> GetUserEmail(string email)
        {
            List<User> users = new List<User>();

            foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Regex("Email", new BsonRegularExpression(email))))
            {
                users.Add(new User(doc));
            }

            return users;
        }
    }
}
