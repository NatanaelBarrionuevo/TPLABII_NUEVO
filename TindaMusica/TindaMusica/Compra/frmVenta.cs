using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusica.Compra;
using TiendaMusicaBack.Datos.Implementacion;
using TiendaMusicaBack.Enitidades;
using TindaMusica;

namespace TindaMusica.Venta
{
    public partial class frmVenta : Form
    {
        int stepActual = 0;
        List<Form> steps;
        frmVentaProductos formProd;
        frmVentaServicios formServ;
        frmVentaEncabezado formEncabezado;

        List<DetalleServicio> detalleServicio;
        List<DetaleFactura> detalleFactura;

        Factura factura;

        FacturaDao facturaDao;
        public frmVenta()
        {
            facturaDao = new FacturaDao();

            detalleServicio = new List<DetalleServicio>();
            detalleFactura = new List<DetaleFactura>();
            this.factura = new Factura();
            factura.DetaleFactura = detalleFactura;
            factura.DetalleServicio = detalleServicio;


            InitializeComponent();

            formProd = new frmVentaProductos(factura);
            formProd.TopLevel = false;
            formProd.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formProd);
            formProd.Location = new Point(40, 80);



            formServ = new frmVentaServicios(factura);
            formServ.TopLevel = false;
            formServ.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formServ);
            formServ.Location = new Point(40, 80);


            formEncabezado = new frmVentaEncabezado(factura);
            formEncabezado.TopLevel = false;
            formEncabezado.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(formEncabezado);
            formEncabezado.Location = new Point(40, 80);

            steps = new List<Form>();
            steps.Add(formProd);
            steps.Add(formServ);
            steps.Add(formEncabezado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                btnCancelar.Enabled = true;
            

            if (stepActual == 2)
            {
                FinalizarCompra();
            }
            else
            {
                steps[stepActual].Hide();
                stepActual++;
                steps[stepActual].Show();

                formEncabezado.ActualizarTotales();

                if (stepActual == 2) { btnSiguiente.Text = "Finalizar"; };
            }
            

            

        }

        private void FinalizarCompra()
        {
            formEncabezado.ActualizarFactura();
            int nroFactura = facturaDao.CrearFactura(factura);
            if(nroFactura == -1 ) {
                MessageBox.Show("Ha ocurrido un error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Factura {nroFactura} creada con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

            steps[stepActual].Show();
            btnCancelar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (stepActual == 2) { btnSiguiente.Text = "Siguiente"; }

            //    formServ.Hide();
            //    //this.Controls.Remove(formServ);

            //    //this.Controls.Add(formProd);
            //    formProd.Show();

            steps[stepActual].Hide();
            stepActual--;
            steps[stepActual].Show();
            if(stepActual == 0) { btnCancelar.Enabled=false; }
            if (stepActual == 0) { btnCancelar.Enabled = false; }


        }
    }

}
