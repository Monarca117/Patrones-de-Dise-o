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

        public IProductoProcesador ObtenProductoProcesador { get { return Procesador; } }
        public IProductoRAM ObtenProductoRAM { get { return RAM; } }
        public IProductoDiscoDuro ObtenProductoDiscoDuro { get { return DiscoDuro; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("BIENVENIDO A LAS COMPUTADORAS MONARCH");
            int op;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Indique su presupuesto");
            op = Convert.ToInt32(Console.ReadLine());

            if (op >= 1000 && )
            {
                Console.WriteLine("Con su presupuesto usted tiene acceso a la gama baja");
            }
        }
    }
}
