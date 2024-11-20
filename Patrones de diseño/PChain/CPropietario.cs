using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PChain
{
    internal class CPropietario: IHandler
    {
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el propietario");
            double total = 0;

            //Damos un 15% de descuento
            total = pCantidad * pPrecio * 0.85;

            return total;
        }
    }
}
