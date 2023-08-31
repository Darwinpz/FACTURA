using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Controladores
{
    public class Ctl_Producto
    {

        List<Producto> lista;

        public Ctl_Producto()
        {
            lista = new List<Producto>();
        }

        public void Add_Producto(Producto prod)
        {
            lista.Add(prod);
        }

        public void Ver_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();

            foreach(Producto prod in lista)
            {

                tabla.Rows.Add(prod.Cod, prod.Nombre, prod.Precio, prod.Stock);
            }

        }

        public int Obtener_pos_prod(string cod)
        {
            return lista.FindIndex(u => u.Cod.Equals(cod));
        }

        public Producto Buscar_codigo(string cod)
        {
            return lista.Find(u => u.Cod.Equals(cod));
        }

        public void Editar_Producto(int pos, Producto prod)
        {
            lista[pos] = prod;
        }


        public void Eliminar_Producto(int pos)
        {
            lista.RemoveAt(pos);
        }

        public int Obtener_cod()
        {

           int id = 0;
            
           if (lista.Count > 0) { 

               id = Convert.ToInt32(lista.Last().Cod);
           }

            return id + 1;
        }


    }
}
