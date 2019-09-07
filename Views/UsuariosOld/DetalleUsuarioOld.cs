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

namespace SistemaPoncheOficial.Views.Usuarios
{
    public partial class DetalleUsuario : Form
    {
        private bool status;
        private bool statusCMB;
        private string idUsuario;
        public DetalleUsuario(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void DetalleUsuario_Load(object sender, EventArgs e)
        {
            DesactivarTxts(status = true, statusCMB = false);
            btnConfirmarEdit.Enabled = false;
            LlenarTxt();
        }
        private void DesactivarTxts(bool status,bool statusCMB)
        {
            //txtNombreUsuario.ReadOnly = status;
            //txtContrasena.ReadOnly = status;
            //txtIdUsuario.ReadOnly = true;
            //cmbIdPersona.Enabled = statusCMB;
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            DesactivarTxts(status = false,statusCMB= true);
            btnConfirmarEdit.Enabled = true;

        }

        private void LlenarTxt()
        {
            foreach(var item in new UsuariosController().SelectUsuarioByID(idUsuario))
            {
                //this.txtNombreUsuario.Text = item.Usuario;
                //this.txtContrasena.Text = item.Contrasena;
                //this.cmbIdPersona.Text = item.IdPersona.ToString();
                //this.txtIdUsuario.Text = item.IdUsuario.ToString();

            }

        }
        private void BtnConfirmarEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere editar este Usuario?", "Editar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new UsuariosController().UpdateUsuario(
                    new Models.UsuariosModel
                    {
                        //Usuario = this.txtNombreUsuario.Text,
                        //Contrasena = this.txtContrasena.Text,
                        //IdUsuario = Convert.ToInt32(this.txtIdUsuario.Text),
                        //IdPersona = Convert.ToInt32(this.cmbIdPersona.Text),
                        
                       

                    }
                ); DesactivarTxts(status = true, statusCMB = false);
            }
            else
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    new UsuariosController().DeleteUsuario(

            //        new Models.UsuariosModel
            //        {
            //             IdUsuario = Convert.ToInt32(txtIdUsuario.Text)
            //        }

            //        );

            //}
            //MessageBox.Show("Usuario Elimnado correctamente"); this.Hide();
          
        }
         
}
    }

