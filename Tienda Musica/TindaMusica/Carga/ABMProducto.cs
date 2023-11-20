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
    public partial class ABMProducto : Form
    {
        private ABMCaracteristicas ventanaCaracteristicas;
        private IProductoDao servicio;
        private Producto producto;
        public ABMProducto()
        {
            InitializeComponent();
            servicio = new ProductoDao();
            producto = new Producto();
            ventanaCaracteristicas = new ABMCaracteristicas();
        }

        private void ABMProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboMarca.Items.Clear();
            List<Marca> marcas = servicio.ConsultarMarcas();
            foreach (Marca marca in marcas)
            {
                cboMarca.Items.Add(marca);
            }
            cboMarca.SelectedIndex = 0;

            cboPais.Items.Clear();
            List<Pais> paises = servicio.ConsultarPaises();
            foreach (Pais pais in paises)
            {
                cboPais.Items.Add(pais);
            }
            cboPais.SelectedIndex = 0;

            cboProveedor.Items.Clear();
            List<Proveedor> proveedores = servicio.ConsultarProveedores();
            foreach (Proveedor prov in proveedores)
            {
                cboProveedor.Items.Add(prov);
            }
            cboProveedor.SelectedIndex = 0;

            cboTipoProducto.Items.Clear();
            List<TipoProducto> tipos = servicio.ConsultarTipoProducto();
            foreach (TipoProducto tipo in tipos)
            {
                cboTipoProducto.Items.Add(tipo);
            }
            cboTipoProducto.SelectedIndex = 0;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                producto.Descripcion = txtDescripcion.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.Marca = (Marca)cboMarca.SelectedItem;
                producto.Pais = (Pais)cboPais.SelectedItem;
                producto.Proveedor = (Proveedor)cboProveedor.SelectedItem;
                producto.TipoProducto = (TipoProducto)cboTipoProducto.SelectedItem;


                if (servicio.CargarProducto(producto))
                {
                    MessageBox.Show("El producto fue cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El producto NO fue cargado exitosamente, intente nuevamente mas tarde o comuniquese con el administrador. Muchas gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboMarca.SelectedIndex = -1;
            cboPais.SelectedIndex = -1;
            cboProveedor.SelectedIndex = -1;
            cboTipoProducto.SelectedIndex = -1;
        }

        private bool ValidarDatos()
        {
            int n = 0;
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                n = 1;
            }
            else
            {
                foreach (char c in txtDescripcion.Text)
                {
                    if (c <= 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
                    {
                        n = 1;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                n = 2;
            }
            else
            {
                foreach (char c in txtNombre.Text)
                {
                    if (c <= 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
                    {
                        n = 2;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtPrecio.Text) || !double.TryParse(txtPrecio.Text, out _))
            {
                n = 3;
            }
            if (string.IsNullOrEmpty(txtStock.Text) || !int.TryParse(txtStock.Text, out _))
            {
                n = 4;
            }
            if (string.IsNullOrEmpty(cboMarca.Text))
            {
                n = 5;
            }
            if (string.IsNullOrEmpty(cboPais.Text))
            {
                n = 6;
            }
            if (string.IsNullOrEmpty(cboProveedor.Text))
            {
                n = 7;
            }
            if (string.IsNullOrEmpty(cboTipoProducto.Text))
            {
                n = 8;
            }
            switch (n)
            {
                case 1:
                    MessageBox.Show("La Descricion del Detalle del Producto e sinvalida, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtDescripcion.Focus();
                    return false;
                case 2:
                    MessageBox.Show("El Nombre del Producto es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtNombre.Focus();
                    return false;
                case 3:
                    MessageBox.Show("El Precio del Producto es invalido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtPrecio.Focus();
                    return false;
                case 4:
                    MessageBox.Show("El Stock del Producto es invalido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtStock.Focus();
                    return false;
                case 5:
                    MessageBox.Show("Debe seleccionar la Marca del Producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboMarca.Focus();
                    return false;
                case 6:
                    MessageBox.Show("Debe seleccionar el Pais del Producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboPais.Focus();
                    return false;
                case 7:
                    MessageBox.Show("Debe seleccionar el Proveedor del Producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboProveedor.Focus();
                    return false;
                case 8:
                    MessageBox.Show("Debe seleccionar el Tipo de Producto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboTipoProducto.Focus();
                    return false;
                default:
                    return true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            ventanaCaracteristicas.ShowDialog();
        }
    }
}
