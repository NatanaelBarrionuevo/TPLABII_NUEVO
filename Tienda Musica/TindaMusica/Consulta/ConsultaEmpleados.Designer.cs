namespace TiendaMusica.Consulta
{
    partial class ConsultaEmpleados
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
            gbEmpleados = new GroupBox();
            dgvEmpleados = new DataGridView();
            ColLegajo = new DataGridViewTextBoxColumn();
            ColSede = new DataGridViewTextBoxColumn();
            ColPuesto = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            Colingreso = new DataGridViewTextBoxColumn();
            gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gbEmpleados
            // 
            gbEmpleados.Controls.Add(dgvEmpleados);
            gbEmpleados.Location = new Point(12, 37);
            gbEmpleados.Name = "gbEmpleados";
            gbEmpleados.Size = new Size(776, 377);
            gbEmpleados.TabIndex = 1;
            gbEmpleados.TabStop = false;
            gbEmpleados.Text = "Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { ColLegajo, ColSede, ColPuesto, ColApellido, ColNombre, ColTelefono, Colingreso });
            dgvEmpleados.Location = new Point(6, 22);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(764, 349);
            dgvEmpleados.TabIndex = 0;
            // 
            // ColLegajo
            // 
            ColLegajo.HeaderText = "Legajo";
            ColLegajo.Name = "ColLegajo";
            ColLegajo.Width = 50;
            // 
            // ColSede
            // 
            ColSede.HeaderText = "Sede";
            ColSede.Name = "ColSede";
            ColSede.Width = 130;
            // 
            // ColPuesto
            // 
            ColPuesto.HeaderText = "Puesto";
            ColPuesto.Name = "ColPuesto";
            ColPuesto.Width = 130;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.Width = 110;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 110;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            // 
            // Colingreso
            // 
            Colingreso.HeaderText = "Ingreso";
            Colingreso.Name = "Colingreso";
            Colingreso.Width = 90;
            // 
            // ConsultaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbEmpleados);
            Name = "ConsultaEmpleados";
            Text = "ConsultaEmpleados";
            gbEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEmpleados;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn ColLegajo;
        private DataGridViewTextBoxColumn ColSede;
        private DataGridViewTextBoxColumn ColPuesto;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn Colingreso;
    }
}