using MaterialSkin.Controls;
using netFrameworkProject.Engine.Model;
using netFrameworkProject.Engine.Repository;
using netFrameworkProject.UI;
using System;
using System.Windows.Forms;

namespace netFrameworkProject
{
    public partial class RegistrationForm : MaterialForm
    {
        private AuthorizationForm authorizationForm;
        public RegistrationForm(AuthorizationForm authForm)
        {
            InitializeComponent();
            authorizationForm = authForm;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "" && repeatPasswordBox.Text != "" && passwordBox.Text == repeatPasswordBox.Text)
            {
                UserRepository.SaveUser(new ClientUser(usernameBox.Text, passwordBox.Text));
                this.Close();
                authorizationForm.Show();
            }
            else
            {
                MessageBox.Show("Ups smth gone wrong");
            }

        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorizationForm.Show();
        }
    }
}
