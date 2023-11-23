namespace TiendaMusica
{
    partial class Form2
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
            año = new DataGridViewTextBoxColumn();
            mes = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            promedioPrecios = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { año, mes, total, promedio, promedioPrecios });
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 316);
            dataGridView1.TabIndex = 0;
            // 
            // año
            // 
            año.HeaderText = "Año";
            año.MinimumWidth = 6;
            año.Name = "año";
            año.Width = 50;
            // 
            // mes
            // 
            mes.HeaderText = "Mes";
            mes.MinimumWidth = 6;
            mes.Name = "mes";
            mes.Width = 50;
            // 
            // total
            // 
            total.HeaderText = "Total facturado";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 130;
            // 
            // promedio
            // 
            promedio.HeaderText = "Promedio facturado";
            promedio.MinimumWidth = 6;
            promedio.Name = "promedio";
            promedio.Width = 140;
            // 
            // promedioPrecios
            // 
            promedioPrecios.HeaderText = "Promedio Precios";
            promedioPrecios.MinimumWidth = 6;
            promedioPrecios.Name = "promedioPrecios";
            promedioPrecios.Width = 130;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 338);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn año;
        private DataGridViewTextBoxColumn mes;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn promedio;
        private DataGridViewTextBoxColumn promedioPrecios;
    }
}