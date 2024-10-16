using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    internal class CSaborChocolate: IProductoSaborizante
    {
        public string informacion()
        {
            return "Sabor a chocolate";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }
    }
}
