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
    public partial class FormUsersMaster : Form
    {
        public FormUsersMaster()
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
                Formularios.formMainMenu.Dispose();

                // returning to login page
                Formularios.formLogin = new FormLogin();
                Formularios.formLogin.Show();
            }
            else
                MessageBox.Show("A fatal error has occured");
        }

        private void bttVolver_Click(object sender, EventArgs e)
        {
            Formularios.formUsersMaster.Dispose();

            // Calling Main Menu Page
            Formularios.formMainMenu = new FormMainMenu();
            Formularios.formMainMenu.Show();
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            SearchBarValidation();
        }

        private void FormUsersMaster_Load(object sender, EventArgs e)
        {
            LoadUserRegistry("Todos", "");
        }

        private void LoadUserRegistry(String category, string keyword)
        {
            dgUsuarios.DataSource = CapaNegocios.ConsultarNegocios.SearchUserRegistry(category, keyword);

            dgUsuarios.Columns["username"].HeaderText = "Nombre de Usuario";
            dgUsuarios.Columns["identification"].Visible = false;
            dgUsuarios.Columns["identificationType"].Visible = false;
            dgUsuarios.Columns["firstname"].HeaderText = "Nombre";
            dgUsuarios.Columns["lastname"].HeaderText = "Apellido";
            dgUsuarios.Columns["email"].HeaderText = "Correo";
            dgUsuarios.Columns["gender"].HeaderText = "Sexo";
            dgUsuarios.Columns["birthDate"].Visible = false;
            dgUsuarios.Columns["nationality"].Visible = false;
            dgUsuarios.Columns["position"].HeaderText = "Cargo";
            dgUsuarios.Columns["salary"].Visible = false;
            dgUsuarios.Columns["paymentSchedule"].Visible = false;
            dgUsuarios.Columns["role"].HeaderText = "Rol";
            dgUsuarios.Columns["branchOffice"].HeaderText = "Sucursal";
        }

        private void txtBuscarText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchBarValidation();
        }

        private void SearchBarValidation()
        {
            if (cbBuscarPor.Text == "")
                MessageBox.Show("Favor elegir una categoria de busqueda.");
            else
                LoadUserRegistry(cbBuscarPor.Text, txtBuscarText.Text);
        }

        private void bttNuevoUsuario_Click(object sender, EventArgs e)
        {
            Formularios.formUsersMaster.Dispose();

            // Calling page to add new user to the registry
            Formularios.formNewUser = new FormNewUser();
            Formularios.formNewUser.Show();
        }

        private void bttModificarUsuario_Click(object sender, EventArgs e)
        {
            string selectedUser = dgUsuarios.Rows[dgUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Formularios.formUsersMaster.Dispose();
           
            // Calling page to modify user
            Formularios.formModifyUser = new FormModifyUser(selectedUser);
            Formularios.formModifyUser.Show();
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedUser = dgUsuarios.Rows[dgUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Formularios.formUsersMaster.Dispose();

            // Calling page to modify user
            Formularios.formModifyUser = new FormModifyUser(selectedUser);
            Formularios.formModifyUser.Show();
        }
    }
}
