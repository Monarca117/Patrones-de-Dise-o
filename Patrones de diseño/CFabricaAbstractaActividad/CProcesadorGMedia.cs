using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CProcesadorGMedia: IProductoProcesador
    {
        public string obtenDatosProcesador()
        {
            return "Procesador de gama media";
        }

        public void producirProcesador()
        {
            Console.WriteLine("Generando procesador modelo MPGM");
        }
    }
}
