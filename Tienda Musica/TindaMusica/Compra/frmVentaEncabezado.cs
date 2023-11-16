using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusicaBack.Datos.Implementacion;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusica.Compra
{
    public partial class frmVentaEncabezado : Form
    {
        Factura factura;
        IFacturaDao facturaDao;
        IEmpleadoDao empleadoDao;
        IProductoDao productoDao;
        IClienteDao clienteDao;
        public frmVentaEncabezado(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;

            facturaDao = new FacturaDao();
            empleadoDao = new EmpleadoDao();
            productoDao = new ProductoDao();
            clienteDao = new ClienteDao();

        }

        private void frmVentaEncabezado_Load(object sender, EventArgs e)
        {
            ActualizarTotales();
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboEmpleado.Items.Clear();
            cboCliente.Items.Clear();
            cboPago.Items.Clear();
            cboSede.Items.Clear();
            cboEnvio.Items.Clear();



            List<Cliente> clientes = clienteDao.ConsultarCliente();
            List<FormaPago> formaPagos = facturaDao.GetFormaPago();
            List<Sede> sedes = empleadoDao.ConsultarSedes();
            List<MetodoEnvio> metodosEnvios = facturaDao.GetMetodoEnvios();

            foreach (Cliente e in clientes)
            {
                cboCliente.Items.Add(e);
            }
            foreach (FormaPago e in formaPagos)
            {
                cboPago.Items.Add(e);
            }



            foreach (Sede e in sedes)
            {
                cboSede.Items.Add(e);
            }

            foreach (MetodoEnvio e in metodosEnvios)
            {
                cboEnvio.Items.Add(e);
            }



            List<Empleado> empleados = new List<Empleado>();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarTotales()
        {
            lblTotalProductos.Text = factura.TotalProductos().ToString();
            lblTotalServicios.Text = factura.TotalServicios().ToString();
            lblTotal.Text = factura.Total().ToString();
        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEmpleados(((Sede)cboSede.SelectedItem));
        }

        private void cargarEmpleados(Sede sede)
        {
            cboEmpleado.Enabled = true;
            cboEmpleado.Items.Clear();




            List<Empleado> empleados = empleadoDao.GetEmpoleadosPorSede(sede);
            foreach (Empleado e in empleados)
            {
                cboEmpleado.Items.Add(e);
            }
        }

        public void ActualizarFactura()
        {
            factura.Sede = (Sede)cboSede.SelectedItem;
            factura.Emplead = (Empleado)cboEmpleado.SelectedItem;
            factura.Client = (Cliente)cboCliente.SelectedItem;
            factura.Envio = (MetodoEnvio)cboEnvio.SelectedItem;
            factura.Metodo = (FormaPago)cboPago.SelectedItem;

        }
    }
}
