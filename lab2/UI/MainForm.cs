using lab2.Engine.Model;
using lab2.Engine.Repository;
using lab2.Engine.Service;
using lab2.UI.Custom.Admin;
using lab2.UI.Custom.User;
using MaterialSkin;
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

namespace lab2
{
    public partial class Form1 : MaterialForm
    {
        public Form1(AuthorizedUser user , CarSharingService carSharingService)
        {
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Indigo900, Accent.Blue700, TextShade.WHITE);
            if (user.IsAdmin())
                generateAdminForm(carSharingService);
            else
                generateUserForm(carSharingService);

            InitializeComponent();
        }
        public void generateUserForm(CarSharingService carSharingService)
        {
            UserUI ui = new UserUI(carSharingService);
            ui.ChosenItem = null;
            ui.Location = new System.Drawing.Point(0, 64);
            ui.Name = "adminUI1";
            ui.Size = new System.Drawing.Size(1100, 662);
            ui.TabIndex = 1;
            ui.User = null;
            ui.UserCarSharingService = null;
            Controls.Add(ui);
        }
        public void generateAdminForm(CarSharingService carSharingService)
        {
            AdminUI ui = new AdminUI(carSharingService);
            ui.ChosenItem = null;
            ui.Location = new System.Drawing.Point(0, 64);
            ui.Name = "adminUI1";
            ui.Size = new System.Drawing.Size(1100, 662);
            ui.TabIndex = 1;
            ui.User = null;
            ui.UserCarSharingService = null;
            Controls.Add(ui);
        }
    
        public void GenerateLightTheme()
        {

        }
        public void GenerateDarkTheme()
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
