using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2.UI.Custom.IControl;
using lab2.Engine.Model;
using lab2.Engine.IService;
using lab2.Engine.Service;
using lab2.Engine.Repository;

namespace lab2.UI.Custom.Admin
{
    public partial class AdminUI : UserControl,IShowItem
    {
        private ICarSharingService userCarSharingService;
        private Car chosenItem;
        private CarSharingService carSharingService;
        private AuthorizedUser user;
        public AdminUI()
        {
            InitializeComponent();
          
        }
        public AdminUI(CarSharingService carSharing)
        {
            InitializeComponent();
            carSharingService = carSharing;
        }

        public ICarSharingService UserCarSharingService { get => userCarSharingService; set => userCarSharingService = value; }
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
            image.Image = item.Image;
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
            ReloadList();
            MaxListWidth();
            CarRepository.writeFile(CarSharingService.Cars);
        }

        public void createNewCar()
        {
            carSharingService.AddCar(new Car(brandTextBox.Text, modelTextBox.Text, commentTextBox.Text, priceTextBox.Text));
        }
        public void editCar()
        {
            chosenItem.Brand = brandTextBox.Text;
            chosenItem.Model = modelTextBox.Text;
            chosenItem.Comment = commentTextBox.Text;
            chosenItem.Price = priceTextBox.Text;
            CarSharingService.AddCar(chosenItem);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (chosenItem != null)
                carSharingService.DeleteCar(chosenItem.Id);
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
                List<ListItem> list = new List<ListItem>();
                carSharingService.Cars.ToList().ForEach(item => list.Add(new ListItem(this, item.Value)));
                return list;
            }
            catch{
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
