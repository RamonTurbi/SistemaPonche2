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

namespace SistemaPoncheOficial.Views
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
        }
        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(new AccessConnectionController().ConnectToAccess());

            //DataTable data = new AccessConnectionController().ConnectToAccess();
            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    for (int p = 0; p < data.Columns.Count; p++)
            //    {
            //        MessageBox.Show(data.Rows[i].ItemArray[p].ToString());
            //    }
            //}
            //    if (txtNombreUsuario.Text  != "" || txtContrasena.Text != "")
            //    {
            //            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere agregar esta usuario?", "Agregar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //            if (dialogResult == DialogResult.Yes)
            //            {
            //                new PersonasController().InsetarPersona(

            //                    new PersonasModel
            //                    {
            //                        PrimerNombre = this.txtPrimerNombre.Text,
            //                        SegundoNombre = this.txtSegundoNombre.Text,
            //                        PrimerApellido = this.txtPrimerApellido.Text,
            //                        SegundoApellido = this.txtSegundoApellido.Text,
            //                        Documento = this.txtDocumentoIdentidad.Text,
            //                        TipoDocumento = this.cmbTipoDocumento.Text,
            //                        Telefono1 = this.txtTelefono1.Text,
            //                        TipoTelefono1 = this.cmbTipoTelefono1.Text,
            //                        Telefono2 = this.txtTelefono2.Text,
            //                        TipoTelefono2 = this.cmbTipoTelefono2.Text,
            //                        Telefono3 = this.txtTelefono3.Text,
            //                        TipoTelefono3 = this.cmbTipoTelefono3.Text,
            //                        CalleDireccion = this.txtCalleDirreccion.Text,
            //                        NumeroDireccion = this.txtNumeroDirrecion.Text,
            //                        SectorDireccion = this.txtSectorDirreccion.Text,
            //                        CiudadDireccion = this.txtCiudadDirrecion.Text,
            //                        PaisDireccion = this.txtPaisDirrecion.Text,
            //                        Correo = this.txtCorreo.Text,
            //                        Nacionalidad = this.txtNacionalidad.Text,
            //                        Sexo = this.cmbsexo.Text,
            //                        ReferenciaDireccion = this.txtReferenciaDirreccion.Text
            //                    }
            //                    );

            //            foreach (PersonasModel item in new PersonasController().RetornoMaxID())
            //            {
            //               int idPersona = item.IdPersona;
            //                new UsuariosController().InsetarUsuario(
            //              new UsuariosModel
            //              {
            //                  Usuario = this.txtNombreUsuario.Text,
            //                  Contrasena = this.txtContrasena.Text,
            //                  IdPersona = Convert.ToInt32(idPersona)
            //              }
            //                 );
            //            }

            //        }

            //        MessageBox.Show("Usuario Registrado correctamente"); LimpiarCampos();
            //    } 
            //    else
            //    {
            //        MessageBox.Show("Debe llenar los campos");
            //    } 
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
