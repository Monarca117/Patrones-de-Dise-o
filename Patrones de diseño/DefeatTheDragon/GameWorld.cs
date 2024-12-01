using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa el mundo del juego utilizando el patrón Singleton.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class GameWorld
    {
        private static GameWorld _instance; //!< Instancia única del mundo del juego.
        public string CurrentLocation { get; set; } //!< Ubicación actual del jugador en el mundo.

        /// <summary>
        /// Constructor privado para evitar instancias externas.
        /// </summary>
        private GameWorld()
        {
            CurrentLocation = "Inicio del juego";
        }

        /// <summary>
        /// Obtiene la instancia única del mundo del juego.
        /// </summary>
        /// <returns>La instancia única del mundo del juego.</returns>
        public static GameWorld Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameWorld();
                }
                return _instance;
            }
        }
    }
}
