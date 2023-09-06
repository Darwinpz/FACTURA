namespace FACTURA
{
    partial class FORM_PRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_FACTURAS = new System.Windows.Forms.Button();
            this.BTN_PRODUCTOS = new System.Windows.Forms.Button();
            this.BTN_CLIENTES = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_FACTURAS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_PRODUCTOS, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_CLIENTES, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 319);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_FACTURAS
            // 
            this.BTN_FACTURAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_FACTURAS.Location = new System.Drawing.Point(3, 162);
            this.BTN_FACTURAS.Name = "BTN_FACTURAS";
            this.BTN_FACTURAS.Size = new System.Drawing.Size(293, 154);
            this.BTN_FACTURAS.TabIndex = 2;
            this.BTN_FACTURAS.Text = "FACTURAS";
            this.BTN_FACTURAS.UseVisualStyleBackColor = true;
            this.BTN_FACTURAS.Click += new System.EventHandler(this.BTN_FACTURAS_Click);
            // 
            // BTN_PRODUCTOS
            // 
            this.BTN_PRODUCTOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PRODUCTOS.Location = new System.Drawing.Point(302, 3);
            this.BTN_PRODUCTOS.Name = "BTN_PRODUCTOS";
            this.BTN_PRODUCTOS.Size = new System.Drawing.Size(293, 153);
            this.BTN_PRODUCTOS.TabIndex = 1;
            this.BTN_PRODUCTOS.Text = "PRODUCTOS";
            this.BTN_PRODUCTOS.UseVisualStyleBackColor = true;
            this.BTN_PRODUCTOS.Click += new System.EventHandler(this.BTN_PRODUCTOS_Click);
            // 
            // BTN_CLIENTES
            // 
            this.BTN_CLIENTES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_CLIENTES.Location = new System.Drawing.Point(3, 3);
            this.BTN_CLIENTES.Name = "BTN_CLIENTES";
            this.BTN_CLIENTES.Size = new System.Drawing.Size(293, 153);
            this.BTN_CLIENTES.TabIndex = 0;
            this.BTN_CLIENTES.Text = "CLIENTES";
            this.BTN_CLIENTES.UseVisualStyleBackColor = true;
            this.BTN_CLIENTES.Click += new System.EventHandler(this.BTN_CLIENTES_Click);
            // 
            // FORM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FORM_PRINCIPAL";
            this.Text = "PRINCIPAL";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTN_FACTURAS;
        private System.Windows.Forms.Button BTN_PRODUCTOS;
        private System.Windows.Forms.Button BTN_CLIENTES;
    }
}

