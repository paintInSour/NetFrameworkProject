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
    public partial class AuthorizationForm : MaterialForm
    {
        private CarSharingService CarService = new CarSharingService();
        private IAuthorizedUser authorizedUser;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (user.Checked == true)
            {
                CarService.Users.ToList().ForEach(user =>
                {
                    if (user.Value.GetLogin()
                        == logingTextBox.Text && user.Value.GetPassword() == passwordTextBox.Text)
                    {
                        authorizedUser = CarService.Users[user.Key];
                    }
                });
                if (authorizedUser == null)
                {
                    authorizedUser = new ClientUser(logingTextBox.Text, passwordTextBox.Text, Guid.NewGuid().ToString());
                    CarService.Users.Add(authorizedUser.GetId(), authorizedUser);
                }
                Form1 frm = new Form1(authorizedUser, CarService);
                frm.Show();
            }
            else
            {
                authorizedUser = new AdminUser();
                Form1 mainForm = new Form1(authorizedUser, CarService);
                mainForm.Show();
            }
            UserRepository.writeFile(CarService.Users);
            
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            CarService.Cars = CarRepository.readFile();
            CarService.Orders = OrderRepository.readFile();
            CarService.Users = UserRepository.readFile();
        }
    }
}
