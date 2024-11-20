using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PChain
{
    internal class CVendedor: IHandler
    {
        private IHandler siguiente = null;

        public CVendedor(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el vendedor");

            //Si son más de 20 artículos o más de 20000 en ventas se pasa al jefe de piso
            double total = pCantidad * pPrecio;

            if (pCantidad > 20 || total > 20000)
            {
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            }
            else
            {
                //Si
                if (pCantidad > 10)
                    total *= 0.95;
            }

            return total;
        }
    }
}
