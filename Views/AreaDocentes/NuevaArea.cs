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

namespace SistemaPoncheOficial.Views.AreaDocentes
{
    public partial class NuevaArea : Form
    {
        public NuevaArea()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            this.txtNombreArea.Clear();
            this.txtEncargadoArea.Clear();
            this.txtCantidadAulas.Clear();
            this.txtCantidadMaestros.Clear();

        }
        private void BtnRegistrarArea_Click(object sender, EventArgs e)
        {
            if (txtNombreArea.Text != "" || txtEncargadoArea.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere agregar esta area?", "Agregar area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    new AreaDocenteController().InsetarAreaDocente
                        (
                            new AreaDocenteModel
                            {
                                NombreArea = this.txtNombreArea.Text,
                                EncargadoArea = this.txtEncargadoArea.Text,
                                CantidadAulas = Convert.ToInt32(this.txtCantidadAulas.Text),
                                CantidadMaestros = Convert.ToInt32(this.txtCantidadMaestros.Text)
                            }

                        );
                }MessageBox.Show("Area registrada Correctamente"); LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ups debes llenar datos");
            }
        }
    }
}
