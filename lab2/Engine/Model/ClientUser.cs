using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public class ClientUser : IAuthorizedUser
    {
        private string login;
        private string password;
        private string name;
        private string userId;
        private Car order;

        public Car Order { get => order; set => order = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string UserId { get => userId; set => userId = value; }

        public ClientUser(string login,string pass, string id)
        {
            Login = login;
            Password = pass;
            UserId = id;
            Order = null;
        }

        public Car GetOrder()
        {
            return Order;
        }

        public bool IsAdmin()
        {
            return false;
        }

        public void SetOrder(Car order)
        {
            Order = order;
        }

        public string GetId()
        {
            return UserId;
        }

        public string GetLogin()
        {
            return Login;
        }
        public string GetPassword()
        {
                return Password;
        }
    }
}
