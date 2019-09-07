using MySql.Data.MySqlClient;

namespace SistemaPoncheOficial.Controllers
{
    class ConexionDB
    {
        public MySqlConnection Conectar()
        {
            return new MySqlConnection("Server=127.0.0.1;" +
                                        "Database=sistema_ponche_db;" +
                                        "Uid= root;" +
                                        "Pwd=;Allow Zero Datetime=True"
                                      );
        }
    }
}
