using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa el estado final del juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.2
    /// Modificación: 01-12-2024
    internal class EndState : IGameState
    {
        /// <summary>
        /// Maneja la lógica del estado final del juego.
        /// </summary>
        public void HandleState()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| Gracias por jugar. ¡Hasta la próxima! |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("----------------------------------------");
        }
    }
}
