using PuntoDeVentaSOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VentaExtra : ICargoExtraDecorator
{
    private List<string> _productos;
    public VentaExtra(List<string> productos)
    {
        _productos = productos;
    }

    public decimal CalcularTotal()
    {
        decimal total = 0m;
        return total;
    }

    public List<string> ObtenerProductos()
    {
        return _productos;
    }

    public override string ToString() =>
        $"El Total de la venta con extras es: {CalcularTotal():N2}";
}
