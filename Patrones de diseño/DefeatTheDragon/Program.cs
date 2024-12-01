using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Esta clase representa el punto de entrada principal del juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Program
    {
        /// <summary>
        /// Método principal que inicia el juego.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 30-11-2024
        /// Versión: 1.0.0
        /// Modificación: 30-11-2024
        /// </summary>
        static void Main(string[] args)
        {
            Game game = new Game(); // Crear una nueva instancia del juego
            game.Start();          // Iniciar el juego
        }
    }
}
