using FACTURA.Controladores;
using FACTURA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA.Vistas
{
    public partial class FORM_PRODUCTOS : Form
    {
       
        public FORM_PRODUCTOS()
        {
            InitializeComponent();
            update_codigo();

            FORM_PRINCIPAL.ctl_Producto.Ver_Tabla(TABLA);
        }

        public void update_codigo()
        {

            TXT_CODIGO.Text = FORM_PRINCIPAL.ctl_Producto.Obtener_cod().ToString();
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {

            Producto prod = new Producto()
            {
                Cod = TXT_CODIGO.Text,
                Nombre = TXT_NOMBRE.Text,
                Precio = Convert.ToDouble(TXT_PRECIO.Text),
                Stock = Convert.ToInt32(TXT_STOCK.Text)
            };

            FORM_PRINCIPAL.ctl_Producto.Add_Producto(prod);

            MessageBox.Show("PRODUCTO AGREGADO CORRECTAMENTE");

            FORM_PRINCIPAL.ctl_Producto.Ver_Tabla(TABLA);

            Limpiar();
            
        }

        private void TABLA_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string cod = TABLA.Rows[e.RowIndex].Cells[0].Value.ToString();
                Producto prod = FORM_PRINCIPAL.ctl_Producto.Buscar_codigo(cod);

                TXT_CODIGO.Text = prod.Cod;
                TXT_NOMBRE.Text = prod.Nombre;
                TXT_PRECIO.Text = prod.Precio.ToString();
                TXT_STOCK.Text = prod.Stock.ToString();

            }
        }

        public void Limpiar()
        {
            update_codigo();
            TXT_NOMBRE.Text = "";
            TXT_PRECIO.Text = "";
            TXT_STOCK.Text = "";
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            int pos = FORM_PRINCIPAL.ctl_Producto.Obtener_pos_prod(TXT_CODIGO.Text.Trim());

            if (pos != -1)
            {

                FORM_PRINCIPAL.ctl_Producto.Eliminar_Producto(pos);

                MessageBox.Show("PRODUCTO ELIMINADO CORRECTAMENTE");

                Limpiar();

                FORM_PRINCIPAL.ctl_Producto.Ver_Tabla(TABLA);

            }
            else
            {
                MessageBox.Show("NO EXISTE EL PRODUCTO A ELIMINAR");
            }




        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            int pos = FORM_PRINCIPAL.ctl_Producto.Obtener_pos_prod(TXT_CODIGO.Text.Trim());

            if (pos != -1)
            {

                Producto prod = new Producto()
                {
                    Cod = TXT_CODIGO.Text,
                    Nombre = TXT_NOMBRE.Text,
                    Precio = Convert.ToDouble(TXT_PRECIO.Text),
                    Stock = Convert.ToInt32(TXT_STOCK.Text)
                };

                FORM_PRINCIPAL.ctl_Producto.Editar_Producto(pos, prod);

                MessageBox.Show("PRODUCTO ACTUALIZADO CORRECTAMENTE");

                Limpiar();

                FORM_PRINCIPAL.ctl_Producto.Ver_Tabla(TABLA);

            }
            else
            {
                MessageBox.Show("NO EXISTE EL PRODUCTO A EDITAR");
            }
        }
    }
}
