﻿using PresupuestosBack.Datos;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_REPORTE_PRODUCTOS";

            parametros.Add(new Parametro("@cantidad", numericUpDown1.Value.ToString()));



            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);



            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {

                    dataGridView1.Rows.Add(new object[]
               {
                    row["NOMBRE"].ToString(),

                    row["DESCRIPCION"].ToString(),
                    row["NRO"].ToString(),

               });


                }
            }
        }
    }
}

