using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoBendicion  : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando con Bendiciones");
        }
    }
}
