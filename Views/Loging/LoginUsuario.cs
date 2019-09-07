using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Views;

namespace SistemaPoncheOficial.Views.Loging
{
    public partial class LoginUsuario : Form
    {
        
        public LoginUsuario()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool resultado = new UsuariosController().SelectLogin(this.txtUser.Text,this.txtPwd.Text);
            if (resultado)
            {
                new MenuPrincipal.MenuPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
