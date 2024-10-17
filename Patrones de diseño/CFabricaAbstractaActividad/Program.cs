using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new CFabricaComputadoras();

            miFabrica.crearProductos();

            IProductoProcesador miProcesador = miFabrica.obtenProductoProcesador;
            IProductoRAM miRam = miFabrica.obtenProductoRAM;
            IProductoDiscoDuro miDiscoDuro = miFabrica.obtenProductoDiscoDuro;

            miProcesador.producirProcesador();
            miProcesador.obtenDatosProcesador();

            miRam.producirRam();
            miRam.obtenerDatosRAM();

            miDiscoDuro.obtenerDatosDiscoDuro();
            miDiscoDuro.producirDiscoDuro();

            Console.WriteLine("Tu computadora posee un {0}, un {1} y un {2}", miProcesador.obtenDatosProcesador(), miRam.obtenerDatosRAM(), miDiscoDuro.obtenerDatosDiscoDuro());

            Console.WriteLine("Disfrute de su compra");
        }
    }
}
