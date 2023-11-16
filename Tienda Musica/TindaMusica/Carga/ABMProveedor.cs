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
    public partial class ABMProveedor : Form
    {
        private IProveedorDao servicio;
        private Proveedor proveedor;
        public ABMProveedor()
        {
            InitializeComponent();
            servicio = new ProveedorDao();
            proveedor = new Proveedor();
        }

        private void ABMProveedor_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        private void CargarCombos()
        {
            cboBarrio.Items.Clear();
            List<Barrio> barrios = servicio.ConsultarBarrios();
            foreach (Barrio b in barrios)
            {
                cboBarrio.Items.Add(b);
            }
            cboBarrio.SelectedIndex = 0;

            cboRazonSocial.Items.Clear();
            List<RazonSocial> razones = servicio.ConsultarRazones();
            foreach (RazonSocial r in razones)
            {
                cboRazonSocial.Items.Add(r);
            }
            cboRazonSocial.SelectedIndex = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                proveedor.Nombre = txtNombre.Text;
                proveedor.Calle = txtCalle.Text;
                proveedor.Barrio = (Barrio)cboBarrio.SelectedItem;
                proveedor.Razon = (RazonSocial)cboRazonSocial.SelectedItem;

                if (servicio.CargarProveedor(proveedor))
                {
                    MessageBox.Show("El proveedor fue cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El proveedor NO fue cargado exitosamente, intente nuevamente mas tarde o comuniquese con el administrador. Muchas gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Limpiar()
        {
            txtCalle.Clear();
            txtNombre.Clear();
            cboRazonSocial.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
        }

        private bool ValidarDatos()
        {
            int n = 0;
            if (string.IsNullOrEmpty(txtCalle.Text) || string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                n = 1;
            }
            else
            {
                foreach (char c in txtCalle.Text)
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
            if (string.IsNullOrEmpty(cboBarrio.Text))
            {
                n = 3;
            }
            if (string.IsNullOrEmpty(cboRazonSocial.Text))
            {
                n = 4;
            }
            
            switch (n)
            {
                case 1:
                    MessageBox.Show("La Calle del Proveedor es invalida, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtCalle.Focus();
                    return false;
                case 2:
                    MessageBox.Show("El Nombre del Proveedor es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtNombre.Focus();
                    return false;
                case 3:
                    MessageBox.Show("Debe seleccionar un Barrio para el Proveedor.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboBarrio.Focus();
                    return false;
                case 4:
                    MessageBox.Show("Debe seleccionar la Razon Social del Proveedor.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboRazonSocial.Focus();
                    return false;
                default:
                    return true;
            }
        }
    }
}
