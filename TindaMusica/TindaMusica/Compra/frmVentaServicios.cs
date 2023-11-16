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

namespace TindaMusica.Venta
{
    public partial class frmVentaServicios : Form
    {
        IServicioDao servicioDao;
        ILuthierDao luthierDao;
        List<DetalleServicio> detalleServicios;
        Factura factura = new Factura();
        public frmVentaServicios(Factura factura)
        {
            InitializeComponent();
            servicioDao = new ServicioDao();
            luthierDao = new LuthierDao();
            this.factura = factura;
            this.detalleServicios = factura.DetalleServicio;
        }

        private void frmVentaServicios_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboServicios.Items.Clear();
            List<TipoServicio> tipoServicios = servicioDao.ObtenerTiposServicios();
            foreach (TipoServicio servicio in tipoServicios)
            {
                cboServicios.Items.Add(servicio);
            }
            cboServicios.SelectedIndex = 0;


            cboLuthier.Items.Clear();
            List<Luthier> luthiers = luthierDao.ObtenerLuthiers();
            foreach (Luthier luthier in luthiers)
            {
                cboLuthier.Items.Add(luthier);
            }
            cboLuthier.SelectedIndex = 0;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarServicio((TipoServicio)cboServicios.SelectedItem, (Luthier)cboLuthier.SelectedItem, Convert.ToInt32(nmcHoras.Value), (double)nmcPrecio.Value);
            ActualizarDgv();
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            

            lblTotal.Text = factura.TotalServicios().ToString();
        }



        private void ActualizarDgv()
        {
            dgvDetalleServicio.Rows.Clear();
            foreach (DetalleServicio det in detalleServicios)
            {
                dgvDetalleServicio.Rows.Add(new object[] {

                    det.Servicio.ToString(),
                    det.Luthier.ToString(),
                    det.CantHoras.ToString(),
                    det.PrecioPorHora,
                    det.CantHoras * det.PrecioPorHora
                    });

            }
        }

        private void AgregarServicio(TipoServicio tipoServicio, Luthier luthier, int horas, double precio)
        {
            if (luthierServicioDuplicado(tipoServicio, luthier))
            {
                MessageBox.Show("Servicio y Luthier ya ingresado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                detalleServicios.Add(new DetalleServicio()
                {
                    Luthier = luthier,
                    Servicio = tipoServicio,
                    PrecioPorHora = precio,
                    CantHoras = horas,
                });
            }
        }

        private bool luthierServicioDuplicado(TipoServicio servicio, Luthier luthier)
        {
            bool ok = false;

            foreach (DetalleServicio det in detalleServicios)
            {
                if (det.Servicio.Id == servicio.Id && det.Luthier.Id == luthier.Id)
                {
                    ok = true;
                }

            }

            return ok;

        }
    }
}
