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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_REPORTE_FIDELIDAD";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Cliente> lista = new List<Cliente>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {

                    dataGridView1.Rows.Add(new object[]
               {
                    row["ID_CLIENTE"].ToString(),
                    row["CLIENTE"].ToString(),
                    row["EMAIL"].ToString(),
                    row["TELEFONO"].ToString(),
                    row["OBSERVACION"].ToString()

               });


                }



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
