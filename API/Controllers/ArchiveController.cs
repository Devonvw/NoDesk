using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArchiveController : Controller
    {
        private ArchiveDataBaseDAO archiveDAO;
        public ArchiveController()
        {
            archiveDAO = new ArchiveDataBaseDAO();
        }

        [HttpPost]
        public IActionResult ArchiveOldResolvedTickets()
        {
            try
            {
                archiveDAO.ArchiveOldResolvedTickets();
                return StatusCode(200);
            }
            catch (Exception ex) { return StatusCode(500, new { msg = ex.Message }); }

        }
    }
}
