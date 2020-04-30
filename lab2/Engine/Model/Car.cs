using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Model
{
    [Serializable]
    public sealed class Car
    {
        [Key]
        private int id;
        private bool active;
      //  public Image Image { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Comment { get; set; }
        public string Price { get; set; }
        public bool Active { get => active; set => active = value; }
        public int Id { get => id; set => id = value; }

        public Car()
        {
        }

        public Car(string brand, string model, string comment, string price)
        {
         //   Image = Properties.Resources.f1_3;
            Brand = brand;
            Model = model;
            Comment = comment;
            Price = price;
            Active = true;
        }

    }
}
