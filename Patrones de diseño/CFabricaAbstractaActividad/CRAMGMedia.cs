using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CRAMGMedia: IProductoRAM
    {
        public string obtenerDatosRAM()
        {
            return "RAM de gama media";
        }

        public void producirRam()
        {
            Console.WriteLine("Generando RAM modelo MPGM");
        }
    }
}
