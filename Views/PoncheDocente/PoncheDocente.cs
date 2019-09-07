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

namespace SistemaPoncheOficial.Views.Ponche_Docente
{
    public partial class PoncheDocente : Form
    {
        public PoncheDocente()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void RefrescarDGV()
        {

            dgvAccesos.Rows.Clear();
            List<PoncheDocenteModel> listaAccesos = new PoncheDocenteController().GetPoncheDocentes();

            foreach (PoncheDocenteModel item in listaAccesos)
            {
                dgvAccesos.Rows.Add(
                   item.IdPonche,
                   item.IdDocente,
                   item.status,
                   item.HoraEntrada,
                   item.HoraSalida
                );
            }

        }

        private void PoncheDocente_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }
    }
}
