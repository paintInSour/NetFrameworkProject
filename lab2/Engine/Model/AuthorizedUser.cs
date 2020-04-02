using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    public interface IAuthorizedUser
    {
        bool IsAdmin();
        Car GetOrder();
        void SetOrder(Car order);
        string GetId();
        string GetLogin();
        string GetPassword();
    }
}
