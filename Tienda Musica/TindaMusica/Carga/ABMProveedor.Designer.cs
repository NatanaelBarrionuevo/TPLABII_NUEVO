namespace TiendaMusica.Carga
{
    partial class ABMProveedor
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
            gbNombre = new GroupBox();
            txtNombre = new TextBox();
            gbBarrio = new GroupBox();
            cboBarrio = new ComboBox();
            gbCalle = new GroupBox();
            txtCalle = new TextBox();
            gbRazonSocial = new GroupBox();
            cboRazonSocial = new ComboBox();
            btnCargar = new Button();
            btnAtras = new Button();
            gbNombre.SuspendLayout();
            gbBarrio.SuspendLayout();
            gbCalle.SuspendLayout();
            gbRazonSocial.SuspendLayout();
            SuspendLayout();
            // 
            // gbNombre
            // 
            gbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbNombre.Controls.Add(txtNombre);
            gbNombre.Location = new Point(218, 117);
            gbNombre.Name = "gbNombre";
            gbNombre.Size = new Size(162, 51);
            gbNombre.TabIndex = 17;
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
            // gbBarrio
            // 
            gbBarrio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbBarrio.Controls.Add(cboBarrio);
            gbBarrio.Location = new Point(415, 191);
            gbBarrio.Name = "gbBarrio";
            gbBarrio.Size = new Size(162, 51);
            gbBarrio.TabIndex = 16;
            gbBarrio.TabStop = false;
            gbBarrio.Text = "Barrio";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(6, 22);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(150, 23);
            cboBarrio.TabIndex = 5;
            // 
            // gbCalle
            // 
            gbCalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCalle.Controls.Add(txtCalle);
            gbCalle.Location = new Point(415, 117);
            gbCalle.Name = "gbCalle";
            gbCalle.Size = new Size(162, 51);
            gbCalle.TabIndex = 15;
            gbCalle.TabStop = false;
            gbCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(6, 22);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(150, 23);
            txtCalle.TabIndex = 0;
            // 
            // gbRazonSocial
            // 
            gbRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbRazonSocial.Controls.Add(cboRazonSocial);
            gbRazonSocial.Location = new Point(218, 191);
            gbRazonSocial.Name = "gbRazonSocial";
            gbRazonSocial.Size = new Size(162, 51);
            gbRazonSocial.TabIndex = 14;
            gbRazonSocial.TabStop = false;
            gbRazonSocial.Text = "Razon Social";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.FormattingEnabled = true;
            cboRazonSocial.Location = new Point(6, 22);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(150, 23);
            cboRazonSocial.TabIndex = 5;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCargar.Location = new Point(415, 282);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(162, 23);
            btnCargar.TabIndex = 27;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtras.Location = new Point(218, 282);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(162, 23);
            btnAtras.TabIndex = 26;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // ABMProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(btnAtras);
            Controls.Add(gbNombre);
            Controls.Add(gbBarrio);
            Controls.Add(gbCalle);
            Controls.Add(gbRazonSocial);
            Name = "ABMProveedor";
            Text = "ABMProveedor";
            Load += ABMProveedor_Load;
            gbNombre.ResumeLayout(false);
            gbNombre.PerformLayout();
            gbBarrio.ResumeLayout(false);
            gbCalle.ResumeLayout(false);
            gbCalle.PerformLayout();
            gbRazonSocial.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbNombre;
        private TextBox txtNombre;
        private GroupBox gbBarrio;
        private ComboBox cboBarrio;
        private GroupBox gbCalle;
        private TextBox txtCalle;
        private GroupBox gbRazonSocial;
        private ComboBox cboRazonSocial;
        private Button btnCargar;
        private Button btnAtras;
    }
}