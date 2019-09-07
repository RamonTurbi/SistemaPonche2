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

namespace SistemaPoncheOficial.Views.Personas
{
    public partial class NuevaPersona : Form
    {
        public NuevaPersona()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
      
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
           
            if (txtPrimerNombre.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere agregar esta persona?", "Agregar persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    new PersonasController().InsetarPersona(
                        new PersonasModel
                        {
                            PrimerNombre = this.txtPrimerNombre.Text,
                            SegundoNombre = this.txtSegundoNombre.Text,
                            PrimerApellido = this.txtPrimerApellido.Text,
                            SegundoApellido = this.txtSegundoApellido.Text,
                            Documento = this.txtDocumentoIdentidad.Text,
                            TipoDocumento = this.cmbTipoDocumento.Text,
                            Telefono1 = this.txtTelefono1.Text,
                            TipoTelefono1 = this.cmbTipoTelefono1.Text,
                            Telefono2 = this.txtTelefono2.Text,
                            TipoTelefono2 = this.cmbTipoTelefono2.Text,
                            Telefono3 = this.txtTelefono3.Text,
                            TipoTelefono3 = this.cmbTipoTelefono3.Text,
                            CalleDireccion = this.txtCalleDirreccion.Text,
                            NumeroDireccion = this.txtNumeroDirrecion.Text,
                            SectorDireccion = this.txtSectorDirreccion.Text,
                            CiudadDireccion = this.txtCiudadDirrecion.Text,
                            PaisDireccion = this.txtPaisDirrecion.Text,
                            Correo = this.txtCorreo.Text,
                            Nacionalidad = this.txtNacionalidad.Text,
                            Sexo = this.cmbsexo.Text,
                            ReferenciaDireccion = this.txtReferenciaDirreccion.Text
                        }
                    );
                }
            }
            else {
                MessageBox.Show("Ups debes llenar datos");
            }
            
        }

    
    }
}
