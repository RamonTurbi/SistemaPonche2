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

namespace SistemaPoncheOficial.Views.AreaDocentes
{
    public partial class DetalleArea : Form
    {
        bool status;
        string idAreaDocente;
        public DetalleArea(string idAreaDocente)
        {
            InitializeComponent();
            this.idAreaDocente = idAreaDocente;
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void LlenarTxts()
        {
            foreach (var item in new AreaDocenteController().SelectAreaDocenteByID(idAreaDocente))
            {
                this.txtNombreArea.Text = item.NombreArea;
                this.txtEncargadoArea.Text = item.EncargadoArea;
                this.txtCantidadAulas.Text = item.CantidadAulas.ToString();
                this.txtCantidadMaestros.Text = item.CantidadMaestros.ToString();
                this.txtIdArea.Text = item.IdAreaDocente.ToString();
            }
        }

     
        private void DetalleArea_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            DesactivarTXT(status = true);
            LlenarTxts();
        }
        private void DesactivarTXT(bool status)
        {

            this.txtCantidadAulas.ReadOnly = status;
            this.txtCantidadMaestros.ReadOnly = status;
            this.txtEncargadoArea.ReadOnly = status;
            this.txtNombreArea.ReadOnly = status;
            this.txtIdArea.ReadOnly = true;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DesactivarTXT(status= false);
            btnConfirm.Enabled = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere editar esta Persona?", "Editar Persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new AreaDocenteController().UpdateAreaDocente(
                    new Models.AreaDocenteModel
                    {
                        NombreArea = this.txtNombreArea.Text,
                        EncargadoArea = this.txtEncargadoArea.Text,
                        CantidadAulas = Convert.ToInt32(this.txtCantidadAulas.Text),
                        CantidadMaestros = Convert.ToInt32(this.txtCantidadMaestros.Text),
                        IdAreaDocente = Convert.ToInt32(this.txtIdArea.Text)

                    }
                ); DesactivarTXT(status = true);
            }
            else
            {

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar esta Area?", "Eliminar Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new AreaDocenteController().DeleteAreaDocente(
                    new Models.AreaDocenteModel
                    {
                        IdAreaDocente = System.Convert.ToInt32(this.txtIdArea.Text)
                    }
                );
                MessageBox.Show("Area eliminada correctamente"); this.Hide(); 

            }

            else
            {

            }
        }
    }
}
