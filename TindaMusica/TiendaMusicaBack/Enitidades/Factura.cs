using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMusicaBack.Enitidades
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Empleado Emplead { get; set; }
        public Cliente Client { get; set; }
        public FormaPago Metodo { get; set; }
        public Sede Sede { get; set; }
        public MetodoEnvio Envio{ get; set; }
        public List<DetaleFactura> DetaleFactura { get; set; }
        public List<DetalleServicio> DetalleServicio { get; set; }


        public double TotalProductos()
        {
            double total = 0;
            foreach (DetaleFactura det in DetaleFactura)
            {
                total += det.Precio * det.Cantidad;
            }
            return total;

        }

        public double TotalServicios()
        {
            double total = 0;
            foreach (DetalleServicio det in DetalleServicio)
            {
                total += det.PrecioPorHora * det.CantHoras;
            }
            return total;

        }

        public double Total() { return TotalServicios() + TotalProductos(); }

    }
}
