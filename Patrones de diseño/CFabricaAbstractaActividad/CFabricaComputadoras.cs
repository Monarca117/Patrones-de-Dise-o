using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    internal class CFabricaComputadoras: IFabrica
    {
        private IProductoProcesador Procesador;
        private IProductoRAM RAM;
        private IProductoDiscoDuro DiscoDuro;

        public IProductoProcesador obtenProductoProcesador { get { return Procesador; } }
        public IProductoRAM obtenProductoRAM { get { return RAM; } }
        public IProductoDiscoDuro obtenProductoDiscoDuro { get { return DiscoDuro; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("BIENVENIDO A LAS COMPUTADORAS MONARCH");
            int op;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Indique su presupuesto");
            op = Convert.ToInt32(Console.ReadLine());

            if (op >= 1000 && op <= 10000)
            {
                Console.WriteLine("Con su presupuesto usted tiene acceso a la gama baja");
                Procesador = new CProcesadorGBaja();
                RAM = new CRAMGBaja();
                DiscoDuro = new CDiscoDuroGBaja();

            }else if (op >= 10001 && op <= 20000)
            {
                Console.WriteLine("Con su presupuesto usted tiene acceso a la gama media");
                Procesador = new CProcesadorGMedia();
                RAM = new CRAMGMedia();
                DiscoDuro = new CDiscoDuroGMedia();
            }
            else if(op > 20001)
            {
                Console.WriteLine("Con su presupuesto usted tiene acceso a la gama Alta");
                Procesador = new CProcesadorGAlta();
                RAM = new CRAMGAlta();
                DiscoDuro = new CDiscoDuroGAlta();
            }else
            {
                Console.WriteLine("Opción incorrecta");
            }

            return;
        }
    }
}
