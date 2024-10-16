using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CDiscoDuroGBaja : IProductoDiscoDuro
    {
        public string obtenerDatosDiscoDuro()
        {
            return "Disco duro de gama baja";
        }

        public void producirDiscoDuro()
        {
            Console.WriteLine("Generando disco duro modelo MPGA");
        }
    }
}
