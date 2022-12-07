using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoWOaCargue
{
    internal class Facturas
    {
        public bool check { get; set; }
        public string Tipo_Documento { get; set; }
        public string Numero_Documento { get; set; }
        public string Tercero { get; set; }
        public string Forma_De_Pago { get; set; }
        public string CodigoInventario { get; set; }
        public string Descripcion { get; set; }
        public string Cant { get; set; }
        public string Valor_Unitario { get; set; }
        public string Subtotal { get; set; }
        public string Iva { get; set; }
        public string Descuento_Porcentaje { get; set; }
        public string Peso { get; set; }
        public string Unidad_Caja { get; set; }
        public string Identificacion_tercero { get; set; }
        public DateTime Fecha_Fact { get; set; }
        public string Nombre_Ciudad { get; set; }
        public DateTime Fecha_cargue { get; set; }
        public int Anulado { get; set; }
        public string DocEntry { get; set; }
    }
}
