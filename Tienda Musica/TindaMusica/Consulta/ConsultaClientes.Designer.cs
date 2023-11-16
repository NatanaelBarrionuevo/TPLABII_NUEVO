namespace TiendaMusica.Consulta
{
    partial class ConsultaClientes
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
            gbClientes = new GroupBox();
            dgvClientes = new DataGridView();
            Colid = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(dgvClientes);
            gbClientes.Location = new Point(12, 37);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(776, 377);
            gbClientes.TabIndex = 2;
            gbClientes.TabStop = false;
            gbClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Colid, ColApellido, ColNombre, ColBarrio, ColTelefono, ColEmail });
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(764, 349);
            dgvClientes.TabIndex = 0;
            // 
            // Colid
            // 
            Colid.HeaderText = "ID";
            Colid.Name = "Colid";
            Colid.Width = 40;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.Width = 130;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 130;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.Width = 140;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.Width = 110;
            // 
            // ColEmail
            // 
            ColEmail.HeaderText = "Email";
            ColEmail.Name = "ColEmail";
            ColEmail.Width = 170;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbClientes);
            Name = "ConsultaClientes";
            Text = "ConsultaClientes";
            gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientes;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Colid;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColEmail;
    }
}