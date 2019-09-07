using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaPoncheOficial.Models
{
    class PersonasModel
    {
            
        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }       
        public string Telefono1 { get; set; }
        public string TipoTelefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string TipoTelefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string TipoTelefono3 { get; set; }
        public string CalleDireccion { get; set; }
        public string NumeroDireccion { get; set; }
        public string SectorDireccion { get; set; }
        public string CiudadDireccion { get; set; }
        public string PaisDireccion { get; set; }
        public string ReferenciaDireccion { get; set; }
        public string Correo { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
        public string Eliminado { get; set; }
    }
}


