using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Controllers;

namespace SistemaPoncheOficial.Views.AreaDocentes
{
    public partial class AreasDocentes : Form
    {
        public AreasDocentes()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void RefrescarDGV()
        {

            dgvAreaDocente.Rows.Clear();
            List<AreaDocenteModel> listaAreas = new AreaDocenteController().SelectAreaDocente();

            foreach (AreaDocenteModel item in listaAreas)
            {
                dgvAreaDocente.Rows.Add(
                    item.IdAreaDocente.ToString(),
                    item.NombreArea,
                    item.EncargadoArea,
                    item.CantidadAulas.ToString(),
                    item.CantidadMaestros.ToString(),
                    item.Creado.ToString(),
                    item.Modificado.ToString()
                    
                );
            }

        }

        private void AreasDocentes_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new NuevaArea().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            new DetalleArea(dgvAreaDocente.CurrentRow.Cells[0].Value.ToString()).Show();
        }
    }
}
