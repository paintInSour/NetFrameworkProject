using netFrameworkProject.Engine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using netFrameworkProject.DB;
using AppContext = netFrameworkProject.DB.AppContext;
using System.Diagnostics;

namespace netFrameworkProject.Engine.Repository
{
    public class OrderRepository
    {
        public static Order GetOrder(int id)
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.orders.Include("Car").Where(item => item.Id == id).First();
            }
        }
        public static void SaveOrder(Order order)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.cars.Attach(order.Car);
                ctx.orders.Add(order);
                ctx.SaveChanges();
            }
        }
        public static void UpdateOrder(Order newOrder)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.cars.Attach(newOrder.Car);
                ctx.Entry(newOrder).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public static void DeleteOrder(Order order)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.orders.Remove(order);
                ctx.SaveChanges();
            }
        }
        public static List<Order> GetActiveOrders()
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.orders.Include("Car").Where(item => item.Active).ToList();
            }
        }

        public static List<Order> GetAllOrders()
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.orders.ToList();
            }
        }
    }
}
