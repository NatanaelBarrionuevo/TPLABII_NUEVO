namespace TiendaMusica.Carga
{
    partial class ABMEmpleado
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
            gbApellido = new GroupBox();
            txtApellido = new TextBox();
            gbPuesto = new GroupBox();
            cboPuesto = new ComboBox();
            gbNombre = new GroupBox();
            txtNombre = new TextBox();
            gbSede = new GroupBox();
            cboSede = new ComboBox();
            gbTelefono = new GroupBox();
            txtTelefono = new TextBox();
            gbIngreso = new GroupBox();
            dtpFechaIngreso = new DateTimePicker();
            btnAtras = new Button();
            btnCargar = new Button();
            gbApellido.SuspendLayout();
            gbPuesto.SuspendLayout();
            gbNombre.SuspendLayout();
            gbSede.SuspendLayout();
            gbTelefono.SuspendLayout();
            gbIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // gbApellido
            // 
            gbApellido.Controls.Add(txtApellido);
            gbApellido.Location = new Point(420, 90);
            gbApellido.Name = "gbApellido";
            gbApellido.Size = new Size(162, 51);
            gbApellido.TabIndex = 11;
            gbApellido.TabStop = false;
            gbApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(6, 22);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 0;
            // 
            // gbPuesto
            // 
            gbPuesto.Controls.Add(cboPuesto);
            gbPuesto.Location = new Point(223, 164);
            gbPuesto.Name = "gbPuesto";
            gbPuesto.Size = new Size(162, 51);
            gbPuesto.TabIndex = 10;
            gbPuesto.TabStop = false;
            gbPuesto.Text = "Puesto";
            // 
            // cboPuesto
            // 
            cboPuesto.FormattingEnabled = true;
            cboPuesto.Location = new Point(6, 22);
            cboPuesto.Name = "cboPuesto";
            cboPuesto.Size = new Size(150, 23);
            cboPuesto.TabIndex = 5;
            // 
            // gbNombre
            // 
            gbNombre.Controls.Add(txtNombre);
            gbNombre.Location = new Point(223, 90);
            gbNombre.Name = "gbNombre";
            gbNombre.Size = new Size(162, 51);
            gbNombre.TabIndex = 13;
            gbNombre.TabStop = false;
            gbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 0;
            // 
            // gbSede
            // 
            gbSede.Controls.Add(cboSede);
            gbSede.Location = new Point(420, 164);
            gbSede.Name = "gbSede";
            gbSede.Size = new Size(162, 51);
            gbSede.TabIndex = 12;
            gbSede.TabStop = false;
            gbSede.Text = "Sede";
            // 
            // cboSede
            // 
            cboSede.FormattingEnabled = true;
            cboSede.Location = new Point(6, 22);
            cboSede.Name = "cboSede";
            cboSede.Size = new Size(150, 23);
            cboSede.TabIndex = 5;
            // 
            // gbTelefono
            // 
            gbTelefono.Controls.Add(txtTelefono);
            gbTelefono.Location = new Point(223, 240);
            gbTelefono.Name = "gbTelefono";
            gbTelefono.Size = new Size(162, 51);
            gbTelefono.TabIndex = 14;
            gbTelefono.TabStop = false;
            gbTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(6, 22);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 0;
            // 
            // gbIngreso
            // 
            gbIngreso.Controls.Add(dtpFechaIngreso);
            gbIngreso.Location = new Point(420, 240);
            gbIngreso.Name = "gbIngreso";
            gbIngreso.Size = new Size(162, 51);
            gbIngreso.TabIndex = 15;
            gbIngreso.TabStop = false;
            gbIngreso.Text = "Ingreso";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(6, 22);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(150, 23);
            dtpFechaIngreso.TabIndex = 16;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(223, 325);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(162, 23);
            btnAtras.TabIndex = 16;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(420, 325);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(162, 23);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // ABMEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(btnAtras);
            Controls.Add(gbIngreso);
            Controls.Add(gbTelefono);
            Controls.Add(gbNombre);
            Controls.Add(gbSede);
            Controls.Add(gbApellido);
            Controls.Add(gbPuesto);
            Name = "ABMEmpleado";
            Text = "ABMEmpleado";
            Load += ABMEmpleado_Load;
            gbApellido.ResumeLayout(false);
            gbApellido.PerformLayout();
            gbPuesto.ResumeLayout(false);
            gbNombre.ResumeLayout(false);
            gbNombre.PerformLayout();
            gbSede.ResumeLayout(false);
            gbTelefono.ResumeLayout(false);
            gbTelefono.PerformLayout();
            gbIngreso.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbApellido;
        private TextBox txtApellido;
        private GroupBox gbPuesto;
        private ComboBox cboPuesto;
        private GroupBox gbNombre;
        private TextBox txtNombre;
        private GroupBox gbSede;
        private ComboBox cboSede;
        private GroupBox gbTelefono;
        private TextBox txtTelefono;
        private GroupBox gbIngreso;
        private DateTimePicker dtpFechaIngreso;
        private Button btnAtras;
        private Button btnCargar;
    }
}