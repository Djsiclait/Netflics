﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;

namespace NetFlics
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Formularios.formSplash.Close();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            LoginValidation();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContrasena.Focus();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginValidation();
        }

        private void LoginValidation()
        {
            if (txtUsuario.Text == "")
                MessageBox.Show("Favor introducir su nombre de usuario");
            else if (txtContrasena.Text == "")
                MessageBox.Show("Favor introducir su contraseña");
            else
            {
                string message = CapaNegocios.ModificarNegocios.UserLogIn(txtUsuario.Text, txtContrasena.Text, "MAIN");

                if (message == "INCORRECTO") // Incorrect password
                {
                    txtContrasena.Text = "";
                    MessageBox.Show("La contraseña es incorrecta.");
                }
                else if (message == "CAMBIO") // Password needs to be changed
                {
                    // Saving the only username for the next page to use as refrence
                    CapaEntidad.UserSession.userSession = new UserSession();
                    CapaEntidad.UserSession.userSession.username = txtUsuario.Text;

                    Formularios.formLogin.Dispose();

                    Formularios.formPasswordChange = new FormPasswordChange();
                    Formularios.formPasswordChange.Show();

                }
                else if (message == "INVALIDO") // Current username is unregistered
                    MessageBox.Show("Este nombre de usuario no ha sido registrado.");
                else if (message == "SUSPENDIDO") // This user account has been suspended
                    MessageBox.Show("Esta cuenta de usuario ha sido suspendida");
                else if (message == "VACACION") // This account has been temporarily disabled until the return of its owner
                    MessageBox.Show("Esta cuenta no esta disponible en el momento, favor contactar su superior.");
                else
                {
                    // Fetching data necessary for initiating session
                    CapaEntidad.UserSession.userSession = CapaNegocios.ConsultarNegocios.FetchUserSessionData(txtUsuario.Text);

                    Formularios.formLogin.Dispose();

                    // Login SUCCESS
                    Formularios.formMainMenu = new FormMainMenu();
                    Formularios.formMainMenu.Show();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (CapaEntidad.UserSession.userSession != null)
                txtUsuario.Text = CapaEntidad.UserSession.userSession.username;
        }
    }
}
