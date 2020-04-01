using lab2.Engine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Service
{
    public class CarSharingService
    {
        private Dictionary<string, Car> cars = new Dictionary<string, Car>();
        private Dictionary<string, Order> orders = new Dictionary<string, Order>();

        public Dictionary<string, Car> Cars { get => cars; set => cars = value; }
        public Dictionary<string, Order> Orders { get => orders; set => orders = value; }

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
            Orders.Add(item.Id,item);
        }
        public void DeleteOrder(string id)
        {
            Orders.Remove(id);
        }
    }
}
