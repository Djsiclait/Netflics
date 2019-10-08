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
    public partial class FormModifyUser : Form
    {
        private string username;

        private User fetchedUser;

        public FormModifyUser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormModifyUser_Load(object sender, EventArgs e)
        {
            CleanBuffer();
            FillFormWithUserData();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            string message = CapaNegocios.ModificarNegocios.UserLogOut(CapaEntidad.UserSession.userSession.username, "MAIN");

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

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Formularios.formModifyUser.Dispose();

            // Returning to users master
            Formularios.formUsersMaster = new FormUsersMaster();
            Formularios.formUsersMaster.Show();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            bool clean = true;

            if (cbCargo.Text == "")
            {
                lbErrorCargo.Show();
                clean = false;
            }

            if (txtSalario.Text == "")
            {
                lbErrorSalario.Text = "Favor introducir salario";
                lbErrorSalario.ForeColor = Color.Red;
                lbErrorSalario.Show();
                clean = false;
            }
            else if (!ValidateSalary())
            {
                lbErrorSalario.Text = "Formato invalido";
                lbErrorSalario.ForeColor = Color.Red;
                lbErrorSalario.Show();
                clean = false;
            }

            if (cbFormaPago.Text == "")
            {
                lbErrorFormaPago.Show();
                clean = false;
            }

            if (cbRol.Text == "")
            {
                lbErrorRol.Show();
                clean = false;
            }

            if (cbSucursal.Text == "")
            {
                lbErrorSucursal.Show();
                clean = false;
            }

            if (txtNombre.Text == "")
            {
                lbErrorNombre.Show();
                clean = false;
            }

            if (txtApellido.Text == "")
            {
                lbErrorApellido.Show();
                clean = false;
            }

            // TODO: validate that 1234 isint considered a firstname or lastname

            if (cbTipoDocumento.Text == "")
            {
                lbErrorTipoDocumento.Show();
                clean = false;
            }

            if (txtDocumento.Text == "")
            {
                lbErrorDocumento.Show();
                clean = false;
            }

            if (txtCorreo.Text == "")
            {
                lbErrorCorreo.Text = "Favor introducir un correo";
                lbErrorCorreo.ForeColor = Color.Red;
                lbErrorCorreo.Show();
                clean = false;
            }
            else if (!ValidateEmail())
            {
                lbErrorCorreo.Text = "Formato invalido";
                lbErrorCorreo.ForeColor = Color.Red;
                lbErrorCorreo.Show();
                clean = false;
            }

            if (cbSexo.Text == "")
            {
                lbErrorSexo.Show();
                clean = false;
            }

            // TODO: Validate Date of birth to exclude minors < 18

            if (cbNacionalidad.Text == "")
            {
                lbErrorNacionalidad.Show();
                clean = false;
            }

            // Telefono 1
            if (txtTelefono1.Text == "")
            {
                lbErrorTelefono1.Text = "Favor introducir un numero de telefono";
                lbErrorTelefono1.ForeColor = Color.Red;
                lbErrorTelefono1.Show();
                clean = false;
            }
            else if (!ValidatePhoneNumber(txtTelefono1.Text))
            {
                lbErrorTelefono1.Text = "Formato invalido";
                lbErrorTelefono1.ForeColor = Color.Red;
                lbErrorTelefono1.Show();
                clean = false;
            }

            if (cbTipo1.Text == "")
            {
                lbErrorTipo1.Show();
                clean = false;
            }

            // Telefono 2 -- Optional
            if (txtTelefono2.Text != "" && !ValidatePhoneNumber(txtTelefono2.Text))
            {
                lbErrorTelefono2.Text = "Formato invalido";
                lbErrorTelefono2.ForeColor = Color.Red;
                lbErrorTelefono2.Show();
                clean = false;
            }

            if (txtTelefono2.Text != "" && cbTipo2.Text == "")
            {
                lbErrorTipo2.Show();
                clean = false;
            }

            // Direccion
            if (txtDireccion.Text == "")
            {
                lbErrorDireccion.Show();
                clean = false;
            }

            if (cbTipoDireccion.Text == "")
            {
                lbErrorTipoDireccion.Show();
                clean = false;
            }

            if (txtSector.Text == "")
            {
                lbErrorSector.Show();
                clean = false;
            }

            if (txtCiudad.Text == "")
            {
                lbErrorCiudad.Show();
            }


        }

        // Key Downs
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbCargo.Focus();
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorCargo.Visible && cbCargo.Text != "")
                    lbErrorCargo.Hide();

                txtSalario.Focus();
            }
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (ValidateSalary())
                {
                    lbErrorSalario.Text = "Salario valido!";
                    lbErrorSalario.ForeColor = Color.Green;
                    lbErrorSalario.Show();
                    cbFormaPago.Focus();
                }
                else
                {
                    txtSalario.Focus();
                    lbErrorSalario.Text = "Formato invalido";
                    lbErrorSalario.ForeColor = Color.Red;
                    lbErrorSalario.Show();
                }
        }

        private void cbFormaPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorFormaPago.Visible && cbFormaPago.Text != "")
                    lbErrorFormaPago.Hide();

                cbRol.Focus();
            }
        }

        private void cbRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorRol.Visible && cbRol.Text != "")
                    lbErrorRol.Hide();

                cbSucursal.Focus();
            }
        }

        private void cbSucursal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorSucursal.Visible && cbSucursal.Text != "")
                    lbErrorSucursal.Hide();

                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorNombre.Visible && txtNombre.Text != "")
                    lbErrorNombre.Hide();

                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorApellido.Visible && txtApellido.Text != "")
                    lbErrorApellido.Hide();

                cbTipoDocumento.Focus();
            }
        }

        private void cbTipoDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorTipoDocumento.Visible && cbTipoDocumento.Text != "")
                    lbErrorTipoDocumento.Hide();

                txtDocumento.Focus();
            }
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorDocumento.Visible && txtDocumento.Text != "")
                    lbErrorDocumento.Hide();

                txtCorreo.Focus();
            }
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (ValidateEmail())
                {
                    lbErrorCorreo.Text = "Correo valido!";
                    lbErrorCorreo.ForeColor = Color.Green;
                    lbErrorCorreo.Show();
                    cbSexo.Focus();
                }
                else
                {
                    txtCorreo.Focus();
                    lbErrorCorreo.Text = "Formato invalido";
                    lbErrorCorreo.ForeColor = Color.Red;
                    lbErrorCorreo.Show();
                }
        }

        private void cbSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorSexo.Visible && cbSexo.Text != "")
                    lbErrorSexo.Hide();

                dtFechaNacimiento.Focus();
            }
        }

        private void dtFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // TODO: Validate Date of birth to exclude minors < 18

                cbNacionalidad.Focus();
            }
        }

        private void cbNacionalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorNacionalidad.Visible && cbNacionalidad.Text != "")
                    lbErrorNacionalidad.Hide();

                txtTelefono1.Focus();
            }
        }

        private void txtTelefono1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (ValidatePhoneNumber(txtTelefono1.Text))
                {
                    lbErrorTelefono1.Text = "Telefono valido!";
                    lbErrorTelefono1.ForeColor = Color.Green;
                    lbErrorTelefono1.Show();
                    cbTipo1.Focus();
                }
                else
                {
                    txtTelefono1.Focus();
                    lbErrorTelefono1.Text = "Formato invalido";
                    lbErrorTelefono1.ForeColor = Color.Red;
                    lbErrorTelefono1.Show();
                }
        }

        private void cbTipo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorTipo1.Visible && cbTipo1.Text != "")
                    lbErrorTipo1.Hide();

                txtTelefono2.Focus();
            }
        }

        private void txtTelefono2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txtTelefono2.Text != "" && ValidatePhoneNumber(txtTelefono2.Text))
                {
                    lbErrorTelefono2.Text = "Telefono valido!";
                    lbErrorTelefono2.ForeColor = Color.Green;
                    lbErrorTelefono2.Show();
                    cbTipo2.Focus();
                }
                else if (txtTelefono2.Text != "")
                {
                    txtTelefono2.Focus();
                    lbErrorTelefono2.Text = "Formato invalido";
                    lbErrorTelefono2.ForeColor = Color.Red;
                    lbErrorTelefono2.Show();
                }
        }

        private void cbTipo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorTipo2.Visible && cbTipo2.Text != "")
                    lbErrorTipo2.Hide();

                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorDireccion.Visible && txtDireccion.Text != "")
                    lbErrorDireccion.Hide();

                cbTipoDireccion.Focus();
            }
        }

        private void cbTipoDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorTipoDireccion.Visible && cbTipoDireccion.Text != "")
                    lbErrorTipoDireccion.Hide();

                txtSector.Focus();
            }
        }

        private void txtSector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorSector.Visible && txtSector.Text != "")
                    lbErrorSector.Hide();

                txtCiudad.Focus();
            }
        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lbErrorCiudad.Visible && txtCiudad.Text != "")
                    lbErrorCiudad.Hide();

                bttAgregar.Focus();
            }
        }


        // Index Change
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorCargo.Visible)
                lbErrorCargo.Hide();
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorFormaPago.Visible)
                lbErrorFormaPago.Hide();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorRol.Visible)
                lbErrorRol.Hide();
        }

        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorSucursal.Visible)
                lbErrorSucursal.Hide();
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorTipoDocumento.Visible)
                lbErrorTipoDocumento.Hide();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorSexo.Visible)
                lbErrorSexo.Hide();
        }

        private void cbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorNacionalidad.Visible)
                lbErrorNacionalidad.Hide();
        }

        private void cbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorTipo1.Visible)
                lbErrorTipo1.Hide();
        }

        private void cbTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorTipo2.Visible)
                lbErrorTipo2.Hide();
        }

        private void cbTipoDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbErrorTipoDireccion.Visible)
                lbErrorTipoDireccion.Hide();
        }

        // Auxiliar Function 
        private float FormatSalary()
        {
            float salary;

        float.TryParse(txtSalario.Text, out salary);

            return salary;
        }

        private bool ValidateSalary()
        {
            float n;
            return float.TryParse(txtSalario.Text, out n);
        }

        private bool ValidateEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtCorreo.Text);

                return addr.Address == txtCorreo.Text;

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR FATAL: " + e.Message);
            }

            return false;

        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            long n;
            return long.TryParse(phoneNumber, out n);
        }

        private void FillFormWithUserData()
        {
            this.fetchedUser = CapaNegocios.ConsultarNegocios.FetchUserData(this.username);

            txtNombreUsuario.Text = fetchedUser.username;
            cbCargo.Text = fetchedUser.position;
            txtSalario.Text = fetchedUser.salary.ToString();
            cbFormaPago.Text = fetchedUser.paymentSchedule;
            cbRol.Text = fetchedUser.role;
            cbSucursal.Text = fetchedUser.branchOffice;

            txtNombre.Text = fetchedUser.firstName;
            txtApellido.Text = fetchedUser.lastName;
            cbTipoDocumento.Text = fetchedUser.identificationType;
            txtDocumento.Text = fetchedUser.identification;
            txtCorreo.Text = fetchedUser.email;
            cbSexo.Text = fetchedUser.gender;
            dtFechaNacimiento.Text = fetchedUser.birthDate.ToString();
            cbNacionalidad.Text = fetchedUser.nationality;

            List<Telephone> telephones = CapaNegocios.ConsultarNegocios.FetchUserTelephoneData(this.username);


            if (telephones.Count > 0)
                if (telephones[0].phoneNumber != "" || telephones[0].phoneNumber != null)
                {
                    txtTelefono1.Text = telephones[0].phoneNumber;
                    cbTipo1.Text = telephones[0].phoneType;
                }

            if (telephones.Count > 1)
                if (telephones[1].phoneNumber != "" || telephones[1].phoneNumber != null)
                {
                    txtTelefono2.Text = telephones[1].phoneNumber;
                    cbTipo2.Text = telephones[1].phoneType;
                }

        }

        private void CleanBuffer()
            {
                lbErrorApellido.Hide();
                lbErrorCargo.Hide();
                lbErrorCiudad.Hide();
                lbErrorCorreo.Hide();
                lbErrorDireccion.Hide();
                lbErrorDocumento.Hide();
                lbErrorFechaNacimiento.Hide();
                lbErrorFormaPago.Hide();
                lbErrorNacionalidad.Hide();
                lbErrorNombre.Hide();
                lbErrorRol.Hide();
                lbErrorSalario.Hide();
                lbErrorSector.Hide();
                lbErrorSexo.Hide();
                lbErrorSucursal.Hide();
                lbErrorTelefono1.Hide();
                lbErrorTelefono2.Hide();
                lbErrorTipo1.Hide();
                lbErrorTipo2.Hide();
                lbErrorTipoDireccion.Hide();
                lbErrorTipoDocumento.Hide();
            }
    }
}
