using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    class CLecheAlmendras: IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche organica de almendra, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }
    }
}
