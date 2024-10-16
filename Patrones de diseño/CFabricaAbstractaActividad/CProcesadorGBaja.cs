using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CProcesadorGBaja : IProductoProcesador
    {
        public string obtenDatosProcesador()
        {
            return "Procesador de gama baja";
        }

        public void producirProcesador()
        {
            Console.WriteLine("Generando procesador modelo MPGM");
        }
    }
}
