using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPoncheOficial.Views;

namespace SistemaPoncheOficial.Views.MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            new Personas.Personas().Show();
        }


        private void BtnUsurios_Click(object sender, EventArgs e)
        {
            new FormUsuarios().Show();

        }

        private void BtnDocentes_Click_1(object sender, EventArgs e)
        {
            new Docentes.Docentes().Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere cerrar seción?", "Cierre de seción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                new Loging.LoginUsuario().Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new AreaDocentes.AreasDocentes().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Ponche_Docente.PoncheDocente().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new ModalidadesContratos.ModalidadesDeContrato().Show();
        }

    }
}
