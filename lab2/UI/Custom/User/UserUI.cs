using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netFrameworkProject.Engine.Service;
using netFrameworkProject.Engine.Model;
using netFrameworkProject.UI.Custom.IControl;
using netFrameworkProject.Engine.Repository;

namespace netFrameworkProject.UI.Custom.User
{
    public partial class UserUI : UserControl, IShowItem
    {
        private Car chosenItem;
        private CarSharingService carSharingService;
        private AuthorizedUser user;
        delegate void updateUi();
        public UserUI(CarSharingService carSharing, AuthorizedUser user)
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
            ItemList.Controls.AddRange(CarRepository.GetActiveCars().Select(item => new ListItem(this, item)).ToArray());
        }
        public void setOrderUI(AuthorizedUser user)
        {
            if (user.Order == null || user.Order.Car.Active == true)
            {
                noOrderCard.Visible = true;
                orderCard.Visible = false;
            }
            else
            {
                noOrderCard.Visible = false;
                orderCard.Visible = true;
          //      orderImage.Image = user.GetOrder().Car.Image;
                orderBrandLabel.Text = user.Order.Car.Brand;
                orderModelLabel.Text = user.Order.Car.Model;
                orderCommentLabel.Text = user.Order.Car.Comment;
                startDateLabel.Text = user.Order.StartDate;
                endDateLabel.Text = user.Order.EndDate;
            }
        }
        public Car ChosenItem { get => chosenItem; set => chosenItem = value; }
        public CarSharingService CarSharingService { get => carSharingService; set => carSharingService = value; }
        public AuthorizedUser User { get => user; set => user = value; }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void ShowItem(Car item)
        {
        //    image.Image = item.Image;
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
            user.Order.Car.Active = true;
            CarRepository.UpdateCar(user.Order.Car);
            user.Order = null;
            UserRepository.UpdateUser(user);
            setOrderUI(user);
        }
    }
}
