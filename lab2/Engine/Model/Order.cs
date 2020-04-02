using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public class Order
    {
        private string id;
        private string userId;
        private Car car;
        private string userBankId;

        public Order(string id, Car car,string userId,string bankId)
        {
            Id = id;
            Car = car;
            UserId = userId;
            UserBankId = bankId;
        }

        public string Id { get => id; set => id = value; }
        public Car Car { get => car; set => car = value; }
        public string UserBankId { get => userBankId; set => userBankId = value; }
        public string UserId { get => userId; set => userId = value; }
    }
}
