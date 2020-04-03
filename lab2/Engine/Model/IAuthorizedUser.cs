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
        Order GetOrder();
        void SetOrder(Order order);
        string GetId();
        string GetLogin();
        string GetPassword();
    }
}
