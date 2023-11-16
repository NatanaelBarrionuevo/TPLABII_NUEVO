namespace TiendaMusica.Carga
{
    partial class ABMCliente
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
            btnCargar = new Button();
            btnAtras = new Button();
            gbTelefono = new GroupBox();
            textBox2 = new TextBox();
            gbNombre = new GroupBox();
            txtNombre = new TextBox();
            gbApellido = new GroupBox();
            txtApellido = new TextBox();
            gbBarrio = new GroupBox();
            cboBarrio = new ComboBox();
            gbMail = new GroupBox();
            txtEmail = new TextBox();
            gbTelefono.SuspendLayout();
            gbNombre.SuspendLayout();
            gbApellido.SuspendLayout();
            gbBarrio.SuspendLayout();
            gbMail.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(418, 324);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(162, 23);
            btnCargar.TabIndex = 25;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(221, 324);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(162, 23);
            btnAtras.TabIndex = 24;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // gbTelefono
            // 
            gbTelefono.Controls.Add(textBox2);
            gbTelefono.Location = new Point(321, 240);
            gbTelefono.Name = "gbTelefono";
            gbTelefono.Size = new Size(162, 51);
            gbTelefono.TabIndex = 22;
            gbTelefono.TabStop = false;
            gbTelefono.Text = "Telefono";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 0;
            // 
            // gbNombre
            // 
            gbNombre.Controls.Add(txtNombre);
            gbNombre.Location = new Point(221, 89);
            gbNombre.Name = "gbNombre";
            gbNombre.Size = new Size(162, 51);
            gbNombre.TabIndex = 21;
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
            // gbApellido
            // 
            gbApellido.Controls.Add(txtApellido);
            gbApellido.Location = new Point(418, 89);
            gbApellido.Name = "gbApellido";
            gbApellido.Size = new Size(162, 51);
            gbApellido.TabIndex = 19;
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
            // gbBarrio
            // 
            gbBarrio.Controls.Add(cboBarrio);
            gbBarrio.Location = new Point(221, 163);
            gbBarrio.Name = "gbBarrio";
            gbBarrio.Size = new Size(162, 51);
            gbBarrio.TabIndex = 18;
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
            // gbMail
            // 
            gbMail.Controls.Add(txtEmail);
            gbMail.Location = new Point(418, 163);
            gbMail.Name = "gbMail";
            gbMail.Size = new Size(162, 51);
            gbMail.TabIndex = 26;
            gbMail.TabStop = false;
            gbMail.Text = "e-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 0;
            // 
            // ABMCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbMail);
            Controls.Add(btnCargar);
            Controls.Add(btnAtras);
            Controls.Add(gbTelefono);
            Controls.Add(gbNombre);
            Controls.Add(gbApellido);
            Controls.Add(gbBarrio);
            Name = "ABMCliente";
            Text = "ABMCliente";
            gbTelefono.ResumeLayout(false);
            gbTelefono.PerformLayout();
            gbNombre.ResumeLayout(false);
            gbNombre.PerformLayout();
            gbApellido.ResumeLayout(false);
            gbApellido.PerformLayout();
            gbBarrio.ResumeLayout(false);
            gbMail.ResumeLayout(false);
            gbMail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private Button btnAtras;
        private GroupBox gbTelefono;
        private TextBox textBox2;
        private GroupBox gbNombre;
        private TextBox txtNombre;
        private GroupBox gbApellido;
        private TextBox txtApellido;
        private GroupBox gbBarrio;
        private ComboBox cboBarrio;
        private GroupBox gbMail;
        private TextBox txtEmail;
    }
}