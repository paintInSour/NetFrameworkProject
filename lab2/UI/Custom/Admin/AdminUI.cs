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
using netFrameworkProject.Engine.Service;
using netFrameworkProject.Engine.Repository;

namespace netFrameworkProject.UI.Custom.Admin
{
    public partial class AdminUI : UserControl, IShowItem
    {
        private Car chosenItem;
        private CarSharingService carSharingService;
        private AuthorizedUser user;
        public AdminUI()
        {
            InitializeComponent();

        }
        public AdminUI(CarSharingService carSharing, AuthorizedUser user)
        {
            InitializeComponent();
            carSharingService = carSharing;
            User = user;
            try
            {
                ItemList.Controls.AddRange(CarRepository.GetActiveCars().Select(item => new ListItem(this, item)).ToArray());
                orderList.Controls.AddRange(OrderRepository.GetActiveOrders().Select(item => new OrderItem(carSharingService, item, orderList)).ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("cant display");
            }
        }
        public Car ChosenItem { get => chosenItem; set => chosenItem = value; }
        public CarSharingService CarSharingService { get => carSharingService; set => carSharingService = value; }
        public AuthorizedUser User { get => user; set => user = value; }

        public void MaxListWidth()
        {
            ItemList.Width = 1050;
            ItemView.Visible = false;
            addButton.Text = "edit";
        }

        public void MinListWidth()
        {
            ItemList.Width = 700;
            ItemView.Visible = true;
        }

        public void SetChosenItem(Car item)
        {
            chosenItem = item;
        }

        public void ShowItem(Car item)
        {
           // image.Image = item.Image;
            brandTextBox.Text = item.Brand;
            modelTextBox.Text = item.Model;
            commentTextBox.Text = item.Comment;
            priceTextBox.Text = item.Price;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (chosenItem == null)
                createNewCar();
            else
                editCar();
            CarRepository.SaveCar(chosenItem);
            ReloadList();
            MaxListWidth();
        }

        public void createNewCar()
        {
            chosenItem = new Car(brandTextBox.Text, modelTextBox.Text, commentTextBox.Text, priceTextBox.Text);
        }
        public void editCar()
        {
            chosenItem.Brand = brandTextBox.Text;
            chosenItem.Model = modelTextBox.Text;
            chosenItem.Comment = commentTextBox.Text;
            chosenItem.Price = priceTextBox.Text;
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            carSharingService.DeleteCar(chosenItem);
            ReloadList();
            MaxListWidth();
        }
        public void ReloadList()
        {
            ItemList.Controls.Clear();
            ItemList.Controls.AddRange(GetControlList().ToArray());
        }
        public List<ListItem> GetControlList()
        {
            try
            {
                return CarRepository.GetAllCars().Select(item => new ListItem(this, item)).ToList();
            }
            catch
            {
                return new List<ListItem>();
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            MinListWidth();
            addButton.Text = "add";
            chosenItem = null;
        }
        private void carList_Click(object sender, EventArgs e)
        {

        }
    }
}
