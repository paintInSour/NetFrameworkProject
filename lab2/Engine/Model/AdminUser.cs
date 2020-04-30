using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    public sealed class AdminUser :AuthorizedUser
    {
        public AdminUser(string login, string pass) : base(login, pass)
        {

        }
        public AdminUser() { }
        public override bool IsAdmin()
        {
            return true;
        }

        public override void SetOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
