namespace TiendaMusica.Consulta
{
    partial class ConsultaProveedores
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
            gbProveedores = new GroupBox();
            dgvProveedores = new DataGridView();
            Colid = new DataGridViewTextBoxColumn();
            ColProveedor = new DataGridViewTextBoxColumn();
            ColRazon = new DataGridViewTextBoxColumn();
            ColCalle = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            gbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // gbProveedores
            // 
            gbProveedores.Controls.Add(dgvProveedores);
            gbProveedores.Location = new Point(12, 37);
            gbProveedores.Name = "gbProveedores";
            gbProveedores.Size = new Size(776, 377);
            gbProveedores.TabIndex = 2;
            gbProveedores.TabStop = false;
            gbProveedores.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { Colid, ColProveedor, ColRazon, ColCalle, ColBarrio });
            dgvProveedores.Location = new Point(6, 22);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.Size = new Size(764, 349);
            dgvProveedores.TabIndex = 0;
            // 
            // Colid
            // 
            Colid.HeaderText = "ID";
            Colid.Name = "Colid";
            Colid.Width = 60;
            // 
            // ColProveedor
            // 
            ColProveedor.HeaderText = "Proveedor";
            ColProveedor.Name = "ColProveedor";
            ColProveedor.Width = 160;
            // 
            // ColRazon
            // 
            ColRazon.HeaderText = "Razon";
            ColRazon.Name = "ColRazon";
            ColRazon.Width = 150;
            // 
            // ColCalle
            // 
            ColCalle.HeaderText = "Calle";
            ColCalle.Name = "ColCalle";
            ColCalle.Width = 200;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.Width = 150;
            // 
            // ConsultaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbProveedores);
            Name = "ConsultaProveedores";
            Text = "ConsultaProveedores";
            Load += ConsultaProveedores_Load;
            gbProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProveedores;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn Colid;
        private DataGridViewTextBoxColumn ColProveedor;
        private DataGridViewTextBoxColumn ColRazon;
        private DataGridViewTextBoxColumn ColCalle;
        private DataGridViewTextBoxColumn ColBarrio;
    }
}