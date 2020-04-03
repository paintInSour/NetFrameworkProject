using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public sealed class Order
    {
        private string id;
        private string userId;
        private Car car;
        private string userBankId;
        private string startDate;
        private string endDate;

        public Order(string id, Car car,string userId,string bankId ,string startDate,string endDate)
        {
            Id = id;
            Car = car;
            UserId = userId;
            UserBankId = bankId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Id { get => id; set => id = value; }
        public Car Car { get => car; set => car = value; }
        public string UserBankId { get => userBankId; set => userBankId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
    }
}
