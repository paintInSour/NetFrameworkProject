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
using lab2.Engine.Repository;

namespace lab2.UI.Custom.User
{
    public partial class UserUI : UserControl ,IShowItem
    {
        private Car chosenItem;
        private CarSharingService carSharingService;
        private IAuthorizedUser user;
        delegate void updateUi();
        public UserUI(CarSharingService carSharing, IAuthorizedUser user)
        {
            InitializeComponent();
            carSharingService = carSharing;
            reloadList();
            User = user;

            MaxListWidth();
            setOrderUI(user);
        }
        public void reloadList()
        {
            ItemList.Controls.Clear();
            List<ListItem> list = new List<ListItem>();
            carSharingService.Cars.ToList().ForEach(item => list.Add(new ListItem(this, item.Value)));
            ItemList.Controls.AddRange(list.ToArray());
        }
        public void setOrderUI(IAuthorizedUser user)
        {
            if (user.GetOrder() == null)
            {
                noOrderCard.Visible = true;
                orderCard.Visible = false;
            }
            else
            {
                noOrderCard.Visible = false;
                orderCard.Visible = true;
                orderImage.Image = user.GetOrder().Car.Image;
                orderBrandLabel.Text = user.GetOrder().Car.Brand;
                orderModelLabel.Text = user.GetOrder().Car.Model;
                orderCommentLabel.Text = user.GetOrder().Car.Comment;
                startDateLabel.Text = user.GetOrder().StartDate;
                endDateLabel.Text = user.GetOrder().EndDate;
            }
        }

        public Car ChosenItem { get => chosenItem; set => chosenItem = value; }
        public CarSharingService CarSharingService { get => carSharingService; set => carSharingService = value; }
        public IAuthorizedUser User { get => user; set => user = value; }

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

            updateUi setMaxWidth = new updateUi(MaxListWidth);
            updateUi reloadUI = new updateUi(reloadList);
            OrderWizard orderWizard = new OrderWizard(carSharingService, chosenItem, user, MaxListWidth, reloadList);
            orderWizard.Show();
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

        private void materialMultiLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderReturn_Click(object sender, EventArgs e)
        {
            carSharingService.AddCar(user.GetOrder().Car);
            user.SetOrder(null);
            setOrderUI(user);
        }
    }
}
