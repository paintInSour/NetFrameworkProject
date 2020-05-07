using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netFrameworkProject.UI.Custom.IControl;
using netFrameworkProject.Engine.Model;
using netFrameworkProject.Engine.Utils;

namespace netFrameworkProject.UI.Custom
{
    public partial class ListItem : UserControl
    {
        private CustomImageConverter imageConverter = new CustomImageConverter();
        private Car item;
        public IShowItem Service { get; set; }
        public Car Item { get => item; set => item = value; }

        public ListItem()
        {
            InitializeComponent();
        }
        public ListItem(IShowItem service, Car item)
        {
            InitializeComponent();
            Service = service;
            Item = item;
            image.Image = imageConverter.byteArrayToImage(item.Image);
            brandLabel.Text = item.Brand;
            modelLabel.Text = item.Model;
            priceLabel.Text = item.Price;
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void ListItem_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Click(object sender, EventArgs e)
        {
            Service.ShowItem(item);
            Service.SetChosenItem(item);
            Service.MinListWidth();
        }

        private void image_Click(object sender, EventArgs e)
        {
            Service.ShowItem(item);
            Service.SetChosenItem(item);
            Service.MinListWidth();
        }
    }
}
