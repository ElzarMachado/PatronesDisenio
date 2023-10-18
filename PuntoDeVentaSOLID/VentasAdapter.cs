using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaSOLID
{
    public class VentasAdapter
    {
        private readonly IPagoPVS _pagoPVS;

        public VentasAdapter(IPagoPVS pagoPVS)
        {
            _pagoPVS = pagoPVS;
        }
        public void Cobrar()
        {
            _pagoPVS.Cobrar();
        }
    }
}
