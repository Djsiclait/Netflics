using System;
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

                if (message == "INCORRECTO")
                {
                    txtContrasena.Text = "";
                    MessageBox.Show("La contraseña es incorrecta.");
                }
                else if (message == "CAMBIO")
                {
                    // TODO: Prompt password change form
                    MessageBox.Show(message);
                }
                else if (message == "INVALIDO")
                    MessageBox.Show("Este nombre de usuario no ha sido registrado.");
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
    }
}
