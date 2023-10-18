
namespace PuntoDeVentaSOLID
{
    public class PagoMonedaAdapter : IPagoPVS
    {
        public void Cobrar()
        {
            Console.WriteLine("Se pago en monedas");
        }
    }
}
