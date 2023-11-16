using PresupuestosBack.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Datos.Interfaz;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Implementacion
{
    public class FacturaDao: IFacturaDao
    {
        public int CrearFactura(Factura factura)
        {
            int facturaNro = -1;
            SqlConnection cnn = HelperDB.ObtenerInstancia().GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_INSERT_FACTURAS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@legajo", factura.Emplead.Legajo);
                cmd.Parameters.AddWithValue("@cliente", factura.Client.Id);
                cmd.Parameters.AddWithValue("@pago", factura.Metodo.Id);
                cmd.Parameters.AddWithValue("@sede", factura.Sede.Id);
                cmd.Parameters.AddWithValue("@envio", factura.Envio.Id);
            


                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@factura";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                 facturaNro = (int)pOut.Value;

                SqlCommand cmdDetalle;

                foreach ( DetalleServicio detalle  in factura.DetalleServicio)
                {
                    cmdDetalle = new SqlCommand("SP_INSERT_DET_SERVICIO", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@FACTURA", facturaNro);
                    cmdDetalle.Parameters.AddWithValue("@LUTHIER", detalle.Luthier.Id);
                    cmdDetalle.Parameters.AddWithValue("@SERVICIO", detalle.Servicio.Id);
                    cmdDetalle.Parameters.AddWithValue("@PRECIO", detalle.PrecioPorHora);
                    cmdDetalle.Parameters.AddWithValue("@HORAS", detalle.CantHoras);


                    cmdDetalle.ExecuteNonQuery();


                }

                foreach (DetaleFactura detalle in factura.DetaleFactura)
                {
                    cmdDetalle = new SqlCommand("SP_INSERT_DET_FACTURA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@FACTURA", facturaNro);
                    cmdDetalle.Parameters.AddWithValue("@PRODUCTO", detalle.Product.Id);
                    cmdDetalle.Parameters.AddWithValue("@CANTIDAD", detalle.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@PRECIO", detalle.Precio);


                    cmdDetalle.ExecuteNonQuery();

                }



                t.Commit();

            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                facturaNro = -1;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return facturaNro;
        }

        public List<FormaPago> GetFormaPago(int id)
        {
            throw new NotImplementedException();
        }
        public List<FormaPago> GetFormaPago()
        {
           
            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_FORMA_PAGO";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<FormaPago> lista = new List<FormaPago>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    
                    lista.Add(new FormaPago()
                    {
                        Id = Convert.ToInt32(row["ID_PAGO"]),
                        Nombre = row["PAGO"].ToString()
                    });
                }

                return lista;
            }

            return null;
        }

        public List<MetodoEnvio> GetMetodoEnvios()
        {

            List<Parametro> parametros = new List<Parametro>();
            string sp = "SP_GET_FORMA_ENVIO";


            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp, parametros);


            List<MetodoEnvio> lista = new List<MetodoEnvio>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {

                    lista.Add(new MetodoEnvio()
                    {
                        Id = Convert.ToInt32(row["ID_ENVIO"]),
                        Descripcion = row["ENVIO"].ToString()
                    });
                }

                return lista;
            }

            return null;

        }

    }
}
