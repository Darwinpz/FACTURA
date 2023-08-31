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
    public partial class FORM_CLIENTES : Form
    {

        Ctl_Cliente ctl_cli = new Ctl_Cliente();

        public FORM_CLIENTES()
        {
            InitializeComponent();
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {

            int pos = ctl_cli.Obtener_pos_cli(TXT_CEDULA.Text.Trim());

            if (pos == -1)
            {

                Cliente cli = new Cliente()
                {
                    Cedula = TXT_CEDULA.Text.Trim(),
                    Nombre = TXT_NOMBRE.Text.Trim().ToUpper(),
                    Apellido = TXT_APELLIDO.Text.Trim().ToUpper()
                };

                ctl_cli.Add_Cliente(cli);

                MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE");

                Limpiar();

                ctl_cli.Ver_Tabla(TABLA);

            }
            else
            {
                MessageBox.Show("CLIENTE YA REGISTRADO");

            }


        }

        private void TABLA_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex!= -1)
            {
                string cedula = TABLA.Rows[e.RowIndex].Cells[0].Value.ToString();
                Cliente cli = ctl_cli.Buscar_cedula(cedula);

                TXT_CEDULA.Text = cli.Cedula;
                TXT_NOMBRE.Text = cli.Nombre;
                TXT_APELLIDO.Text = cli.Apellido;

            }

        }

        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {

            int pos = ctl_cli.Obtener_pos_cli(TXT_CEDULA.Text.Trim());

            if (pos != -1)
            {

                Cliente cli = new Cliente()
                {
                    Cedula = TXT_CEDULA.Text.Trim(),
                    Nombre = TXT_NOMBRE.Text.Trim().ToUpper(),
                    Apellido = TXT_APELLIDO.Text.Trim().ToUpper()
                };

                ctl_cli.Editar_Cliente(pos, cli);

                MessageBox.Show("CLIENTE ACTUALIZADO CORRECTAMENTE");

                Limpiar();

                ctl_cli.Ver_Tabla(TABLA);

            }
            else
            {
                MessageBox.Show("NO EXISTE EL CLIENTE A EDITAR");
            }

        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {

            int pos = ctl_cli.Obtener_pos_cli(TXT_CEDULA.Text.Trim());

            if (pos != -1)
            {

                ctl_cli.Eliminar_Cliente(pos);

                MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE");

                Limpiar();

                ctl_cli.Ver_Tabla(TABLA);

            }
            else
            {
                MessageBox.Show("NO EXISTE EL CLIENTE A ELIMINAR");
            }

        }

        public void Limpiar()
        {
            TXT_CEDULA.Text = "";
            TXT_NOMBRE.Text = "";
            TXT_APELLIDO.Text = "";
        }

        private void TXT_CEDULA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
