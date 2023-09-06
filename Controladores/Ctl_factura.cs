using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Controladores
{
    public class Ctl_factura
    {

        List<Factura> lista;

        public Ctl_factura() 
        {
        
            lista = new List<Factura>();
        }

        public void Add_Factura(Factura fact)
        {
            lista.Add(fact);
        }

        public void Ver_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();

            foreach (Factura fact in lista)
            {

                tabla.Rows.Add(fact.Num_factura, fact.Ced_cliente, fact.Fecha, fact.Total);
            }

        }



    }
}
