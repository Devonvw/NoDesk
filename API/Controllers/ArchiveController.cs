using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace API.Controllers
{
    public class ArchiveController : Controller
    {
        private ArchiveDataBaseDAO archiveDAO;
        public ArchiveController()
        {
            archiveDAO = new ArchiveDataBaseDAO();
        }

        [HttpPost]
        public void ArchiveOldResolvedTicketes()
        {
            archiveDAO.ArchiveOldResolvedTickets();
        }
    }
}
