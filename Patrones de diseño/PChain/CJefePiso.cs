using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PChain
{
    internal class CJefePiso: IHandler
    {
        private IHandler siguiente = null;

        public CJefePiso(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el jefe de piso");

            //Si son más de 100 artículos o más de 75000 en ventas se pasa al propietario
            double total = pCantidad * pPrecio;

            if (pCantidad > 100 || total > 75000)
            {
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            }
            else
            {
                //Damos el 10% de descuento
                if (pCantidad > 20)
                    total *= 0.95;
            }

            return total;
        }
    }
}
