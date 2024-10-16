using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    class CLecheCoco: IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }
    }
}
