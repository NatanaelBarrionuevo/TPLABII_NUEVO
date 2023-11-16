namespace TiendaMusica.Consulta
{
    partial class ConsultaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbProductos = new GroupBox();
            dgvProductos = new DataGridView();
            Colid = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColMarca = new DataGridViewTextBoxColumn();
            ColProveedor = new DataGridViewTextBoxColumn();
            ColPais = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // gbProductos
            // 
            gbProductos.Controls.Add(dgvProductos);
            gbProductos.Location = new Point(12, 38);
            gbProductos.Name = "gbProductos";
            gbProductos.Size = new Size(776, 377);
            gbProductos.TabIndex = 0;
            gbProductos.TabStop = false;
            gbProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Colid, ColNombre, ColTipo, ColMarca, ColProveedor, ColPais, ColStock, ColPrecio });
            dgvProductos.Location = new Point(6, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(764, 349);
            dgvProductos.TabIndex = 0;
            // 
            // Colid
            // 
            Colid.HeaderText = "ID";
            Colid.Name = "Colid";
            Colid.Width = 30;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 120;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.Width = 110;
            // 
            // ColMarca
            // 
            ColMarca.HeaderText = "Marca";
            ColMarca.Name = "ColMarca";
            // 
            // ColProveedor
            // 
            ColProveedor.HeaderText = "Proveedor";
            ColProveedor.Name = "ColProveedor";
            ColProveedor.Width = 110;
            // 
            // ColPais
            // 
            ColPais.HeaderText = "Pais";
            ColPais.Name = "ColPais";
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.Width = 50;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            // 
            // ConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbProductos);
            Name = "ConsultaProductos";
            Text = "ConsultaProductos";
            Load += ConsultaProductos_Load;
            gbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProductos;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Colid;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColProveedor;
        private DataGridViewTextBoxColumn ColPais;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}