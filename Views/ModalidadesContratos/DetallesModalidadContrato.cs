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
    public partial class DetallesModalidadContrato : Form
    {
        string idModalidad;
        public DetallesModalidadContrato(string idModalidad)
        {
            InitializeComponent();
            this.idModalidad = idModalidad;
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void DetallesModalidadContrato_Load(object sender, EventArgs e)
        {
            txtNombreModalidad.ReadOnly = true;
            btnConfirmEdit.Enabled = false;
            LlenarTxts();

        }
        public void LlenarTxts()
        {
            foreach (var item in new ModalidadContratoController().SelectModalidadContratoByID(idModalidad))
            {
                this.txtNombreModalidad.Text = item.NombreModaliad;
                this.txtIdModalidad.Text = item.IdModalidad.ToString();

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txtNombreModalidad.ReadOnly = false;
            btnConfirmEdit.Enabled = true;
        }

        private void BtnConfirmEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere editar esta Modalidad?", "Editar Modalidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new ModalidadContratoController().UpdateModalidadContrato(
                    new ModalidadContratoModel
                    {
                        NombreModaliad = this.txtNombreModalidad.Text,
                        IdModalidad = System.Convert.ToInt32(this.txtIdModalidad.Text)

                    }
                ); txtNombreModalidad.ReadOnly = true;  btnConfirmEdit.Enabled = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar esta Modalidad?", "Eliminar Modalidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new ModalidadContratoController().DeleteModalidadContrato(
                    new ModalidadContratoModel
                    {
                        IdModalidad = System.Convert.ToInt32(this.txtIdModalidad.Text)
                    }
                );
                MessageBox.Show("Persona Modalidad correctamente"); this.Hide();
            }
        }
    }
}
