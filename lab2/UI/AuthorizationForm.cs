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
                if (authorizedUser == null)
                    UserRepository.SaveUser(new ClientUser(logingTextBox.Text, passwordTextBox.Text));
                Form1 mainForm = new Form1(authorizedUser, CarService);
                mainForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot login. Registrated this user");

                //if (user.Checked)
                //    UserRepository.SaveUser(new ClientUser(logingTextBox.Text, passwordTextBox.Text, BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)));

                //  UserRepository.SaveUser(new AdminUser(logingTextBox.Text, passwordTextBox.Text, BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)));
            }

        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
        }
    }
}
