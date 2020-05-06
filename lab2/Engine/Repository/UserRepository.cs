using netFrameworkProject.Engine.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using AppContext = netFrameworkProject.DB.AppContext;

namespace netFrameworkProject.Engine.Repository
{
    public class UserRepository
    {
        public static AuthorizedUser GetUser(string username, string password)
        {
            using (AppContext ctx = new AppContext())
            {
                var user = ctx.users.Where(u => u.Login
                == username && u.Password == password).Include(u => u.Order).Include(u => u.Order.Car)
                    .FirstOrDefault();
                return user;
            }
        }
        public static AuthorizedUser GetUserById(int userId)
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.users.Include("Order").Include("Car").Where(user => user.Id == userId).First();
            }
        }
        public static AuthorizedUser GetUserByUserId(int userId)
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.users.Where(user => user.UserId == userId).First();
            }
        }
        public static void SaveUser(AuthorizedUser user)
        {
            using (AppContext ctx = new AppContext())
            {
                if (ctx.users.Where(u => u.Login == user.Login && u.Password == u.Password).FirstOrDefault() == null)
                {
                    ctx.users.Add(user);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cant register");
                }
                ctx.SaveChanges();
            }
        }
        public static void UpdateUser(AuthorizedUser newUser)
        {
            using (AppContext ctx = new AppContext())
            {
                var entity = ctx.users.Find(newUser.Id);
                entity.Order = newUser.Order;
                try
                {
                    entity.Order = ctx.orders.Find(newUser.Order.Id);
                }
                catch (Exception)
                {
                    Debug.WriteLine("order is null");
                }
                Debug.WriteLine(ctx.Entry(entity).State);
                ctx.SaveChanges();
            }
        }
        public static AuthorizedUser GetAdminUser(string login, string password)
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.admins.Where(item => item.Login == login && item.Password == password).FirstOrDefault(null);
            }
        }
        public static List<AuthorizedUser> GetAllUsers()
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.users.ToList();
            }
        }
    }
}
