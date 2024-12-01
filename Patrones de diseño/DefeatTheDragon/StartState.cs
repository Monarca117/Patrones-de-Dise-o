using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa el estado inicial del juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 01-12-2024
    internal class StartState : IGameState
    {
        /// <summary>
        /// Maneja la lógica del estado inicial del juego.
        /// </summary>
        public void HandleState()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*         ~~~  DEFEAT THE DRAGON  ~~~           *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*          ¡Bienvenido al juego!                *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("* La aventura está a punto de comenzar...       *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
            Console.WriteLine("* En este épico viaje, te enfrentarás a         *");
            Console.WriteLine("* criaturas míticas, resolverás acertijos y     *");
            Console.WriteLine("* desafiarás al temible dragón para salvar      *");
            Console.WriteLine("* tu reino.                                     *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*************************************************");
            Console.WriteLine("*          Presentado por MonarchGames          *");
            Console.WriteLine("*************************************************");

        }
    }
}
