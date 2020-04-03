using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public class ClientUser :AuthoerizedUser, IAuthorizedUser
    {
        private Order order;

        public Order Order { get => order; set => order = value; }

        public ClientUser(string login,string pass, string id):base(login,pass,id)
        {
            Order = null;
        }

        public Order GetOrder()
        {
            return Order;
        }

        public bool IsAdmin()
        {
            return false;
        }

        public void SetOrder(Order order)
        {
            Order = order;
        }

        public string GetId()
        {
            return userId;
        }

        public string GetLogin()
        {
            return login;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
