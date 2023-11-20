namespace TiendaMusica
{
    partial class Form4
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
            Column1 = new DataGridViewTextBoxColumn();
            C = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Tele = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, C, Column2, Tele, Column3 });
            dataGridView1.Location = new Point(32, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(690, 319);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cod Cliente";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // C
            // 
            C.HeaderText = "Cliente";
            C.MinimumWidth = 6;
            C.Name = "C";
            C.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Tele
            // 
            Tele.HeaderText = "Telefono";
            Tele.MinimumWidth = 6;
            Tele.Name = "Tele";
            Tele.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Observacion";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 2;
            label1.Text = "Clientes regulares ";
            label1.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn C;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Tele;
        private DataGridViewTextBoxColumn Column3;
    }
}