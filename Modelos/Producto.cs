using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTURA.Modelos
{
    public class Producto
    {

        private string cod;
        private string nombre;
        private double precio;
        private int stock;

        public Producto() { }

        public string Cod { get => cod; set => cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

    }
}
