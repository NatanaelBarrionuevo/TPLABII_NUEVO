namespace TiendaMusica
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, Descripcion, Cantidad });
            dataGridView1.Location = new Point(46, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(690, 319);
            dataGridView1.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 63);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 65);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.Location = new Point(617, 61);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 21);
            label2.Name = "label2";
            label2.Size = new Size(543, 25);
            label2.TabIndex = 5;
            label2.Text = "Veces que un producto se vendio en menor cantida que la indicada";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private Label label2;
    }
}