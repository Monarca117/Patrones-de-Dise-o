using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrototipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creamos el administrador
            CAdminPrototipo admin = new CAdminPrototipo();

            
            //Creamos a dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            /*
            //Verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("----------");

            //Modificamos el estado
            uno.Nombre = "Ana";
            dos.Nombre = "Chepe";

            //Verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("----------");

            //Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto de ese prototipo
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el modelo
            auto2.Modelo = "Honda";

            //Verificamos que cada quien tenga su estado
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("----------");

            //Obtenemos un instancia del costo
            CValores val = (CValores)admin.ObtenPrototipo("Valores");

            Console.WriteLine(val);

            Console.WriteLine("------------------------------------------");

            //Creamos una instancia
            CEstudiante estudiante = new CEstudiante("Estudiante", 5, 5, 5);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Estudiante", estudiante);

            //Obtenemos un objeto de ese prototipo
            CEstudiante estudiante2 = (CEstudiante)admin.ObtenPrototipo("Estudiante");

            //Cambiamos los valores del primer estudiante
            estudiante.Nombre = "Gabriel";
            estudiante.Calificacion1 = 10;
            estudiante.Calificacion2 = 9;
            estudiante.Calificacion3 = 10;

            //Cambiamos los valores del segundo estudiante
            estudiante2.Nombre = "Omar";
            estudiante2.Calificacion1 = 5;
            estudiante2.Calificacion2 = 7;
            estudiante2.Calificacion3 = 6;

            //Verificamos que cada quien tenga su estado
            Console.WriteLine(estudiante);
            Console.WriteLine(estudiante2);
            Console.WriteLine("----------");
            /*/

            //ACTIVIDAD
            int op = 0;

            //Creamos una instancia del producto
            CProductos producto = new CProductos("Producto", 0, "Pais");

            Console.WriteLine("BIENVENIDO");
            Console.WriteLine(@"1. Agregar un prototipo
2. Agregar una variante del prototipo
3. Salir");

            do
            {
                Console.WriteLine("¿Desea realizar otra opción?");
                Console.WriteLine(@"1. Agregar un prototipo
2. Agregar una variante del prototipo
3. Salir");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    admin.AdicionaPrototipo("Producto", producto);


                }
                else if (op == 2)
                {
                    Console.WriteLine("Agregando una variante del prototipo...");
                    // Aquí puedes agregar la lógica correspondiente a "Agregar una variante del prototipo"
                }
                else if (op == 3)
                {
                    Console.WriteLine("Saliendo...");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }

            } while (op != 3);
        }
    }
}
