using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusica.Carga;
using TiendaMusica.Consulta;
using TindaMusica.Venta;

namespace menuslide
{
    public partial class Form1 : Form
    {
        bool sidebarexp;
        private Form currentChildForm;
        private Consulta consulta;
        private ABM abmMenu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexp)
            {


                //maneja la velocidad de animacion
                sidebar.Width -= 50;


                //si esta expandido, que se minimize 
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexp = false;
                    sidebartimer.Stop();
                }
            }
            else
            {       //maneja la velocidad de animacion
                sidebar.Width += 50;
                //si esta minimizado que se expanda
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexp = true;
                    sidebartimer.Stop();
                }
            }
        }
        #region menubtn


        private void button5_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
            if (pnlayuda.Size == pnlayuda.MaximumSize)
            {
                pnlayuda.Height = pnlayuda.MinimumSize.Height;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region barra min y cerrar


        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlhijos.Controls.Add(childForm);
            pnlhijos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new informacion());
        }

        private void pnlhijos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            IniciarCompra();
        }

        private void IniciarCompra()
        {
            OpenChildForm(new frmVenta());
            //frmVenta form = new frmVenta();
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            //this.Controls.Add(form);
            //form.Show();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            if (sidebarexp)
            {
                submenu(pnlayuda);
            }
            if (sidebarexp == false)
            {
                //maneja la velocidad de animacion
                sidebar.Width += 50;
                //si esta minimizado que se expanda
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexp = true;
                    sidebartimer.Stop();
                }
            }
        }
        private void submenu(Panel panel)
        {
            //si esta max que se min
            if (panel.Size == panel.MaximumSize)
            {
                panel.Height = panel.MinimumSize.Height;
            }
            //si esta max que se min
            else
                panel.Height = panel.MaximumSize.Height;
        }


        int posX;
        int posY;
        private void pnlbar_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Consulta());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ABM());
        }
    }
}
