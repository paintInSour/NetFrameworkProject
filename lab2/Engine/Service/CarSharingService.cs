using netFrameworkProject.Engine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Service
{
    public class CarSharingService
    {
        private static Dictionary<string, Car> cars = new Dictionary<string, Car>();
        private static Dictionary<string, Order> orders = new Dictionary<string, Order>();
        private static Dictionary<string, IAuthorizedUser> users = new Dictionary<string, IAuthorizedUser>();
        public Dictionary<string, Car> Cars { get => cars; set => cars = value; }
        public Dictionary<string, Order> Orders { get => orders; set => orders = value; }
        public Dictionary<string, IAuthorizedUser> Users { get => users; set => users = value; }

        public void AddCar(Car item)
        {

            if (Cars.ContainsKey(item.Id))
            {
                Cars.Remove(item.Id);
            }
            Cars.Add(item.Id, item);

        }
        public void DeleteCar(string id)
        {
            Cars.Remove(id);
        }

        public void AddOrder(Order item)
        {
            Orders.Add(item.Id, item);
        }
        public void DeleteOrder(string id)
        {
            Orders.Remove(id);
        }

    }
}
