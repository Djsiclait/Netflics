using System;
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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            string username = CapaEntidad.UserSession.userSession.username;
            string message = CapaNegocios.ModificarNegocios.UserLogOut(username, "MAIN");

            if (message == "EXITO")
            {
                string lastSession = CapaEntidad.UserSession.userSession.username;
                CapaEntidad.UserSession.userSession = new UserSession(); // Clear user session data for future log in
                CapaEntidad.UserSession.userSession.username = lastSession;
                Formularios.formNewUser.Dispose();

                // returning to login page
                Formularios.formLogin = new FormLogin();
                Formularios.formLogin.Show();
            }
            else
                MessageBox.Show("A fatal error has occured");
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            lbErrorCargo.Hide();
            lbErrorFormaPago.Hide();
            lbErrorSalario.Hide();
            lbErrorUsuario.Hide();
        }

        // Button Clicks
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Formularios.formNewUser.Dispose();

            // Calling Users Master Page
            Formularios.formUsersMaster = new FormUsersMaster();
            Formularios.formUsersMaster.Show();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                lbErrorUsuario.Text = "Favor elegir nombre de usuario";
                lbErrorUsuario.ForeColor = Color.Red;
                lbErrorUsuario.Show();
            }

            if (cbCargo.Text == "")
                lbErrorCargo.Show();

            if (txtSalario.Text == "")
            {
                lbErrorSalario.Text = "Favor introducir salario";
                lbErrorUsuario.ForeColor = Color.Red;
                lbErrorSalario.Show();
            }
            else if (!ValidateSalary())
            {
                lbErrorSalario.Text = "Formato invalido";
                lbErrorSalario.ForeColor = Color.Red;
                lbErrorSalario.Show();
            }

            if (cbFormaPago.Text == "")
                lbErrorFormaPago.Show();
            
        }

        private void cbCargo_Click(object sender, EventArgs e)
        {
            if (lbErrorUsuario.Visible && lbErrorUsuario.Text != "")
                lbErrorUsuario.Hide();

            ValidateUsername();
        }

        // Key Downs
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ValidateUsername();
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSalario.Focus();
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (ValidateSalary())
                {
                    lbErrorSalario.Text = "Salario valido";
                    lbErrorSalario.ForeColor = Color.Green;
                    lbErrorSalario.Show();
                    cbFormaPago.Focus();
                    ValidateUsername();
                }
                else
                {
                    txtSalario.Focus();
                    lbErrorSalario.Text = "Formato invalido";
                    lbErrorSalario.ForeColor = Color.Red;
                    lbErrorSalario.Show();
                }
        }

        // Misceleanous
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorUsuario.Visible && lbErrorUsuario.Text != "")
                lbErrorUsuario.Hide();

            ValidateUsername();
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorUsuario.Visible && lbErrorUsuario.Text != "")
                lbErrorFormaPago.Hide();

            ValidateUsername();
        }

        // Auxiliary Functions
        private void ValidateUsername()
        {
            if (txtNombreUsuario.Text != "")
            {
                string message = CapaNegocios.ConsultarNegocios.ValidateNewUsername(txtNombreUsuario.Text);

                if (message == "Disponible")
                {
                    cbCargo.Focus();
                    lbErrorUsuario.Text = "Disponible!";
                    lbErrorUsuario.ForeColor = Color.Green;
                    lbErrorUsuario.Show();
                }
                else
                {
                    txtNombreUsuario.Focus();
                    txtNombreUsuario.Text = "";
                    lbErrorUsuario.Text = "Este nombre de usario no esta disponible";
                    lbErrorUsuario.ForeColor = Color.Red;
                    lbErrorUsuario.Show();
                }
            }
            else
            {
                txtNombreUsuario.Focus();
                lbErrorUsuario.Text = "Favor elegir nombre de usuario";
                lbErrorUsuario.ForeColor = Color.Red;
                lbErrorUsuario.Show();
            }
        }

        private bool ValidateSalary()
        {
            float n;
            return float.TryParse(txtSalario.Text, out n);
        }
    }
}
