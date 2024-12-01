using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa un nivel en el juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Level
    {
        public string Name { get; set; } //!< Nombre del nivel.
        public string Description { get; set; } //!< Descripción del nivel.
        public List<IEnemy> Enemies { get; set; } //!< Lista de enemigos presentes en el nivel.

        /// <summary>
        /// Constructor que inicializa un nivel con nombre, descripción y enemigos.
        /// </summary>
        public Level()
        {
            Enemies = new List<IEnemy>();
        }
    }
}
