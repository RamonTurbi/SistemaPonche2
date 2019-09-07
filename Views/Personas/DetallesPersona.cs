
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Models;


namespace SistemaPoncheOficial.Views.Personas
{
    public partial class DetallesPersona : Form
    {

        bool status;
        bool statusCmb;
        public string idPersona;
        public DetallesPersona(string idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        public void LlenarTxts()
        {
            foreach (var item in new PersonasController().SelectPersonaByID(idPersona))
            {
                this.txtPrimerNombre.Text = item.PrimerNombre;
                this.txtSegundoNombre.Text = item.SegundoNombre;
                this.txtPrimerApellido.Text = item.PrimerApellido;
                this.txtSegundoApellido.Text = item.SegundoApellido;
                this.txtDocumentoIdentidad.Text = item.Documento;
                this.cmbTipoDocumento.Text = item.TipoDocumento;
                this.txtTelefono1.Text = item.Telefono1;
                this.cmbTipoTelefono1.Text = item.TipoTelefono1;
                this.txtTelefono2.Text = item.Telefono2;
                this.cmbTipoTelefono2.Text = item.TipoTelefono2;
                this.txtTelefono3.Text = item.Telefono3;
                this.cmbTipoTelefono3.Text = item.TipoTelefono3;
                this.txtCalleDirreccion.Text = item.CalleDireccion;
                this.txtNumeroDirrecion.Text = item.NumeroDireccion;
                this.txtSectorDirreccion.Text = item.SectorDireccion;
                this.txtCiudadDirrecion.Text = item.CiudadDireccion;
                this.txtPaisDirrecion.Text = item.PaisDireccion;
                this.txtCorreo.Text = item.Correo;
                this.txtNacionalidad.Text = item.Nacionalidad;
                this.cmbsexo.Text = item.Sexo;
                this.txtReferenciaDirreccion.Text = item.ReferenciaDireccion;
                this.txtIdPersona.Text = item.IdPersona.ToString();
                
            }
        }

        private void DesactivarTXT(bool status,bool statusCmb)
        {
            
            this.txtPrimerNombre.ReadOnly = status;
            this.txtSegundoNombre.ReadOnly = status;
            this.txtPrimerApellido.ReadOnly = status;
            this.txtSegundoApellido.ReadOnly = status;
            this.txtDocumentoIdentidad.ReadOnly = status;
            this.cmbTipoDocumento.Enabled = statusCmb;
            this.txtTelefono1.ReadOnly = status;
            this.cmbTipoTelefono1.Enabled = statusCmb;
            this.txtTelefono2.ReadOnly = status;
            this.cmbTipoTelefono2.Enabled = statusCmb;
            this.txtTelefono3.ReadOnly = status;
            this.cmbTipoTelefono3.Enabled = statusCmb;
            this.txtCalleDirreccion.ReadOnly = status;
            this.txtNumeroDirrecion.ReadOnly = status;
            this.txtSectorDirreccion.ReadOnly = status;
            this.txtCiudadDirrecion.ReadOnly = status;
            this.txtPaisDirrecion.ReadOnly = status;
            this.txtCorreo.ReadOnly = status;
            this.txtNacionalidad.ReadOnly = status;
            this.cmbsexo.Enabled = statusCmb;
            this.txtReferenciaDirreccion.ReadOnly = status;
            this.txtIdPersona.ReadOnly = true;

        }

        private void DetallesPersona_Load(object sender, System.EventArgs e)
        {
            DesactivarTXT(status = true,statusCmb= false);
            btnConfirmEdit.Enabled = false;
            LlenarTxts();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            DesactivarTXT(status = false, statusCmb = true);
            btnConfirmEdit.Enabled = true;
        }

        private void BtnConfirmEdit_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere editar esta Persona?", "Editar Persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new PersonasController().UpdatePersona(
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
                        ReferenciaDireccion = this.txtReferenciaDirreccion.Text,
                        IdPersona = System.Convert.ToInt32(this.txtIdPersona.Text)
                        
            }
                ); DesactivarTXT(status = true, statusCmb = false);
            }
            else
            {

            }
        }

        private void BtnRegistrar_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar esta Persona?", "Eliminar Persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new PersonasController().DeletePersona(
                    new PersonasModel
                    {
                        IdPersona = System.Convert.ToInt32(this.txtIdPersona.Text)
                    }
                );
               MessageBox.Show("Persona eliminada correctamente"); this.Hide();
            }
            else
            {

            }
        }
    }
}