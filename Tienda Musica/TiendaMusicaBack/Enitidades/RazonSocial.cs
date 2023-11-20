﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
	public class RazonSocial
	{
		private int id;
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public RazonSocial(int id, string nombre)
		{
			Id = id;
			Nombre = nombre;
		}
        public RazonSocial()
        {
            
        }

		public override string ToString()
		{
			return Nombre;
		}

    }
}
