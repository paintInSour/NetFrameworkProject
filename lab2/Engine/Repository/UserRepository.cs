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
    public class UserRepository
    {
        public static AuthorizedUser GetUser(string username, string password)
        {
            using (AppContext ctx = new AppContext())
            {
                return ctx.users.Where(user => user.Login == username && user.Password == password)
                    .FirstOrDefault();
            }
        }
        public static AuthorizedUser GetUserById(int userId)
        {
            using(AppContext ctx = new AppContext())
            {
                return ctx.users.Where(user => user.UserId == userId).First();
            }
        }
        public static void SaveUser(AuthorizedUser user)
        {
            using (AppContext ctx = new AppContext())
            {
                ctx.users.Add(user);
                ctx.SaveChanges();
            }
        }
        public static void UpdateUser(AuthorizedUser newUser)
        {
            using (AppContext ctx = new AppContext())
            {
                var user = ctx.users.Where(item => item.Login == newUser.Login).First();
                user = newUser;
                ctx.SaveChanges();

            }
        }
        public static AuthorizedUser GetAdminUser(string login,string password)
        {
            using(AppContext ctx = new AppContext())
            {
                return ctx.admins.Where(item => item.Login == login && item.Password == password).FirstOrDefault(null);
            }
        }
        public static List<AuthorizedUser> GetAllUsers()
        {
            using(AppContext ctx = new AppContext())
            {
                return ctx.users.ToList();
            }
        }
    }
}
