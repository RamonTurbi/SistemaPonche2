using System;
using System.Windows.Forms;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Models;
using System.Collections.Generic;
using System.Data;

namespace SistemaPoncheOficial.Views.Personas
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void DgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new DetallesPersona(dgvPersonas.CurrentRow.Cells[0].Value.ToString()).Show();

        }

        private void RefrescarDGV() {

            dgvPersonas.Rows.Clear();
            List<PersonasModel> listaPersonas = new PersonasController().SelectPersonas();
            
            foreach (PersonasModel item in listaPersonas)
            {
                dgvPersonas.Rows.Add(
                    item.IdPersona.ToString(),
                    item.PrimerNombre + " " + item.SegundoNombre + " "+ item.PrimerApellido + " "+item.SegundoApellido, 
                    item.Documento + " Tipo: " + item.TipoDocumento, item.Nacionalidad, item.Correo, item.Sexo, item.Creado.ToString(),
                    item.Modificado.ToString()
                );
            }

        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new NuevaPersona().Show();
        }
        

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            new DetallesPersona(dgvPersonas.CurrentRow.Cells[0].Value.ToString()).Show();
        }

        private void TxtBuscarPersonas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RefrescarDGV(); 
        }

        private void TxtBuscarPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
