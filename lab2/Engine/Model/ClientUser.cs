using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    public sealed class ClientUser : AuthorizedUser
    {
        private Order order;

        public Order Order { get => order; set => order = value; }
        public ClientUser(string login, string pass) : base(login, pass)
        {
            Order = null;
        }

        public ClientUser() { }
        new public void AbsolutelyUselessMethod()
        {
            Console.WriteLine("executing absolutely useless method created with new");
        }
        public override void AnotherAbsolutelyUselessMethod()
        {
            Console.WriteLine("executing overrided absolutely useless method");
        }

        public override bool IsAdmin()
        {
            return false;
        }

        public override Order GetOrder()
        {
            return Order;
        }

        public override void SetOrder(Order order)
        {
            Order = order;
        }

    }
}
