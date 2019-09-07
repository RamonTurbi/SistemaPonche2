using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPoncheOficial.Models
{
    class PoncheDocenteModel
    {
         public int IdPonche { get; set; }
         public int IdDocente { get; set; }
         public string status { get; set; }
         public DateTime HoraEntrada { get; set; }
         public DateTime HoraSalida { get; set; }
    }
}
