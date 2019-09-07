using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPoncheOficial.Models
{
    class AreaDocenteModel
    {
        public int IdAreaDocente { get; set; }
        public string NombreArea { get; set; }
        public string EncargadoArea { get; set; }
        public int CantidadAulas { get; set; }
        public int CantidadMaestros { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
    }
}
