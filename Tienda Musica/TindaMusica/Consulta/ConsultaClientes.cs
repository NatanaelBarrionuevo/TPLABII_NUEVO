using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public partial class ConsultaClientes : Form
    {
        private IClienteDao servicio;
        public ConsultaClientes()
        {
            InitializeComponent();
            servicio = new ClienteDao();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = servicio.ConsultarTodosClientes();

            foreach(Cliente cliente in lista)
            {
                dgvClientes.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Apellido,
                    cliente.Nombre,
                    cliente.Barrio.Nombre,
                    cliente.Telefono,
                    cliente.Email
                });
            }
        }
    }
}
