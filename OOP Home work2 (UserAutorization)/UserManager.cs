using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Home_work2__UserAutorization_
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(string username, string password)
        {
            var user = new User { Username = username, Password = password };
            users.Add(user);
        }

        public bool Authenticate(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
