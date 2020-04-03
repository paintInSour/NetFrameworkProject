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
        protected string login;
        protected string password;
        protected string userId;

        public AuthoerizedUser(string login, string password, string userId)
        {
            this.login = login;
            this.password = password;
            this.userId = userId;
        }
    }
}
