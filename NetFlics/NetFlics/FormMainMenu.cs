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

namespace NetFlics
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
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
    }
}
