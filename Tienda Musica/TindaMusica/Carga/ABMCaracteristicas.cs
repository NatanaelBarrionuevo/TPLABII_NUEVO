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

namespace TiendaMusica.Carga
{
    public partial class ABMCaracteristicas : Form
    {
        private ICaracteristicaDAO servicio;
        private Caracteristica caracteristica;
        private IProductoDao productoServicio;
        public ABMCaracteristicas()
        {
            InitializeComponent();
            servicio = new CaracteristicaDao1();
            caracteristica = new Caracteristica();
            productoServicio = new ProductoDao();

            
        }

        private void Habilitar(bool v)
        {
            txtDetalle.Enabled = v;
            cboTipoCaracteristica.Enabled = v;
            btnAgregar.Enabled = v;
            btnSalir.Enabled = v!;
        }

        private void ABMCaracteristicas_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            CargarCombo();
            CargarLista();
        }

        private void CargarLista()
        {
            List<Producto> lista = productoServicio.ConsultarProductos();
            Producto producto;
            //lstProducto.DataSource = lista;
            foreach(Producto p in lista)
            {
                producto = new Producto() { Id = p.Id, Nombre = p.Nombre };   
                lstProducto.Items.Add(producto);
            }
            
        }

        private void CargarCombo()
        {
            cboTipoCaracteristica.Items.Clear();
            List<TipoCaracteristica> tipos = servicio.ConsultarCaracteristicas();
            foreach (TipoCaracteristica tp in tipos)
            {
                cboTipoCaracteristica.Items.Add(tp);
            }
            cboTipoCaracteristica.SelectedIndex = 0;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
