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
                // TODO: Login Logic
            }
        }
    }
}
