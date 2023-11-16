using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Interfaz
{
    public interface IFacturaDao
    {
        List<FormaPago> GetFormaPago(int id);
        List<FormaPago> GetFormaPago();
        List<MetodoEnvio> GetMetodoEnvios();
        int CrearFactura(Factura factura);
    }
}
