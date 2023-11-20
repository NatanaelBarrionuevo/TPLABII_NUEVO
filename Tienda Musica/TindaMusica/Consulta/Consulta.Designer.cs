namespace TiendaMusica.Consulta
{
    partial class Consulta
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gbConsulta = new GroupBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            gbConsulta.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(35, 175);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(185, 31);
            btnCargar.TabIndex = 27;
            btnCargar.Text = "Proveedores";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 56);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(185, 31);
            button1.TabIndex = 28;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 56);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(185, 31);
            button2.TabIndex = 29;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(418, 175);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(185, 31);
            button3.TabIndex = 30;
            button3.Text = "Empleados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gbConsulta
            // 
            gbConsulta.Controls.Add(button1);
            gbConsulta.Controls.Add(button3);
            gbConsulta.Controls.Add(btnCargar);
            gbConsulta.Controls.Add(button2);
            gbConsulta.Location = new Point(83, 60);
            gbConsulta.Margin = new Padding(3, 4, 3, 4);
            gbConsulta.Name = "gbConsulta";
            gbConsulta.Padding = new Padding(3, 4, 3, 4);
            gbConsulta.Size = new Size(637, 244);
            gbConsulta.TabIndex = 36;
            gbConsulta.TabStop = false;
            gbConsulta.Text = "Consulta de Datos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Location = new Point(97, 331);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(637, 244);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reportes";
            // 
            // button4
            // 
            button4.Location = new Point(35, 56);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(185, 31);
            button4.TabIndex = 28;
            button4.Text = "Facturación Mensual";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(418, 175);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(185, 31);
            button5.TabIndex = 30;
            button5.Text = "Mejores meses";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(35, 175);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(185, 31);
            button6.TabIndex = 27;
            button6.Text = "Clientes regulares";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(404, 56);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(199, 31);
            button7.TabIndex = 29;
            button7.Text = "Productos menos vendidos";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 660);
            Controls.Add(groupBox1);
            Controls.Add(gbConsulta);
            Name = "Consulta";
            Text = "Consulta";
            gbConsulta.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox gbConsulta;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}