namespace menuslide
{
    partial class informacion
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
            lnk = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lnk
            // 
            lnk.AutoSize = true;
            lnk.Location = new Point(356, 419);
            lnk.Margin = new Padding(4, 0, 4, 0);
            lnk.Name = "lnk";
            lnk.Size = new Size(334, 20);
            lnk.TabIndex = 0;
            lnk.TabStop = true;
            lnk.Text = "https://github.com/NatanaelBarrionuevo/TPLABII";
            lnk.LinkClicked += lnk_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(288, 265);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(519, 60);
            label1.TabIndex = 1;
            label1.Text = "Conozca sobre nosotros";
            label1.Click += label1_Click;
            // 
            // informacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1067, 692);
            Controls.Add(label1);
            Controls.Add(lnk);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "informacion";
            Text = "informacion";
            Load += informacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnk;
        private Label label1;
    }
}