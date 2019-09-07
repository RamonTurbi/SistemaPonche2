using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Views.Usuarios;
using SistemaPoncheOficial.Controllers;
using System.Data;

namespace SistemaPoncheOficial.Views
{
    public partial class FormUsuarios : Form
    {

        public FormUsuarios()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
        private void RefrescarDGV()
        {

            dgvUsuarios.Rows.Clear();
            List<UsuariosModel> listaUsuario = new UsuariosController().SelectUsuarios();

            foreach (UsuariosModel item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(
                    item.IdUsuario.ToString(),
                    item.Usuario.ToString(),
                    item.Contrasena.ToString(),
                    item.IdPersona.ToString(),
                    item.Creado.ToString(),
                    item.Modificado.ToString()  
                );
            }

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            RefrescarDGV();

        
            dgvUsuarios.DataSource = new AccessConnectionController().ConnectToAccess();
            

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            new DetalleUsuario(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()).Show();
        }

        private void TxtBuscarPersonas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
