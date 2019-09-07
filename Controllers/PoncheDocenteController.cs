using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPoncheOficial.Models;
using SistemaPoncheOficial.Controllers;
using Dapper;

namespace SistemaPoncheOficial.Controllers
{
    class PoncheDocenteController
    {
        ConexionDB conexionDB = new ConexionDB();
       public List<PoncheDocenteModel> GetPoncheDocentes()
        {
            return conexionDB.Conectar().Query<PoncheDocenteModel>("Select * from ponche_docente").ToList();
        }
       public List<PoncheDocenteModel> GetPoncheDocentesByID(string idPoncheDocente)
        {
            return conexionDB.Conectar().Query<PoncheDocenteModel>("Select * from ponche_docente where id_ponche='"+idPoncheDocente+"'").ToList();
        }

    }
}
