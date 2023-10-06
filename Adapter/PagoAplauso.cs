using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoAplauso : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando con Aplausos");
        }
    }
    
}

