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
    public partial class ABMEmpleado : Form
    {
        private IEmpleadoDao servicio;
        public ABMEmpleado()
        {
            InitializeComponent();
            servicio = new EmpleadoDao();
        }

        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboPuesto.Items.Clear();
            List<Puesto> puestos = servicio.ConsultarPuestos();
            foreach (Puesto b in puestos)
            {
                cboPuesto.Items.Add(puestos);
            }
            cboPuesto.SelectedIndex = 0;

            cboSede.Items.Clear();
            List<Sede> sedes = servicio.ConsultarSedes();
            foreach (Puesto b in puestos)
            {
                cboSede.Items.Add(sedes);
            }
            cboSede.SelectedIndex = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                int telefono = Convert.ToInt32(txtTelefono.Text);
                Sede sede = (Sede)cboSede.SelectedItem;
                Puesto puesto = (Puesto)cboPuesto.SelectedItem;
                DateTime fecha_ingreso = dtpFechaIngreso.Value;

                Empleado empleado = new Empleado(apellido, nombre, fecha_ingreso) { Telefono = telefono, Puesto = puesto, Sede = sede };
                if (servicio.CargarEmpleado(empleado))
                {
                    MessageBox.Show("El empleado fue cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El empleado NO fue cargado exitosamente, intente nuevamente mas tarde o comuniquese con el administrador. Muchas gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            cboPuesto.SelectedIndex = -1;
            cboSede.SelectedIndex = -1;
        }
        private bool ValidarDatos()
        {
            int n = 0;
            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                n = 1;
            }
            else
            {
                foreach (char c in txtApellido.Text)
                {
                    if (c < 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
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
                    if (c < 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
                    {
                        n = 2;
                    }
                }
            }
            if (string.IsNullOrEmpty(cboSede.Text))
            {
                n = 3;
            }

            if (string.IsNullOrEmpty(cboPuesto.Text))
            {
                n = 4;
            }
            if (dtpFechaIngreso.Checked == false)
            {
                n = 5;
            }
            if(string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out _))
            {
                n = 6;
            }
            switch (n)
            {
                case 1:
                    MessageBox.Show("El Apellido del Empledo es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtApellido.Focus();
                    return false;
                case 2:
                    MessageBox.Show("El Nombre del Empleado es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtNombre.Focus();
                    return false;
                case 3:
                    MessageBox.Show("Debe seleccionar una Sede para el Empleado.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboSede.Focus();
                    return false;
                case 4:
                    MessageBox.Show("Debe seleccionar un Puesto para el Empleado.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboPuesto.Focus();
                    return false;
                case 5:
                    MessageBox.Show("Debe seleccionar una Fecha de Ingreso para el Empleado.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dtpFechaIngreso.Focus();
                    return false;
                case 6:
                    MessageBox.Show("El Telefono es invalido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtTelefono.Focus();
                    return false;
                default:
                    return true;
            }
        }
    }
}
