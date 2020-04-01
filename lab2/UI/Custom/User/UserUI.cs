using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2.Engine.Service;
using lab2.Engine.IService;
using lab2.Engine.Model;
using lab2.UI.Custom.IControl;
using lab2.Engine.Model;

namespace lab2.UI.Custom.User
{
    public partial class UserUI : UserControl ,IShowItem
    {
        private ICarSharingService userCarSharingService;
        private Car chosenItem;
        private CarSharingService carSharingService;
        private AuthorizedUser user;
        public UserUI(CarSharingService carSharing)
        {
            InitializeComponent();
            carSharingService = carSharing;
            List<ListItem> list = new List<ListItem>();
            carSharingService.Cars.ToList().ForEach(item => list.Add(new ListItem(this, item.Value)));
            ItemList.Controls.AddRange(list.ToArray());
            
        }

        public Car ChosenItem { get => chosenItem; set => chosenItem = value; }
        public ICarSharingService UserCarSharingService { get => userCarSharingService; set => userCarSharingService = value; }
        public CarSharingService CarSharingService { get => carSharingService; set => carSharingService = value; }
        internal AuthorizedUser User { get => user; set => user = value; }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void ShowItem(Car item)
        {
            image.Image = item.Image;
            brandLabel.Text = item.Brand;
            modelLabel.Text = item.Model;
            commentLabel.Text = item.Comment;
            pricaLabel.Text = item.Price;
        }

        public void SetChosenItem(Car item)
        {
            ChosenItem = item;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            carSharingService.AddOrder(new Order(Guid.NewGuid().ToString(),chosenItem,user));
            MaxListWidth();
        }

        public void MaxListWidth()
        {
            carList.Width = 1050;
            ItemView.Visible = false;
        }

        public void MinListWidth()
        {
            carList.Width = 700;
            ItemView.Visible = true;
        }
    }
}
