using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPoncheOficial.Controllers
{
    class AccessConnectionController
    {
        public OleDbConnection ConnectToAccess()
        {
           return new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; 
                                        Data source= C:\BioTrack Software\BioAdmin\Data\BDBioAdmin.mdb");
                      
            //try
            //{
            //    conn.Open();


            //    OleDbCommand dataCommand = conn.CreateCommand();
            //    dataCommand.CommandText = "SELECT * FROM RECORD order by RecordTime";
            //    DataTable table = new DataTable();
            //    OleDbDataAdapter adapter = new OleDbDataAdapter();
            //    adapter.SelectCommand = dataCommand;
            //    adapter.Fill(table);

               
            //    return table;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
