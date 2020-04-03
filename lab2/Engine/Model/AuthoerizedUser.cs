using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public class AuthoerizedUser
    {
        private string login;
        private string password;
        private string name;
        private string userId;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
