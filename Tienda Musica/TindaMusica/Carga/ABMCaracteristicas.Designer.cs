namespace TiendaMusica.Carga
{
    partial class ABMCaracteristicas
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
            txtDetalle = new TextBox();
            gbDetalle = new GroupBox();
            gbTipoCaracteristica = new GroupBox();
            cboTipoCaracteristica = new ComboBox();
            lstProducto = new ListBox();
            gbProducto = new GroupBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            gbDetalle.SuspendLayout();
            gbTipoCaracteristica.SuspendLayout();
            gbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(6, 22);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(150, 23);
            txtDetalle.TabIndex = 0;
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(txtDetalle);
            gbDetalle.Location = new Point(363, 31);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(162, 51);
            gbDetalle.TabIndex = 1;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // gbTipoCaracteristica
            // 
            gbTipoCaracteristica.Controls.Add(cboTipoCaracteristica);
            gbTipoCaracteristica.Location = new Point(195, 31);
            gbTipoCaracteristica.Name = "gbTipoCaracteristica";
            gbTipoCaracteristica.Size = new Size(162, 51);
            gbTipoCaracteristica.TabIndex = 6;
            gbTipoCaracteristica.TabStop = false;
            gbTipoCaracteristica.Text = "Tipo de Caracteristica";
            // 
            // cboTipoCaracteristica
            // 
            cboTipoCaracteristica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoCaracteristica.FormattingEnabled = true;
            cboTipoCaracteristica.Location = new Point(6, 22);
            cboTipoCaracteristica.Name = "cboTipoCaracteristica";
            cboTipoCaracteristica.Size = new Size(150, 23);
            cboTipoCaracteristica.TabIndex = 5;
            // 
            // lstProducto
            // 
            lstProducto.FormattingEnabled = true;
            lstProducto.ItemHeight = 15;
            lstProducto.Location = new Point(6, 22);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(318, 289);
            lstProducto.TabIndex = 7;
            // 
            // gbProducto
            // 
            gbProducto.Controls.Add(lstProducto);
            gbProducto.Location = new Point(195, 88);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(330, 319);
            gbProducto.TabIndex = 8;
            gbProducto.TabStop = false;
            gbProducto.Text = "Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(565, 164);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(565, 287);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // ABMCaracteristicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(gbProducto);
            Controls.Add(gbTipoCaracteristica);
            Controls.Add(gbDetalle);
            Name = "ABMCaracteristicas";
            Text = "ABMCaracteristicas";
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            gbTipoCaracteristica.ResumeLayout(false);
            gbProducto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDetalle;
        private GroupBox gbDetalle;
        private GroupBox gbTipoCaracteristica;
        private ComboBox cboTipoCaracteristica;
        private ListBox lstProducto;
        private GroupBox gbProducto;
        private Button btnAgregar;
        private Button btnSalir;
    }
}