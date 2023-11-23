namespace TindaMusica.Venta
{
    partial class frmVentaServicios
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
            label2 = new Label();
            dgvDetalleServicio = new DataGridView();
            cboServicios = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cboLuthier = new ComboBox();
            groupBox3 = new GroupBox();
            nmcHoras = new NumericUpDown();
            btnAgregar = new Button();
            groupBox4 = new GroupBox();
            nmcPrecio = new NumericUpDown();
            lblTotal = new Label();
            label4 = new Label();
            label3 = new Label();
            servicio = new DataGridViewTextBoxColumn();
            luthier = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            quitar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcHoras).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcPrecio).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(69, 18);
            label2.TabIndex = 7;
            label2.Text = "Servicios";
            // 
            // dgvDetalleServicio
            // 
            dgvDetalleServicio.AllowUserToAddRows = false;
            dgvDetalleServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleServicio.Columns.AddRange(new DataGridViewColumn[] { servicio, luthier, horas, precio, subtotal, quitar });
            dgvDetalleServicio.Location = new Point(13, 104);
            dgvDetalleServicio.Name = "dgvDetalleServicio";
            dgvDetalleServicio.RowHeadersWidth = 51;
            dgvDetalleServicio.RowTemplate.Height = 24;
            dgvDetalleServicio.Size = new Size(688, 242);
            dgvDetalleServicio.TabIndex = 6;
            dgvDetalleServicio.CellContentClick += dgvDetalleServicio_CellContentClick;
            // 
            // cboServicios
            // 
            cboServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServicios.FormattingEnabled = true;
            cboServicios.Location = new Point(14, 20);
            cboServicios.Margin = new Padding(3, 2, 3, 2);
            cboServicios.Name = "cboServicios";
            cboServicios.Size = new Size(166, 23);
            cboServicios.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboServicios);
            groupBox1.Location = new Point(13, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(192, 53);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servicio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboLuthier);
            groupBox2.Location = new Point(225, 32);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(195, 53);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Luthier";
            // 
            // cboLuthier
            // 
            cboLuthier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLuthier.FormattingEnabled = true;
            cboLuthier.Location = new Point(14, 20);
            cboLuthier.Margin = new Padding(3, 2, 3, 2);
            cboLuthier.Name = "cboLuthier";
            cboLuthier.Size = new Size(176, 23);
            cboLuthier.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nmcHoras);
            groupBox3.Location = new Point(441, 32);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(76, 53);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Horas";
            // 
            // nmcHoras
            // 
            nmcHoras.Location = new Point(13, 20);
            nmcHoras.Margin = new Padding(3, 2, 3, 2);
            nmcHoras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmcHoras.Name = "nmcHoras";
            nmcHoras.Size = new Size(50, 23);
            nmcHoras.TabIndex = 0;
            nmcHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(619, 52);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nmcPrecio);
            groupBox4.Location = new Point(522, 32);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(76, 53);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Precio";
            // 
            // nmcPrecio
            // 
            nmcPrecio.DecimalPlaces = 2;
            nmcPrecio.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nmcPrecio.Location = new Point(13, 20);
            nmcPrecio.Margin = new Padding(3, 2, 3, 2);
            nmcPrecio.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmcPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmcPrecio.Name = "nmcPrecio";
            nmcPrecio.Size = new Size(50, 23);
            nmcPrecio.TabIndex = 0;
            nmcPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(701, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 21);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(701, 356);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(554, 356);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 13;
            label3.Text = "Total Servicios: $";
            // 
            // servicio
            // 
            servicio.HeaderText = "Servicio";
            servicio.MinimumWidth = 6;
            servicio.Name = "servicio";
            servicio.Width = 150;
            // 
            // luthier
            // 
            luthier.HeaderText = "Luthier";
            luthier.MinimumWidth = 6;
            luthier.Name = "luthier";
            luthier.Width = 150;
            // 
            // horas
            // 
            horas.HeaderText = "Horas";
            horas.MinimumWidth = 6;
            horas.Name = "horas";
            horas.Width = 80;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 80;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            // 
            // quitar
            // 
            quitar.HeaderText = "Quitar";
            quitar.MinimumWidth = 6;
            quitar.Name = "quitar";
            quitar.Width = 70;
            // 
            // frmVentaServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 460);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox4);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgvDetalleServicio);
            Name = "frmVentaServicios";
            Text = "Servicios";
            Load += frmVentaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleServicio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmcHoras).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmcPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvDetalleServicio;
        private ComboBox cboServicios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboLuthier;
        private GroupBox groupBox3;
        private Button btnAgregar;
        private NumericUpDown nmcHoras;
        private GroupBox groupBox4;
        private NumericUpDown nmcPrecio;
        private Label lblTotal;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn servicio;
        private DataGridViewTextBoxColumn luthier;
        private DataGridViewTextBoxColumn horas;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn quitar;
    }
}