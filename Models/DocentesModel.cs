using System;


namespace SistemaPoncheOficial.Models.Docentes
{
    class DocentesModel
    {
        public int IdDocente { get; set; }
        public double PrecioDocente { get; set; }
        public string CodigoPonche { get; set; }
        public int IdModalidad { get; set; }
        public int IdAreaDocente { get; set; }
        public int IdPersona { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }

    }
}
