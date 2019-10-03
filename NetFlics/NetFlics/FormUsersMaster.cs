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
                CapaEntidad.UserSession.userSession = new UserSession(); // Clear user session data for future log in
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
    }
}
