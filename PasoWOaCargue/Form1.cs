using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasoWOaCargue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string query = Properties.Resources.ConsultaFactWO;
            
            string Num_Doc;

            ConexionbdsqL conn = new ConexionbdsqL();
            var ax = ConexionbdsqL.obtener_datos(Properties.Resources.UltimaFactsqlite, "");
            Num_Doc = ax.Substring(0);

            query = query.Replace("%1",Num_Doc);
            ConsultaFacturas(query);
            this.Close();
        }



        private List<Facturas> ConsultaFacturas(string query)
        {
            string res = "";
            Conexionbd conn = new Conexionbd();
            List<Facturas> ds = new List<Facturas>();

            try
            {
                var ax = conn.obtener_datos(query, "ejm");
                foreach (DataRow rws in ax.Rows)
                {
                    ds.Add(new Facturas
                    {
                        Tipo_Documento = rws[0].ToString(),
                        Numero_Documento = rws[1].ToString(),
                        Tercero = rws[2].ToString(),
                        Forma_De_Pago = rws[3].ToString(),
                        CodigoInventario = rws[4].ToString(),
                        Descripcion = rws[5].ToString(),
                        Cant = rws[6].ToString().Replace(',','.'),
                        Valor_Unitario = rws[7].ToString().Replace(',', '.'),
                        Subtotal = rws[8].ToString().Replace(',', '.'),
                        Iva = rws[9].ToString().Replace(',','.'),
                        Descuento_Porcentaje = rws[10].ToString(),
                        Peso = rws[11].ToString().Replace(',', '.'),
                        Unidad_Caja = rws[12].ToString(),
                        Identificacion_tercero = rws[13].ToString(),
                        Nombre_Ciudad = rws[14].ToString(),
                        Fecha_Fact = Convert.ToDateTime(rws[15]),
                        DocEntry = rws[1].ToString()+ rws[4].ToString()+rws[6].ToString().Replace(',', '.')
                    });
                }
                InsertaFacturasCargue(ds);
            }
            catch (Exception e)
            {
                res = e.Message;

            }

            return ds;
        }

        private void InsertaFacturasCargue(List<Facturas> ds)
        {
            string res = "";
            //ConexionbdsqL conn = new ConexionbdsqL();

            try
            {
                foreach (Facturas numero in ds)
                {
                    Console.WriteLine(numero);
                    ConexionbdsqL.HacerConsulta("insert into Cargue (Tipo_Documento, Numero_Documento, Tercero," +
                    " Forma_de_Pago, CodigoInventario, Descripcion, Cant, Valor_Unitario, Subtotal, Iva, Descuento_Porcentaje, " +
                    " Inventarios_Personalizado_1, Inventarios_Personalizado_2, Identificacion_Tercero, Nombre_Ciudad, Fecha_Cargue, Anulado, DocEntry)" +
                    " values('" + numero.Tipo_Documento + "'," + numero.Numero_Documento + ",'" + numero.Tercero + "','" +
                    numero.Forma_De_Pago + "'," + numero.CodigoInventario + ",'" + numero.Descripcion + "', " +
                    numero.Cant + "," + numero.Valor_Unitario + "," + numero.Subtotal + "," +
                    numero.Iva + "," + numero.Descuento_Porcentaje + "," + numero.Unidad_Caja + "," +
                    numero.Peso + "," + numero.Identificacion_tercero + ",'" + numero.Nombre_Ciudad + "','" +
                    DateTime.Now.Date + "',0," +numero.DocEntry+" )");

                }
            }
            catch (Exception e)
            {
                res = e.Message;

            }


        }

        string ConsultaFacturaLite()
        {
            string Num_Doc;
            ConexionbdsqL conn = new ConexionbdsqL();
            var ax = ConexionbdsqL.obtener_datos(Properties.Resources.UltimaFactsqlite,"");
            Num_Doc = ax.Substring(0);




            return Num_Doc;
        }

    }


}
