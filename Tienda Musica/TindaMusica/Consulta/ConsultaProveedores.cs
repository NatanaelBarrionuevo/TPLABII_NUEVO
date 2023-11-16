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
    public partial class ConsultaProveedores : Form
    {
        private IProveedorDao servicio;
        public ConsultaProveedores()
        {
            InitializeComponent();
            servicio = new ProveedorDao();
        }

        private void ConsultaProveedores_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = servicio.ConsultarProveedores();

            foreach (Proveedor proveedor in lista)
            {
                dgvProveedores.Rows.Add(new object[]
                {
                    proveedor.Id,
                    proveedor.Nombre,
                    proveedor.Razon.Nombre,
                    proveedor.Calle,
                    proveedor.Barrio.Nombre
                }) ;
            }
        }
    }
}
