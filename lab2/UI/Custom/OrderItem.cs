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
using netFrameworkProject.Engine.Repository;

namespace netFrameworkProject.UI.Custom
{
    public partial class OrderItem : UserControl
    {
        private CarSharingService carSharingService;
        private Order order;
        private FlowLayoutPanel orderList;
        public OrderItem(CarSharingService service, Order order, FlowLayoutPanel list)
        {
            InitializeComponent();
            CarSharingService = service;
            Order = order;
            orderList = list;
            setFields();
        }
        public void setFields()
        {
         //   orderImage.Image = order.Car.Image;
            orderBrandLabel.Text = order.Car.Brand;
            orderModelLabel.Text = order.Car.Model;
            orderPriceLabel.Text = order.Car.Price;
            OrderUserId.Text = order.UserBankId;
            orderUserName.Text = "username";

        }

        public CarSharingService CarSharingService { get => carSharingService; set => carSharingService = value; }
        public Order Order { get => order; set => order = value; }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void OrderItem_Load(object sender, EventArgs e)
        {

        }

        private void declineButton_Click(object sender, EventArgs e)
        {
          ClientUser user =(ClientUser)UserRepository.GetUserByUserId(order.UserId);
            CarRepository.GetCar(order.Car.Id);
            user.Order = null;
            order.Active = false;
            OrderRepository.UpdateOrder(order);
            UserRepository.UpdateUser(user);
            reloadOrderList();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            AuthorizedUser user = UserRepository.GetUserByUserId(order.UserId);
            order.Active = false;
            user.Order = order;
            OrderRepository.UpdateOrder(user.Order);
            UserRepository.UpdateUser(user);
            reloadOrderList();
        }
        public void reloadOrderList()
        {
            orderList.Controls.Clear();
            orderList.Controls.AddRange(OrderRepository.GetActiveOrders().Select(item => new OrderItem(carSharingService, item, orderList)).ToArray());
        }

    }
}
