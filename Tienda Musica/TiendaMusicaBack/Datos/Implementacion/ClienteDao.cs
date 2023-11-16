﻿using PresupuestosBack.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public bool CargarCliente(Cliente oCliente)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_CLIENTE", oCliente.Id),
                new Parametro("@NOMBRE", oCliente.Nombre),
                new Parametro("@APELLIDO", oCliente.Apellido),
                new Parametro("@ID_BARRIO", oCliente.Barrio.Id),
                new Parametro("@TELEFONO", oCliente.Telefono),
                new Parametro("@EMAIL", oCliente.Email)
            };
            string sp = "SP_INSERT_CLIENTE";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;
        }

        public List<Barrio> ConsultarBarrios()
        {
            Barrio barrio;
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_BARRIOS";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Barrio> lista = new List<Barrio>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    barrio = new Barrio()
                    {
                        Id = Convert.ToInt32(row["ID_BARRIO"]),
                        Nombre = row["BARRIO"].ToString()
                    };
                    lista.Add(barrio);
                }

                return lista;
            }

            return null;
        }



        public List<Cliente> ConsultarCliente()
        {
            
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_CLIENTE";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Cliente> lista = new List<Cliente>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    
                    lista.Add(new Cliente(row["APELLIDO"].ToString(), row["NOMBRE"].ToString(), new Barrio(), Convert.ToInt32(row["ID_CLIENTE"])));
                }

                return lista;
            }

            return null;
        }
        public List<Cliente> ConsultarTodosClientes()
        {

            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_SCREEN_CLIENTES";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<Cliente> lista = new List<Cliente>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {

                    lista.Add(new Cliente(row["APELLIDO"].ToString(), row["NOMBRE"].ToString(), new Barrio() { Nombre = row["BARRIO"].ToString() }, Convert.ToInt32(row["ID"]))
                    {
                        Telefono = Convert.ToInt32(row["TELEFONO"]),
                        Email = row["EMAIL"].ToString()
                    });
                }

                return lista;
            }

            return null;
        }

    }
}

