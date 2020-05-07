using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    public sealed class Car
    {
        [Key]
        private int id;
        private bool active;
        private bool deleted;
        public byte[] Image { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Comment { get; set; }
        public string Price { get; set; }
        public bool Active { get => active; set => active = value; }
        public int Id { get => id; set => id = value; }
        public bool Deleted { get => deleted; set => deleted = value; }

        public Car()
        {
        }

        public Car(string brand, string model, string comment, string price, byte[] image )
        {
            Image = image;

            Brand = brand;
            Model = model;
            Comment = comment;
            Price = price;
            Active = true;
            Deleted = false;
        }

    }
}
