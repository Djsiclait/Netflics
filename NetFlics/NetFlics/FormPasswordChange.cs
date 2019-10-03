using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFlics
{
    public partial class FormPasswordChange : Form
    {
        public FormPasswordChange()
        {
            InitializeComponent();
        }

        private void FormPasswordChange_Load(object sender, EventArgs e)
        {
            Formularios.formPasswordChange.FormBorderStyle = FormBorderStyle.None;
            lbUsuario.Text = CapaEntidad.UserSession.userSession.username;
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtRepetir.Focus();
        }

        private void bttCambiar_Click(object sender, EventArgs e)
        {
            PasswordChange();
        }

        private void txtRepetir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PasswordChange();
        }

        private void PasswordChange()
        {
            if (txtContrasena.Text == "")
                MessageBox.Show("Favor introducir una contraseña");
            else if (txtContrasena.Text.Length < 5)
            {
                txtContrasena.Text = txtRepetir.Text = "";
                MessageBox.Show("Contraseña no puede contener menos de cinco caracteres");
            }
            else if (txtContrasena.Text == "12345" || txtContrasena.Text.ToLower() == "qwerty")
            {
                txtContrasena.Text = txtRepetir.Text = "";
                MessageBox.Show("Contraseña invalida");
            }
            else if (txtContrasena.Text.ToLower() == lbUsuario.Text.ToLower())
            {
                txtContrasena.Text = txtRepetir.Text = "";
                MessageBox.Show("El nombre de usuario no puede ser una contraseña");
            }
            else if (txtRepetir.Text != txtContrasena.Text)
            {
                txtRepetir.Text = "";
                MessageBox.Show("Favor repetir la contraseña correctamente");
            }
            else
            {
                string message = CapaNegocios.ModificarNegocios.ChangeUserPassword(lbUsuario.Text, txtContrasena.Text);

                if (message == "EXITO")
                {
                    MessageBox.Show("Contraseña fue cambiada exitosamente para: " + lbUsuario.Text);
                    Formularios.formPasswordChange.Dispose();

                    Formularios.formLogin = new FormLogin();
                    Formularios.formLogin.Show();
                }
                else if (message == "Contrasena Invalidada")
                    MessageBox.Show("La nueva contraseña no puede ser igual al anterior");
                else
                    MessageBox.Show("ERROR FATAL");
            }
        }
    }
}
