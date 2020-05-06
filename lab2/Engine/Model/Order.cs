using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    public sealed class Order
    {
        [Key]
        private int id;
        private int userId;
        private Car car;
        private string userBankId;
        private string startDate;
        private string endDate;
        private bool active;

        public Order(Car car, int userId, string bankId, string startDate, string endDate)
        {
            Car = car;
            UserId = userId;
            UserBankId = bankId;
            StartDate = startDate;
            EndDate = endDate;
            Active = true;
        }
        public Order()
        {

        }

        public Car Car { get => car; set => car = value; }
        public string UserBankId { get => userBankId; set => userBankId = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public bool Active { get => active; set => active = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
    }
}
