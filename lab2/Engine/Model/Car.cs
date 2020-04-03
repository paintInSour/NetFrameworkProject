using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Model
{
    [Serializable]
    public sealed class Car
    {
        public string Id { get; set; }
        public Image Image { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Comment { get; set; }
        public string Price { get; set; }

        public Car()
        {
        }

        public Car(string brand, string model, string comment, string price)
        {
            Image = Properties.Resources.f1_3;
            Id = Guid.NewGuid().ToString();
            Brand = brand;
            Model = model;
            Comment = comment;
            Price = price;
        }

    }
}
