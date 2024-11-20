using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha encendido el auto");
        }

        public void  Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha apagadp el auto");
        }
        public void ColocarALarma()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Alarma encendida");
        }
        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Alarma apagada");
        }
    }
}
