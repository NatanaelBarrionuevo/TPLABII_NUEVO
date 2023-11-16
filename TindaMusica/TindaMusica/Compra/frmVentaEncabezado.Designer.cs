namespace TiendaMusica.Compra
{
    partial class frmVentaEncabezado
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
            label4 = new Label();
            groupBox2 = new GroupBox();
            cboCliente = new ComboBox();
            groupBox1 = new GroupBox();
            cboEmpleado = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            cboPago = new ComboBox();
            label3 = new Label();
            lblTotalProductos = new Label();
            groupBox5 = new GroupBox();
            cboEnvio = new ComboBox();
            groupBox6 = new GroupBox();
            cboSede = new ComboBox();
            lblTotalServicios = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(183, 257);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboCliente);
            groupBox2.Location = new Point(503, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 71);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(16, 26);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(201, 28);
            cboCliente.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboEmpleado);
            groupBox1.Location = new Point(261, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 71);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleado";
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.Enabled = false;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(16, 26);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(189, 28);
            cboEmpleado.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 18;
            label2.Text = "Finalizar Compra";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboPago);
            groupBox3.Location = new Point(289, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 71);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pago";
            // 
            // cboPago
            // 
            cboPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPago.FormattingEnabled = true;
            cboPago.Location = new Point(16, 26);
            cboPago.Name = "cboPago";
            cboPago.Size = new Size(201, 28);
            cboPago.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 257);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 23;
            label3.Text = "Total Productos: $";
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProductos.Location = new Point(183, 257);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(36, 28);
            lblTotalProductos.TabIndex = 25;
            lblTotalProductos.Text = "---";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboEnvio);
            groupBox5.Location = new Point(15, 146);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(223, 71);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "Envío";
            // 
            // cboEnvio
            // 
            cboEnvio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvio.FormattingEnabled = true;
            cboEnvio.Location = new Point(16, 26);
            cboEnvio.Name = "cboEnvio";
            cboEnvio.Size = new Size(201, 28);
            cboEnvio.TabIndex = 8;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboSede);
            groupBox6.Location = new Point(15, 42);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(219, 71);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sede";
            // 
            // cboSede
            // 
            cboSede.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSede.FormattingEnabled = true;
            cboSede.Location = new Point(16, 26);
            cboSede.Name = "cboSede";
            cboSede.Size = new Size(189, 28);
            cboSede.TabIndex = 8;
            cboSede.SelectedIndexChanged += cboSede_SelectedIndexChanged;
            // 
            // lblTotalServicios
            // 
            lblTotalServicios.AutoSize = true;
            lblTotalServicios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalServicios.Location = new Point(183, 308);
            lblTotalServicios.Name = "lblTotalServicios";
            lblTotalServicios.Size = new Size(36, 28);
            lblTotalServicios.TabIndex = 32;
            lblTotalServicios.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(183, 308);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 308);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 30;
            label6.Text = "Total Servicios: $";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(130, 386);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 46);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(183, 386);
            label7.Name = "label7";
            label7.Size = new Size(0, 46);
            label7.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 386);
            label8.Name = "label8";
            label8.Size = new Size(126, 46);
            label8.TabIndex = 33;
            label8.Text = "Total: $";
            // 
            // frmVentaEncabezado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 694);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lblTotalServicios);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(lblTotalProductos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "frmVentaEncabezado";
            Text = "frmVentaEncabezado";
            Load += frmVentaEncabezado_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox cboCliente;
        private GroupBox groupBox1;
        private ComboBox cboEmpleado;
        private Label label2;
        private GroupBox groupBox3;
        private ComboBox cboPago;
        private Label label3;
        private Label lblTotalProductos;
        private GroupBox groupBox5;
        private ComboBox cboEnvio;
        private GroupBox groupBox6;
        private ComboBox cboSede;
        private Label lblTotalServicios;
        private Label label5;
        private Label label6;
        private Label lblTotal;
        private Label label7;
        private Label label8;
    }
}