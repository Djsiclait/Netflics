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
    public partial class FormSplash : Form
    {
        private Timer splashTimer = new Timer(); // Splash Timer

        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            Formularios.formSplash = this; // Setting the splash page as the main application
            Formularios.formSplash.FormBorderStyle = FormBorderStyle.None;

            // Establishing a timer for splash page 
            splashTimer.Interval = 1 * 5 * 1000; // 5 seconds; format = min * sec * milsec
            splashTimer.Tick += new EventHandler(SplashTransition);
            splashTimer.Start(); // Start timer countdown
        }

        private void SplashTransition(object sender, EventArgs e) // End result of timer used to transition to login form
        {
            Formularios.formSplash.Hide(); // Hide Splash page

            // Summon Login Page
            Formularios.formLogin = new FormLogin();
            Formularios.formLogin.Show();

            splashTimer.Stop(); // Ending the timer sequence
        }
    }
}
