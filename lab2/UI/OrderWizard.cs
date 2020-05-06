using netFrameworkProject.Engine.Model;
using netFrameworkProject.Engine.Repository;
using netFrameworkProject.Engine.Service;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace netFrameworkProject.UI
{
    public partial class OrderWizard : MaterialForm
    {
        private CarSharingService CarSharingService;
        private Car itemToOrder;
        private AuthorizedUser authorizedUser;
        public delegate void updateUI();
        private updateUI UpdateWidth;
        private updateUI UpdateList;
        public OrderWizard(CarSharingService service, Car car, AuthorizedUser user, updateUI updateWidth, updateUI updateList)
        {
            InitializeComponent();
            CarSharingService = service;
            itemToOrder = car;
            authorizedUser = user;
            UpdateWidth = updateWidth;
            UpdateList = updateList;
        }
        public CarSharingService CarSharingService1 { get => CarSharingService; set => CarSharingService = value; }
        public Car ItemToOrder { get => itemToOrder; set => itemToOrder = value; }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            itemToOrder.Active = false;
            Debug.WriteLine("item to order id : " + itemToOrder.Id);
            CarRepository.UpdateCar(itemToOrder);
            Order userOrder = new Order(itemToOrder, authorizedUser.UserId, userIdTextbox.Text, startDatePicker.Text, endDatePicker.Text);
            CarSharingService.AddOrder(userOrder);

            UpdateList();
            UpdateWidth();
            this.Close();
        }
    }
}
