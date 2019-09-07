using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Models.Docentes;


namespace SistemaPoncheOficial.Controllers.Docentes
{
    class DocentesController
    {
        ConexionDB conexionDB = new ConexionDB();
        AccessConnectionController accessConnection = new AccessConnectionController();

        public List<DocentesModel> SelectDocentes()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;  
                return conexionDB.Conectar().Query<DocentesModel>("SELECT * from docentes").ToList();
        }
        public List<DocentesModel> SelectDocenteByID(string id_docente)
        {
            return conexionDB.Conectar().Query<DocentesModel>("Select * from docentes where id_usuario=" + id_docente).ToList();
        }
        
        public int InsetarDocentes(DocentesModel docentesModel)
        {
            return conexionDB.Conectar().Execute("Insert into docentes(precio_docente,codigo_ponche,id_modalidad,id_area_docente,id_persona)VALUES(@PrecioDocente,@CodigoPonche," +
                "@IdModalidad,@IdAreaDocente,@IdPersona)", docentesModel);  
        }
        public int DeleteDocentes(DocentesModel docentesModel)
        {
            return conexionDB.Conectar().Execute("Update docentes set eliminado='si' where id_usuario=@IdUsuario", docentesModel);
        }
        public int UpdateDocentes(DocentesModel docentesModel)
        {
            return conexionDB.Conectar().Execute("Update docentes set precio_docente=@PrecioDocente,codigo_ponche=@CodigoPonche,id_modalidad=@IdModalidad," +
                "id_area_docente=@IdAreaDocente,id_persona=@IdPersona where id_docente=@IdDocente", docentesModel);
        }
        //public void llenarGrid(DataGridView dataGridView)
        //{
        //    MySqlCommand cm = new MySqlCommand("SELECT d.id_docente,p.primer_nombre,d.precio_docente,d.codigo_ponche,m.nombre_modaliad,a.nombre_area,d.creado,d.modificado" +
        //        "FROM [docentes] [d] INNER JOIN personas p [INNER JOIN] modalidades_contrato m [INNER JOIN] area_docente a" +
        //        "WHERE d.eliminado='no' [and] p.id_persona = d.id_persona and d.id_modalidad= m.id_modalidad and " +
        //        "d.id_area_docente = a.id_area_docente",conexionDB.Conectar());
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
        //    DataTable dataTable = new DataTable();

        //    adapter.Fill(dataTable);
        //    dataGridView.DataSource = dataTable;
        //}
    }

}

