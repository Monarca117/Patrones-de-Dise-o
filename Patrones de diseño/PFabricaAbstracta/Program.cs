using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IFabrica miFabrica = new CFabricaQuimica();

            miFabrica.crearProductos();

            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.obtenDatos(), miSabor.informacion());

            miFabrica = new CFabricaNatural();

            miFabrica.crearProductos();

            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;
            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.obtenDatos(), miSabor.informacion());
            */

            IFabrica miFabrica1 = CFabricaSeleccion.ObtenInstancia();

            miFabrica1.crearProductos();

            IProductoLeche miLeche = miFabrica1.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica1.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.obtenDatos(), miSabor.informacion());

            IFabrica miFabrica2 = CFabricaSeleccion.ObtenInstancia();

            miFabrica1.crearProductos();

            IProductoLeche miLeche2 = miFabrica2.ObtenProductoLeche;
            IProductoSaborizante miSabor2 = miFabrica2.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine("Mi malteada 2 es de {0} y {1}", miLeche2.obtenDatos(), miSabor2.informacion());
        }
    }
}
