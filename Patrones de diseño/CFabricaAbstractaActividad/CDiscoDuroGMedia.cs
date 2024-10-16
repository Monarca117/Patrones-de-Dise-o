using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CDiscoDuroGMedia: IProductoDiscoDuro
    {
        public string obtenerDatosDiscoDuro()
        {
            return "Disco duro de gama media";
        }

        public void producirDiscoDuro()
        {
            Console.WriteLine("Generando disco duro modelo MPGM");
        }
    }
}
