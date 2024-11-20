using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PChain
{
    internal interface IHandler
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
