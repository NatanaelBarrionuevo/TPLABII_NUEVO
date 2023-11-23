namespace TindaMusica.Venta
{
    partial class frmVentaProductos
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
            label1 = new Label();
            txtCodigo = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            prodId = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            Quitar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo: ";
            label1.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(78, 62);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prodId, tipo, nombre, precio, cantidad, subtotal, Quitar });
            dataGridView1.Location = new Point(13, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(794, 242);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 3;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(592, 363);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 4;
            label3.Text = "Total Productos: $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(738, 363);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(738, 363);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "---";
            // 
            // prodId
            // 
            prodId.HeaderText = "Prod Nro";
            prodId.MinimumWidth = 6;
            prodId.Name = "prodId";
            prodId.Width = 80;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 155;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            // 
            // Quitar
            // 
            Quitar.HeaderText = "Quitar";
            Quitar.MinimumWidth = 6;
            Quitar.Name = "Quitar";
            Quitar.Resizable = DataGridViewTriState.True;
            Quitar.SortMode = DataGridViewColumnSortMode.Automatic;
            Quitar.Width = 80;
            // 
            // frmVentaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 428);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "frmVentaProductos";
            Text = "Form1";
            Load += frmVentaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotal;
        private DataGridViewTextBoxColumn prodId;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn Quitar;
    }
}

