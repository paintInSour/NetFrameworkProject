using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    public class AuthorizedUser
    {
        [Key]
        private int id;
        private string login;
        private string password;
        private int userId;
        private Order order;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public Order Order { get => order; set => order = value; }

        public AuthorizedUser(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            this.UserId = new Random().Next();
        }
        public AuthorizedUser() { }
        public void AbsolutelyUselessMethod()
        {
            Console.WriteLine("executing absolutely useless method");
        }
        public virtual void AnotherAbsolutelyUselessMethod()
        {
            Console.WriteLine("executing another absolutely useless method");
        }
        public virtual bool IsAdmin() { return false; }

    }
}
