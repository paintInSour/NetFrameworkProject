using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using netFrameworkProject.Engine.Model;

namespace netFrameworkProject.DB
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DbConnection") { }

        public DbSet<AuthorizedUser> users { get; set; }
        public DbSet<AdminUser> admins { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
