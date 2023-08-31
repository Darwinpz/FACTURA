using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Controladores
{
    public class Ctl_Cliente
    {

        List<Cliente> lista;

        public Ctl_Cliente()
        {
            lista = new List<Cliente>();
        }

        public void Add_Cliente(Cliente cli)
        {
            lista.Add(cli);
        }

        public void Ver_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();

            foreach(Cliente cli in lista)
            {

                tabla.Rows.Add(cli.Cedula, cli.Nombre, cli.Apellido);
            }

        }

        public int Obtener_pos_cli(string cedula)
        {
            return lista.FindIndex(u => u.Cedula.Equals(cedula));
        }

        public Cliente Buscar_cedula(string cedula)
        {
            return lista.Find(u => u.Cedula.Equals(cedula));
        }

        public void Editar_Cliente(int pos, Cliente cli)
        {
            lista[pos] = cli;
        }


        public void Eliminar_Cliente(int pos)
        {
            lista.RemoveAt(pos);
        }



    }
}
