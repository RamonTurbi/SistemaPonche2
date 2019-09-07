using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPoncheOficial.Models.Docentes;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Controllers.Docentes;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Views;

namespace SistemaPoncheOficial.Views.Docentes
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void RefrescarDGV()
        {
            string valor = 3.ToString();
            dgvDocentes.Rows.Clear();
            List<DocentesModel> listaDocentes = new DocentesController().SelectDocentes();
            foreach (DocentesModel item in listaDocentes)
            {
                string NombreModalidad = "";
                int idModalidad = 0;
                foreach (ModalidadContratoModel item2 in new ModalidadContratoController().SelectModalidadContratoByID(item.IdModalidad.ToString()))
                {
                    NombreModalidad = item2.NombreModaliad; 
                    idModalidad = item2.IdModalidad;
                }
                string NombreArea = "";
                foreach (AreaDocenteModel item3 in new AreaDocenteController().SelectAreaDocenteByID(item.IdAreaDocente.ToString()))
                {
                    NombreArea = item3.NombreArea;
                }


                string NombrePersona = "";
                foreach (PersonasModel item2 in new PersonasController().SelectPersonaByID(item.IdPersona.ToString()))
                {
                    NombrePersona = item2.PrimerNombre + " " + item2.SegundoNombre + " " + item2.PrimerApellido + " " + item2.SegundoApellido;
                }

                dgvDocentes.Rows.Add(
                item.IdDocente,
                NombrePersona,
                item.PrecioDocente,
                item.CodigoPonche,
                NombreModalidad,
                NombreArea,
                item.Modificado,
                item.Modificado
            );
        }
    }

        private void Docentes_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void BtnNuevoDocente_Click(object sender, EventArgs e)
        {
            new NuevoDocente().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            /*RefrescarDGV*/;
        }

        private void BtnDetalleDocente_Click(object sender, EventArgs e)
        {
            new DetalleDocente(dgvDocentes.CurrentRow.Cells[0].Value.ToString(),dgvDocentes.CurrentRow.Cells[1].Value.ToString()).Show();
        }

        private void DgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

