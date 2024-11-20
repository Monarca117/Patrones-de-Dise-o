using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class Avion
    {
        public void Ascender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Aumentando altitud");
        }

        public void Descender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Disminuyendo altitud");
        }
        public void Aterrizar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Aterrizando...");
        }
        public void Virar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Virando hacia la derecha");
        }

        public void Virar2()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Virando hacia la izquierda");
        }
    }
}
