using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class UserManager
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public bool ValidateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        public bool RegisterUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return false;
            }
            users.Add(username, password);
            return true;
        }

        public bool UserExists(string username)
        {
            return users.ContainsKey(username);
        }
    }
}

