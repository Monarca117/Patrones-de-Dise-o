using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Observador que muestra mensajes en la consola.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class ConsoleObserver : IGameObserver
    {
        /// <summary>
        /// Actualiza el observador con un mensaje y lo imprime en la consola.
        /// </summary>
        /// <param name="message">Mensaje que describe el cambio.</param>
        public void Update(string message)
        {
            Console.WriteLine($"[Notificación]: {message}");
        }
    }
}
