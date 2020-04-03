using lab2.Engine.Model;
using lab2.Engine.Repository;
using lab2.Engine.Service;
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

namespace lab2.UI
{
    public partial class OrderWizard : MaterialForm
    {
       private CarSharingService CarSharingService;
       private Car itemToOrder;
       private IAuthorizedUser authorizedUser;
       public delegate void updateUI();
        private updateUI UpdateWidth;
        private updateUI UpdateList;
        public OrderWizard(CarSharingService service, Car car,IAuthorizedUser user , updateUI updateWidth ,updateUI updateList)
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
            CarSharingService.AddOrder(new Order(Guid.NewGuid().ToString(), itemToOrder, authorizedUser.GetId(), userIdTextbox.Text, startDatePicker.Text, endDatePicker.Text));
            CarSharingService.DeleteCar(itemToOrder.Id);
            OrderRepository.writeFile(CarSharingService.Orders);
            CarRepository.writeFile(CarSharingService.Cars);
            UpdateList();
            UpdateWidth();
            this.Close();
        }


    }
}
