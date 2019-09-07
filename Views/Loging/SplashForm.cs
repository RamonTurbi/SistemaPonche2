using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPoncheOficial.Views.Loging
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            pgb1.Width += 5;
            
            if (pgb1.Width >= 591)
            {
                timer1.Stop();
                this.Hide();
                new LoginUsuario().Show();
            }
        }
    }
}
