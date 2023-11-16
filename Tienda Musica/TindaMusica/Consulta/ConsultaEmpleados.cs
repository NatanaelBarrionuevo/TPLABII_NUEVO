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
    public partial class ConsultaEmpleados : Form
    {
        private IEmpleadoDao servicio;
        private Empleado empleado;
        public ConsultaEmpleados()
        {
            InitializeComponent();
            servicio = new EmpleadoDao();
        }

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {
            List<Empleado> lista = servicio.ConsultarEmpleados();

            foreach(Empleado emp in lista)
            {
                dgvEmpleados.Rows.Add(new object[] {

                    emp.Legajo,
                    emp.Sede.Nombre,
                    emp.Puesto.Descripcion,
                    emp.Apellido,
                    emp.Nombre,
                    emp.Telefono,
                    emp.Fecha_ingreso.ToShortDateString(),
                    });
            }
        }
    }
}
