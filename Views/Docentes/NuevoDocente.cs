using System;
using System.Windows.Forms;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Controllers.Docentes;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Models.Docentes;

namespace SistemaPoncheOficial.Views.Docentes
{
    public partial class NuevoDocente : Form
    {
        public NuevoDocente()
        {
            InitializeComponent();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

        }

        private void LimpiarCampos()
        {
            txtCodigoPonche.Clear();
            txtPrecioDocente.Clear();
            this.txtPrimerNombre.Clear();
            this.txtSegundoNombre.Clear();
            this.txtPrimerApellido.Clear();
            this.txtSegundoApellido.Clear();
            this.txtDocumentoIdentidad.Clear();
            this.txtTelefono1.Clear();
            this.txtTelefono2.Clear();
            this.txtTelefono3.Clear();
            this.txtCalleDirreccion.Clear();
            this.txtNumeroDirrecion.Clear();
            this.txtSectorDirreccion.Clear();
            this.txtCiudadDirrecion.Clear();
            this.txtPaisDirrecion.Clear();
            this.txtCorreo.Clear();
            this.txtNacionalidad.Clear();
            this.txtReferenciaDirreccion.Clear();
            txtPrecioDocente.Clear();
        }

        private int GenerarCodigo()
        {
            int rangoA = 1000;
            int rangoB = 9999;
            Random codigoRamdom = new Random();
            return codigoRamdom.Next(rangoA, rangoB);
        }
        private void NuevoDocente_Load(object sender, EventArgs e)
        {
            int codigo = GenerarCodigo();
            this.txtCodigoPonche.Text = codigo.ToString();
            LlenarCBModalidad();
            LlenarCBArea();
        }

        private void LlenarCBModalidad() {
            foreach (ModalidadContratoModel item in new ModalidadContratoController().SelectModalidadContratos())
            {
                cbModalidad.Items.Add(item.NombreModaliad.ToString());
            }
        }

        private void LlenarCBArea()
        {
            foreach (AreaDocenteModel item in new AreaDocenteController().SelectAreaDocente())
            {
                CBArea.Items.Add(item.NombreArea.ToString());
            }
        }
        private void BtnRegistrarDocente_Click(object sender, EventArgs e)
        {
            if (txtPrecioDocente.Text != "" || txtCodigoPonche.Text != "")
            {  
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que quiere agregar esta usuario?", "Agregar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    new PersonasController().InsetarPersona(
                        
                        new PersonasModel {
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
                    string idPersona = "";
                    foreach (PersonasModel item in new PersonasController().RetornoMaxID())
                    {
                        idPersona = item.IdPersona.ToString();
                    }
                    string idModalidad = "";
                    foreach (ModalidadContratoModel item in new ModalidadContratoController().SelectNombreModalidad(cbModalidad.Text))
                    {
                        idModalidad = item.IdModalidad.ToString( );
                    }
                    string idArea ="";
                    foreach (AreaDocenteModel item in new AreaDocenteController().SelectAreaDocenteByNombre(CBArea.Text))
                    {
                        idArea = item.IdAreaDocente.ToString();
                    }
                    new DocentesController().InsetarDocentes(
                    new DocentesModel
                    {
                        PrecioDocente = Convert.ToDouble(this.txtPrecioDocente.Text),
                        CodigoPonche = this.txtCodigoPonche.Text,
                        IdModalidad = Convert.ToInt32( idModalidad),
                        IdAreaDocente = Convert.ToInt32(idArea),
                        IdPersona = Convert.ToInt32(idPersona)
                    }
                    );
                }
                MessageBox.Show("Usuario Registrado correctamente"); LimpiarCampos();GenerarCodigo();
            }
            else
            {
                MessageBox.Show("Debe llenar los campos");
            }
        }

     
    }
}
