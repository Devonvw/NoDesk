using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CurrentUser
    {
        private static CurrentUser uniqueInstance;

        private User user;
        private CurrentUser() { }

        public static CurrentUser GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new CurrentUser();

            return uniqueInstance;
        }

        public void SetUser(User user)
        {
            this.user = user;
        }

        public User GetUser()
        {
            return user;
        }

    }
}
