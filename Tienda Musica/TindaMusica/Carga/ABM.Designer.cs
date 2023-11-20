namespace TiendaMusica.Carga
{
    partial class ABM
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnCargar = new Button();
            gbABM = new GroupBox();
            gbABM.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(411, 175);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(185, 31);
            button3.TabIndex = 34;
            button3.Text = "Empleados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(411, 56);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(185, 31);
            button2.TabIndex = 33;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 56);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(185, 31);
            button1.TabIndex = 32;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(28, 175);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(185, 31);
            btnCargar.TabIndex = 31;
            btnCargar.Text = "Proveedores";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // gbABM
            // 
            gbABM.Controls.Add(button1);
            gbABM.Controls.Add(button3);
            gbABM.Controls.Add(btnCargar);
            gbABM.Controls.Add(button2);
            gbABM.Location = new Point(85, 101);
            gbABM.Margin = new Padding(3, 4, 3, 4);
            gbABM.Name = "gbABM";
            gbABM.Padding = new Padding(3, 4, 3, 4);
            gbABM.Size = new Size(630, 245);
            gbABM.TabIndex = 35;
            gbABM.TabStop = false;
            gbABM.Text = "Carga de Datos";
            gbABM.Enter += gbApellido_Enter;
            // 
            // ABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbABM);
            Name = "ABM";
            Text = "ABM";
            Load += ABM_Load;
            gbABM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnCargar;
        private GroupBox gbABM;
    }
}