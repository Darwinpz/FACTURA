using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTURA.Modelos
{
    public class Factura
    {

        private int num_factura;
        private string ced_cliente;
        private string fecha;
        private double total;

        public Factura() { }

        public int Num_factura { get => num_factura; set => num_factura = value; }
        public string Ced_cliente { get => ced_cliente; set => ced_cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Total { get => total; set => total = value; }
    }
}
