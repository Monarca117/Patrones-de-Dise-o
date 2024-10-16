using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //No se puede obtener la instancia directamente
            //CSingleton single = new CSingleton();

            //Obtenemos la instancia, se crea por primera vez
            CSingleton uno = CSingleton.ObtenInstancia();

            //Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("----");

            //Obtenemos la instancia
            CSingleton dos = CSingleton.ObtenInstancia();

            //Comprobamos que es la misma instancia
            //Si lo es, tendra el mismo estado
            Console.WriteLine(dos);
        }
    }
}
