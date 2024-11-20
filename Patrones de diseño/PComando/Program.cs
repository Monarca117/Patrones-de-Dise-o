using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil miAuto = new Automovil();
            ControlRemoto control = new ControlRemoto(miAuto);

            Avion miAvion = new Avion();
            ControlAvion control2 = new ControlAvion(miAvion);

            string op;
            string op2;

            Console.WriteLine("¿Que vehiculo usara? 1. Auto, 2. Avion");
            op = Console.ReadLine();

            if (op == "1")
            {
                do
                {
                    Console.WriteLine("1. Encender, 2. Apagar, 3. Prender Alarma, 4. Apagar Alarma, 5. Apagar");

                    op2 = Console.ReadLine();

                    if (op2 == "1")
                        control.Boton(0);
                    if (op2 == "2")
                        control.Boton(1);
                    if (op2 == "3")
                        control.Boton(2);
                    if (op2 == "4")
                        control.Boton(3);

                } while (op != "5");
            }
            else if (op == "2")
            {
                do
                {
                    Console.WriteLine("1. Ascender, 2. Descender, 3. Aterrizar, 4. Virar a la izquierda, 5. Virar a la izquierda, 6. Apagar");

                    op = Console.ReadLine();

                    if (op == "1")
                        control2.Boton(0);
                    if (op == "2")
                        control2.Boton(1);
                    if (op == "3")
                        control2.Boton(2);
                    if (op == "4")
                        control2.Boton(3);
                    if (op == "5")
                        control2.Boton(4);

                } while (op != "6");
            }
        }
    }
}
