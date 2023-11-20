using PresupuestosBack.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_REPORTE_FACTURACION_MENSUAL";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Cliente> lista = new List<Cliente>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {

                    dataGridView1.Rows.Add(new object[]
               {
                    row["AÑO"].ToString(),
                    row["MES"].ToString(),
                    row["TOTAL FACTURADO"].ToString(),
                    row["PROMEDIO FACTURADO"].ToString(),
                    row["PROMEDIO DE PRECIOS"].ToString()

               });

                    
                }

                
            
        }
        }
    }
}
