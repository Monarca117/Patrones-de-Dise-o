using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CRAMGBaja : IProductoRAM
    {
        public string obtenerDatosRAM()
        {
            return "RAM de gama baja";
        }

        public void producirRam()
        {
            Console.WriteLine("Generando RAM modelo MPGB");
        }
    }
}
