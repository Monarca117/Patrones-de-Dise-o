using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PChain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la cadena
            CPropietario elPropietario = new CPropietario();
            CJefePiso elJefe = new CJefePiso(elPropietario);
            CVendedor elVendedor = new CVendedor(elJefe);

            int cantidad = 25;
            double precio = 2000;
            double total = 0;

            total = elVendedor.CalculaPrecioFinal(cantidad, precio);

            Console.WriteLine("total {0}, con descuento {1}", cantidad * precio, total);
        }
    }
}
