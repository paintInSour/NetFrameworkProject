using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    public class ClientUser:AuthorizedUser
    {
        private string login;
        private string password;
        private string name;
        

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }

        public override bool IsAdmin()
        {
            return false;
        }
    }
}
