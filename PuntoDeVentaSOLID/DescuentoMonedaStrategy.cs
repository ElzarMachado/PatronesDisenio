
namespace PuntoDeVentaSOLID
{
    public class DescuentoMonedaStrategy :ITicket
    {
        public void cobrarMoneda(decimal precio)
        {
            Console.WriteLine($"Se aplico descuento en monedas para un ahorro de: {precio}");
        }

        public decimal CobrarMoneda(decimal precio)
        {
            return precio * 25m;
        }

    }
    
}

