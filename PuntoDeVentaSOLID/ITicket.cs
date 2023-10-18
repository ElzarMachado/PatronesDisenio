using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaSOLID
{
    public interface ITicket
    {
        decimal CobrarMoneda(decimal precio);
    }
}
