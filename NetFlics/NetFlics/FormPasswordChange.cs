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

        }
    }
}
