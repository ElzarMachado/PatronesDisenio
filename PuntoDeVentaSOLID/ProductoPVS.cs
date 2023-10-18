
namespace PuntoDeVentaSOLID
{
    public class ProductoPVS
    {
        private readonly ITicket _ticket;
        public ProductoPVS(ITicket ticket)
        {
            _ticket = ticket;
        }


        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get => CobrarMoneda(); }

        public decimal CobrarMoneda()
        {
            return _ticket.CobrarMoneda(Precio);

         }
     }
}


