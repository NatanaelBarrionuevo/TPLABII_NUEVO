using PresupuestosBack.Datos;
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
    public class CaracteristicaDao1 : ICaracteristicaDAO
    {
        public bool CargarCaracteristicas(Caracteristica caracteristica)
        {

            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@DETALLE", caracteristica.Detalle),
                new Parametro("@TIPO_CARACTERISTICA", caracteristica.Tio_carac.Id),
                new Parametro("@PRODUCTO", caracteristica.Producto.Id)
            };
            string sp = "SP_INSERT_CARACTERISTICAS";


            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, parametros);

            if (afectadas == 1)
            {
                return true;
            }

            return false;

        }

        public List<TipoCaracteristica> ConsultarCaracteristicas()
        {
            List<TipoCaracteristica> caracts = new List<TipoCaracteristica>();

            string sp = "SP_GET_TIPO_CARACTERISTICA";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, null);



            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    caracts.Add(new TipoCaracteristica(Convert.ToInt32(row["ID_T_CARACTERISTICA"]), row["TIPO"].ToString()));


                }

                return caracts;
            }

            return null;
        }
    }
}
