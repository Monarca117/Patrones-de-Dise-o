using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CDiscoDuroGAlta: IProductoDiscoDuro
    {
        public string obtenerDatosDiscoDuro()
        {
            return "Disco duro de gama alta";
        }

        public void producirDiscoDuro()
        {
            Console.WriteLine("Generando disco duro modelo MPGA");
        }
    }
}
