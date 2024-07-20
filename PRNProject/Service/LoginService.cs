using PRNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRNProject.Service
{
    internal class LoginService
    {
        private Prn212Context db;

        public LoginService()
        {
            db = new Prn212Context();
        }
        
        public User getByUsername(string username)
        {
            return db.Users.Where(user => user.Username == username).FirstOrDefault();
        }

        public bool canLogin(string username, string password)
        {
            User user = getByUsername(username);
            if(user == null) { return false; }

            return user.Password == password;
        }
    }
}
