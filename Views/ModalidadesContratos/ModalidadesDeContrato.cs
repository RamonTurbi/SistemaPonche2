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
    public partial class ModalidadesDeContrato : Form
    {
        public ModalidadesDeContrato()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }
        private void RefrescarDGV()
        {

            dgvModalidades.Rows.Clear();
            List<ModalidadContratoModel> listaModalidad = new ModalidadContratoController().SelectModalidadContratos();

            foreach (ModalidadContratoModel item in listaModalidad)
            {
                dgvModalidades.Rows.Add(
                   item.IdModalidad.ToString(),
                   item.NombreModaliad,
                   item.Creado.ToString(),
                   item.Modificado.ToString()
                );
            }

        }

        private void ModalidadesDeContrato_Load_1(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new NuevaModalidad().Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            new DetallesModalidadContrato(dgvModalidades.CurrentRow.Cells[0].Value.ToString()).Show(); 
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RefrescarDGV();

        }
    }
}
