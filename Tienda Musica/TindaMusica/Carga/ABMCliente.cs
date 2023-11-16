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
    public partial class ABMCliente : Form
    {
        private IClienteDao cliente;
        private Cliente nuevo;
        public ABMCliente()
        {
            InitializeComponent();
            cliente = new ClienteDao();
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboBarrio.Items.Clear();
            List<Barrio> barrios = cliente.ConsultarBarrios();
            foreach (Barrio b in barrios)
            {
                cboBarrio.Items.Add(b);
            }
            cboBarrio.SelectedIndex = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                string email = txtEmail.Text;
                int telefono = Convert.ToInt32(txtTelefono.Text);
                Barrio barrio = (Barrio)cboBarrio.SelectedItem;
                nuevo = new Cliente(apellido, nombre, barrio) { Email = email, Telefono = telefono };
                if (cliente.CargarCliente(nuevo))
                {
                    MessageBox.Show("El cliente fue cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El cliente NO fue cargado exitosamente, intente nuevamente mas tarde o comuniquese con el administrador. Muchas gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            cboBarrio.SelectedIndex = -1;
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
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                n = 3;
            }
            else
            {
                foreach (char c in txtEmail.Text)
                {
                    if (c <= 31 && c >= 33 || c <= 45 && c >= 47 || c < 64 && c > 90 || c < 97 && c > 122)
                    {
                        n = 3;
                    }
                }
            }
            if(string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out _))
            {
                n = 4;
            }
            if (string.IsNullOrEmpty(cboBarrio.Text))
            {
                n = 5;
            }
            switch (n)
            {
                case 1:
                    MessageBox.Show("El Apellido del Cliente es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtApellido.Focus();
                    return false;
                case 2:
                    MessageBox.Show("El Nombre del Cliente es invalido, solo se aceptan letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtNombre.Focus();
                    return false;
                case 3:
                    MessageBox.Show("El Email del Cliente es invalido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtEmail.Focus();
                    return false;
                case 4:
                    MessageBox.Show("El Telefono del Cliente es invalido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtTelefono.Focus();
                    return false;
                case 5:
                    MessageBox.Show("Debe seleccionar el Barrio del Cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboBarrio.Focus();
                    return false;
                default:
                    return true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta segur@ que desea salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }
    }
}
