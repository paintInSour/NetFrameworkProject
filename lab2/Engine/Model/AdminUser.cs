using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
        [Serializable]
    class AdminUser : IAuthorizedUser
    {
        public AdminUser()
        {
        }

        public string GetId()
        {
            throw new NotImplementedException();
        }

        public string GetLogin()
        {
            throw new NotImplementedException();
        }

        public Car GetOrder()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public bool IsAdmin()
        {
            return true;
        }

        public void SetOrder(Car order)
        {
            throw new NotImplementedException();
        }
    }
}
