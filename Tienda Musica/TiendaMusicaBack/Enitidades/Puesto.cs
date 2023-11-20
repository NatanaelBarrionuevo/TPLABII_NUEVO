﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Puesto
    {
		private int id;
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
