using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoWOaCargue
{
    internal class Conexionbd
    {
        protected SqlConnection con_db;
        public Conexionbd()
        {
            string amb = @"data source=SERVIDOR\WORLDOFFICE;initial catalog=DISTRIBUIDORA NUEVA ESPERANZA SAS; user id=wo_cliente; password =wo_cliente;Persist Security Info=False;";
            con_db = new SqlConnection(amb);
        }

        public DataTable obtener_datos(string sql, string Tabla)
        {
            SqlCommand command;
            SqlDataReader datareader;
            DataTable data = new DataTable(Tabla);
            try
            {
                con_db.Open();
                command = new SqlCommand(sql, con_db);
                datareader = command.ExecuteReader();
                data.Load(datareader);
                datareader.Close();
                command.Dispose();
                con_db.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion" + ex);
            }
            finally
            {
                con_db.Close();

            }
            return data;
        }
    }
}
