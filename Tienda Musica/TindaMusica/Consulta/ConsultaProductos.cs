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

namespace TiendaMusica.Consulta
{
    public partial class ConsultaProductos : Form
    {
        private IProductoDao servicio;
        public ConsultaProductos()
        {
            InitializeComponent();
            servicio = new ProductoDao();
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            List<Producto> lista = servicio.ConsultarProductos();

            foreach (Producto item in lista)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    item.Id,
                    item.Nombre,
                    item.TipoProducto.Tipo,
                    item.Marca.Nombre,
                    item.Proveedor.Nombre,
                    item.Pais.Nombre,
                    item.Stock,
                    item.Precio

                });
            }
        }
    }
}
