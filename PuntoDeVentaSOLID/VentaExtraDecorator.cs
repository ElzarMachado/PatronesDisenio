using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaSOLID
{
    public class VentaExtraDecorator
    {
        public ICargoExtraDecorator _ventaExtra;
        public VentaExtraDecorator(ICargoExtraDecorator venta)
        {
            _ventaExtra = venta;
        }

        public virtual decimal CalcularTotal()
        {
            return _ventaExtra.CalcularTotal();
        }

        public List<string> ObtenerProductos()
        {
            return _ventaExtra.ObtenerProductos();
        }
    }
}