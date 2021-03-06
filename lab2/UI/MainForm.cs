﻿using lab2.Engine.Model;
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
        private CarSharingService carService;
        public Form1(IAuthorizedUser user , CarSharingService carSharingService)
        {
            carService = carSharingService;
            if (user.IsAdmin())
                generateAdminForm(carSharingService ,user);
            else
                generateUserForm(carSharingService ,user);

            InitializeComponent();
        }
        public void generateUserForm(CarSharingService carSharingService,IAuthorizedUser user)
        {
            UserUI ui = new UserUI(carSharingService,user);
            ui.Location = new System.Drawing.Point(0, 64);
            ui.Name = "adminUI1";
            ui.Size = new System.Drawing.Size(1100, 662);
            ui.TabIndex = 1;
            Controls.Add(ui);
        }
        public void generateAdminForm(CarSharingService carSharingService,IAuthorizedUser user)
        {
            AdminUI ui = new AdminUI(carSharingService,user);
            ui.Location = new System.Drawing.Point(0, 64);
            ui.Name = "adminUI1";
            ui.Size = new System.Drawing.Size(1100, 662);
            ui.TabIndex = 1;
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
            UserRepository.writeFile(carService.Users);
            CarRepository.writeFile(carService.Cars);
            OrderRepository.writeFile(carService.Orders);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
