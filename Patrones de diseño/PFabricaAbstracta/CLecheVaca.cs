using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    class CLecheVaca : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche vaca, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Ordeñar vaca en la granja");
        }
    }
}
