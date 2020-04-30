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

namespace netFrameworkProject.Engine.Repository
{
    public class CarRepository
    {
        public static void SaveCars(List<Car> cars)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.cars.AddRange(cars);
                ctx.SaveChanges();
            }
        }
        public static void SaveCar(Car car)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.cars.Add(car);
                ctx.SaveChanges();
            }
        }
        public static void DeleteCar(Car car)
        {
            using(AppContext ctx = new AppContext())
            {
                ctx.cars.Remove(car);
                ctx.SaveChanges();
            }
        }
        public static List<Car> GetAllCars()
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.cars.ToList();
            }
        }
        public static void UpdateCar(int id, Car newCar)
        {
            using(AppContext ctx = new AppContext())
            {
                var car = ctx.cars.Where(item => item.Id == id).First();
                ctx.Entry(car).CurrentValues.SetValues(newCar);
                ctx.SaveChanges();
            }
        }
        public static Car GetCar(int id)
        {
            using(AppContext ctx = new AppContext())
            {
                return ctx.cars.Where(item => item.Id == id).First();
            }
        }
        public static List<Car> GetActiveCars()
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.cars.Where(item => item.Active).ToList();
            }
        }
    }
}
