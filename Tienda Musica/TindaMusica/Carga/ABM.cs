using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusica.Consulta;

namespace TiendaMusica.Carga
{
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
        }

        private void ABM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABMCliente().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ABMProducto().Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            new ABMProveedor().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ABMEmpleado().Show();
        }

        private void gbApellido_Enter(object sender, EventArgs e)
        {

        }
    }
}
