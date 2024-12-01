using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Interfaz que define las operaciones de un estado en el juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal interface IGameState
    {
        /// <summary>
        /// Maneja la lógica del estado actual.
        /// </summary>
        void HandleState();
    }
}
