using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPoncheOficial.Models;
using Dapper;

namespace SistemaPoncheOficial.Controllers
{
    class AreaDocenteController
    {
        ConexionDB conexionDB = new ConexionDB();

        public List<AreaDocenteModel> SelectAreaDocente()
        {
            return conexionDB.Conectar().Query<AreaDocenteModel>("Select * from area_docente where eliminado='no'").ToList();
        }
        public List<AreaDocenteModel> SelectAreaDocenteByID(string idAreaDocente)
        {
            return conexionDB.Conectar().Query<AreaDocenteModel>("Select * from area_docente where id_area_docente=" + idAreaDocente).ToList();
        }
        public List<AreaDocenteModel> SelectAreaDocenteByNombre(string NombreArea)
        {
            return conexionDB.Conectar().Query<AreaDocenteModel>("Select id_area_docente from area_docente where nombre_area=+ '"+NombreArea+"'").ToList();
        }
        public int InsetarAreaDocente(AreaDocenteModel areaDocenteModel)
        {
            return conexionDB.Conectar().Execute("Insert into area_docente(nombre_area,encargado_area,cantidad_aulas,cantidad_maestros)VALUES(@NombreArea,@EncargadoArea,@CantidadAulas," +
                "@CantidadMaestros)", areaDocenteModel);
        }
        public int DeleteAreaDocente(AreaDocenteModel areaDocenteModel)
        {
            return conexionDB.Conectar().Execute("Update area_docente set eliminado='si' where id_area_docente=@IdAreaDocente", areaDocenteModel);
        }
        public int UpdateAreaDocente(AreaDocenteModel areaDocenteModel)
        {
            return conexionDB.Conectar().Execute("Update area_docente set nombre_area=@NombreArea,encargado_area=@EncargadoArea,cantidad_aulas=@CantidadAulas," +
                "cantidad_maestros=@CantidadMaestros where id_area_docente=@IdAreaDocente", areaDocenteModel);

        }
    }
}
