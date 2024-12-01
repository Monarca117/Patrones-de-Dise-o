using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Interfaz que define los métodos para observar eventos en el juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal interface IGameObserver
    {
        /// <summary>
        /// Notifica al observador sobre un cambio en el estado del juego.
        /// </summary>
        /// <param name="message">Mensaje que describe el cambio.</param>
        void Update(string message);
    }
}
