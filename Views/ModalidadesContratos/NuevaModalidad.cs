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
using SistemaPoncheOficial.Models;

namespace SistemaPoncheOficial.Views.ModalidadesContratos
{
    public partial class NuevaModalidad : Form
    {

        public NuevaModalidad()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreModalidad.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere agregar esta Modalidad?", "Agregar Modalidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    new ModalidadContratoController().InsetarModalidadContrato(
                        new ModalidadContratoModel
                        {
                            NombreModaliad = this.txtNombreModalidad.Text,
                            
                        }
                    );
                }
                MessageBox.Show("Modalidad registrada correctamente"); this.txtNombreModalidad.Clear();
            }
            else
            {
                MessageBox.Show("Ups debes llenar datos");
            }
        }
    }
}
