using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Interfaz
{
    public interface IProveedorDao
    {
        bool CargarProveedor(Proveedor oProveedor);
        List<RazonSocial> ConsultarRazones();
        List<Barrio> ConsultarBarrios();
        List<Proveedor> ConsultarProveedores();
    }
}
