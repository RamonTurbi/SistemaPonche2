using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPoncheOficial.Models
{
    class UsuariosModel
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int IdPersona { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }

    }
}
