using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources.Extensions;
namespace TiendaMusica.Consulta
{
    public partial class Consulta : Form
    {
        private ConsultaClientes clientes;
        private ConsultaProductos productos;
        private ConsultaProveedores proveedores;
        private ConsultaEmpleados empleados;

        public Consulta()
        {
            InitializeComponent();
            clientes = new ConsultaClientes();
            productos = new ConsultaProductos();
            proveedores = new ConsultaProveedores();
            empleados = new ConsultaEmpleados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConsultaClientes().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ConsultaProductos().Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            new ConsultaProveedores().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ConsultaEmpleados().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
    }
}
