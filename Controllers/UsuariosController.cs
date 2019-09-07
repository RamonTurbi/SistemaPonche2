using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPoncheOficial.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace SistemaPoncheOficial.Controllers
{
    class UsuariosController
    {
        ConexionDB conexionDB = new ConexionDB();

        public List<UsuariosModel> SelectUsuarios()
        {
            return conexionDB.Conectar().Query<UsuariosModel>("Select * from usuarios where eliminado='no'").ToList();
        }
        public List<UsuariosModel> SelectUsuarioByID(string idUsuario)
        {
            return conexionDB.Conectar().Query<UsuariosModel>("Select * from usuarios where id_usuario=" + idUsuario).ToList();
        }
        public List<UsuariosModel> RetornoMaxID()
        {
            return conexionDB.Conectar().Query<UsuariosModel>("SELECT MAX(id_persona) as id_persona FROM personas").ToList();
        }
        public int InsetarUsuario(UsuariosModel usuariosModel)
        {
            return conexionDB.Conectar().Execute("Insert into usuarios(usuario,contrasena,id_persona)VALUES(@Usuario,@Contrasena,@IdPersona)", usuariosModel);
        }
        public int DeleteUsuario(UsuariosModel usuariosModel)
        {
            return conexionDB.Conectar().Execute("Update usuarios set eliminado='si' where id_usuario=@IdUsuario", usuariosModel);
        }
        public int UpdateUsuario(UsuariosModel usuariosModel)
        {
            return conexionDB.Conectar().Execute("Update usuarios set usuario=@Usuario,contrasena=@Contrasena where id_usuario=@IdUsuario", usuariosModel);
        }

        public bool SelectLogin(string user, string pwd)
        {
            try
            {
                MySqlConnection cn = conexionDB.Conectar();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from usuarios where usuario='" + user + "'and contrasena='" + pwd + "'",cn);
               MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
