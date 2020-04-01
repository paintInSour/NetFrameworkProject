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
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AuthorizedUser authorizedUser;
            if (user.Checked == true)
                authorizedUser = new ClientUser();
            else
                authorizedUser = new AdminUser();
            Form1 mainForm = new Form1(authorizedUser,CarService);
            mainForm.Show();

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            CarService.Cars = CarRepository.readFile();
        }
    }
}
