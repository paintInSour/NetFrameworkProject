using MaterialSkin.Controls;
using netFrameworkProject.Engine.Model;
using netFrameworkProject.Engine.Repository;
using netFrameworkProject.Engine.Service;
using System;
using System.Windows.Forms;

namespace netFrameworkProject.UI
{
    public partial class AuthorizationForm : MaterialForm
    {
        private CarSharingService CarService = new CarSharingService();
        private AuthorizedUser authorizedUser;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                authorizedUser = UserRepository.GetUser(logingTextBox.Text, passwordTextBox.Text);
                Form1 mainForm = new Form1(authorizedUser, CarService);
                this.Hide();
                mainForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot login.");
            }

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(this);
            this.Hide();
            registration.Show();
        }
    }
}
