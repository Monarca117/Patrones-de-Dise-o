using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    internal class CFabricaSeleccion:IFabrica
    {
        private static CFabricaSeleccion instancia;

        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        private CFabricaSeleccion()
        {
            
        }

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public static CFabricaSeleccion ObtenInstancia()
        {
            //Verificamos si no existe la instancia
            if (instancia == null)
            {
                //Si no existe, instanciamos 
                instancia = new CFabricaSeleccion();

                Console.WriteLine("--- Instancia creada por primera vez ---");
            }

            //Regresamos la instancia
            return instancia;
        }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("BIENVENIDO A LAS MALTEADAS EL MONARCA");
            string seleccion;
            string seleccion2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¿Qué tipo de leche desea?");
            Console.WriteLine("1) Leche de Vaca           2) Leche de almendras            3) Leche de coco");
            seleccion = Console.ReadLine();

            if (seleccion == "1")
            {
                leche = new CLecheVaca();
            }
            else if(seleccion == "2")
            {
                leche = new CLecheAlmendras();
            }
            else
            {
                leche = new CLecheCoco();
            }

            Console.WriteLine("");

            Console.WriteLine("Procesando . . .");

            Console.WriteLine("");

            Console.WriteLine("¿Qué sabor desea para su leche?");
            Console.WriteLine("1) Chocolate           2) Vainilla");
            seleccion2 = Console.ReadLine();

            if (seleccion2 == "1")
            {
                sabor = new CSaborChocolate();
            }
            else
            {
                sabor = new CVainillaNatural();
            }

            Console.WriteLine("");

            Console.WriteLine("Procesando . . .");

            Console.WriteLine("");

            Console.WriteLine("Pedido realizado. ¡Disfrute!");
        }
    }
}
