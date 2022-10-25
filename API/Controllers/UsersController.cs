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
        public IActionResult GetUser(string username)
        {
            try
            {
                return StatusCode(200, new {user = BsonTypeMapper.MapToDotNetValue(userDAO.GetUser(Builders<BsonDocument>.Filter.Eq("UserName", username))) });
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve user" }); }
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody]object userInput)
        {
            try
            {
                User user = BsonSerializer.Deserialize<User>(((JsonElement)userInput).GetRawText());

                userDAO.UpdateUser(UserToBsonDocument(user), Builders<BsonDocument>.Filter.Eq("_id", user._id));
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to update user" }); }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody]object userInput)
        {
            try
            {
                User user = BsonSerializer.Deserialize<User>(((JsonElement)userInput).GetRawText());

                userDAO.CreateUser(UserToBsonDocument(user));
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to create user" }); }
        }

        [HttpGet]
        public IActionResult GetUserList()
        {
            try
            {
                List<User> users = new List<User>();

                foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Empty))
                {
                    users.Add(new User(doc));
                }

                return StatusCode(200, new { users = users});
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve users" }); }
        }

        [HttpGet]
        [Route("email/{email}")]
        public IActionResult GetUserEmail(string email)
        {
            try
            {
                List<User> users = new List<User>();

                foreach (BsonDocument doc in userDAO.GetUserList(Builders<BsonDocument>.Filter.Regex("Email", new BsonRegularExpression(email))))
                {
                    users.Add(new User(doc));
                }

                return StatusCode(200, new { user = users });
            }
            catch (Exception ex) { return StatusCode(500, new { msg = "Not able to retrieve user" }); }
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
    }
}
