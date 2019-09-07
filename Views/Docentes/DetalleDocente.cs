using SistemaPoncheOficial.Controllers;
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
using SistemaPoncheOficial.Controllers.Docentes;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Models.Docentes;

namespace SistemaPoncheOficial.Views
{
    public partial class DetalleDocente : Form
    {
        public string idDocente= "";
        public string idPersona= "";
        public DetalleDocente(string idDocente,string idPersona)
        {
            InitializeComponent();
            this.idDocente = idDocente;
            this.idPersona = idPersona;
        }
        private void LlenarCBModalidad()
        {
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

        private void DetalleDocente_Load(object sender, EventArgs e)
        {
            LlenarCBArea();
            LlenarCBModalidad();
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
                this.txtIdPersona.Text = item.IdPersona;

            }

            string idModalidad = "";
            foreach (ModalidadContratoModel item in new ModalidadContratoController().SelectNombreModalidad(cbModalidad.Text))
            {
                idModalidad = item.IdModalidad.ToString();
            }
            string idArea = "";
            foreach (AreaDocenteModel item in new AreaDocenteController().SelectAreaDocenteByNombre(CBArea.Text))
            {
                idArea = item.IdAreaDocente.ToString();
            }
            new DocentesController().UpdateDocentes(
            new DocentesModel
            {
                PrecioDocente = Convert.ToDouble(this.txtPrecioDocente.Text),
                CodigoPonche = this.txtCodigoPonche.Text,
                IdModalidad = Convert.ToInt32(idModalidad),
                IdAreaDocente = Convert.ToInt32(idArea),
                IdPersona = Convert.ToInt32(idPersona)
            }
            );

            foreach (var item2 in new DocentesController().SelectDocenteByID(idDocente))
            {
                this.txtPrecioDocente.Text = item2.PrecioDocente.ToString();
            }
        }
    }
}
