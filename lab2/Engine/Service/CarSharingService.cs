using netFrameworkProject.Engine.Model;
using netFrameworkProject.Engine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Service
{
    public class CarSharingService
    {
        private static List<Car> cars = new List<Car>();
        private static Dictionary<string, Order> orders = new Dictionary<string, Order>();
        private static Dictionary<string, AuthorizedUser> users = new Dictionary<string, AuthorizedUser>();
        public Dictionary<string, Order> Orders { get => orders; set => orders = value; }
        public Dictionary<string, AuthorizedUser> Users { get => users; set => users = value; }
        public static List<Car> Cars { get => cars; set => cars = value; }

        public void AddCar(Car item)
        {
            CarRepository.SaveCar(item);
        }
        public void DeleteCar(Car item)
        {
            CarRepository.DeleteCar(item);
        }
        public void AddOrder(Order item)
        {
            OrderRepository.SaveOrder(item);
        }
        public void DeleteOrder(Order item)
        {
            OrderRepository.DeleteOrder(item);
        }
    }
}
