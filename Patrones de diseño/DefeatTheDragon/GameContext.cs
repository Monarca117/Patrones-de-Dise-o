using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa el contexto de la máquina de estados del juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class GameContext
    {
        private IGameState _state; //!< Estado actual del juego.

        /// <summary>
        /// Cambia el estado actual del juego.
        /// </summary>
        /// <param name="state">Nuevo estado del juego.</param>
        public void SetState(IGameState state)
        {
            _state = state;
            _state.HandleState();
        }
    }
}
