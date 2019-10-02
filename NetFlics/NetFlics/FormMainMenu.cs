﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace NetFlics
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            LogOutSession();
        }

        private void bttInventario_Click(object sender, EventArgs e)
        {

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Session de : " + 
                CapaEntidad.UserSession.userSession.username +
                "\nRole: " +
                SpecifyRole();
        }

        private string SpecifyRole()
        {
            switch (CapaEntidad.UserSession.userSession.role)
            {
                case "S":
                    return "Super Admin";
                case "A":
                    return "Admin";
                case "F":
                    return "Fiscal";
                default:
                    return "Usuario";
            }
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            LogOutSession();
        }

        private void LogOutSession()
        {
            string username = CapaEntidad.UserSession.userSession.username;
            string message = CapaNegocios.ModificarNegocios.UserLogOut(username, "Main");

            if (message == "EXITO")
            {
                CapaEntidad.UserSession.userSession = new UserSession(); // Clear user session data for future log in
                Formularios.formMainMenu.Dispose();

                // returning to login page
                Formularios.formLogin = new FormLogin();
                Formularios.formLogin.Show();
            }
            else
                MessageBox.Show("A fatal error has occured");
        }
    }
}
