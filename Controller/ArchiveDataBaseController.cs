using DAL;

namespace Controller
{
    public class ArchiveDataBaseController
    {
        private ArchiveDataBaseDAO archiveDataBaseDAO;
        public ArchiveDataBaseController()
        {
            archiveDataBaseDAO = new ArchiveDataBaseDAO();
        }
        
        public void ArchiveOldResolvedTicketes()
        {
            archiveDataBaseDAO.ArchiveOldResolvedTickets();
        }
    }
}