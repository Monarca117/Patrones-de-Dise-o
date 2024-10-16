using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    class CFabricaNatural: IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendras, 2)Coco");
            seleccion = Console.ReadLine();

            if (seleccion == "1")
                leche = new CLecheAlmendras();
            else
                leche = new CLecheCoco();

            leche.producir();

            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new CVainillaNatural();
            sabor.obtener();
        }
    }
}
