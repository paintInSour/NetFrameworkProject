using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    public class Order
    {
        private string id;
        private Car car;
        private AuthorizedUser user;

        public Order(string id, Car car, AuthorizedUser user)
        {
            Id = id;
            Car = car;
            User = user;
        }

        public string Id { get => id; set => id = value; }
        public Car Car { get => car; set => car = value; }
        internal AuthorizedUser User { get => user; set => user = value; }
    }
}
