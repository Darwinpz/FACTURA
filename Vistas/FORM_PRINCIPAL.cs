using FACTURA.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA
{
    public partial class FORM_PRINCIPAL : Form
    {
        public FORM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void BTN_PRODUCTOS_Click(object sender, EventArgs e)
        {

            FORM_PRODUCTOS frm_prod = new FORM_PRODUCTOS();
            frm_prod.Show();

        }

        private void BTN_CLIENTES_Click(object sender, EventArgs e)
        {

            FORM_CLIENTES form_cli = new FORM_CLIENTES();
            //form_cli.Show();


        }
    }
}
