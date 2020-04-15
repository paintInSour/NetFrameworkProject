using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    [Serializable]
    public sealed class ClientUser : AuthoerizedUser, IAuthorizedUser
    {
        private string id;
        private Order order;

        public Order Order { get => order; set => order = value; }
        public string Id { get => id; set => id = value; }

        public ClientUser(string login, string pass, string id) : base(login, pass, id)
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
        new public void AbsolutelyUselessMethod()
        {
            Console.WriteLine("executing absolutely useless method created with new");
        }
        public override void AnotherAbsolutelyUselessMethod()
        {
            Console.WriteLine("executing overrided absolutely useless method");
        }
    }
}
