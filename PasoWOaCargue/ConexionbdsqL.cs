using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace PasoWOaCargue
{
    internal class ConexionbdsqL
    {
        private static Conexion_Instancia instancia = null;
        //private object tabla;

        public static SQLiteConnection InstanciaDB()
        {
            if (instancia == null)
            {
                instancia = new Conexion_Instancia();
            }
            return instancia.con;
        }


        public static DataTable HacerConsulta(string sql)
        {

            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, InstanciaDB());
                da.Fill(dt);

            }
            catch (Exception e)
            {
                string res = e.Message;
            }
            return dt;
        }

        public class Conexion_Instancia
        {

            public SQLiteConnection con = null;
            public Conexion_Instancia()
            {
                con = new SQLiteConnection("data source=D:\\Cargue NE App\\Cargue.db;Version=3"); //"data source=C:\\Users\\projcargue\\Desktop\\Cargue.s3db;Version=3"; cadena;
                con.Open();
            }
        
            
            ~Conexion_Instancia()
            {
                    //con.Close();
            }
            
        }


        public static string obtener_datos(string sql, string documento)
        {

            //SQLiteConnection conexion = new SQLiteConnection("data source=C:\\DBSQLite\\Cargue.db;Version=3");
            //conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, InstanciaDB());
            SQLiteDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    documento = result[0].ToString();
                }
            }
            //conexion.Close();

            return documento;
        }
    }
}
