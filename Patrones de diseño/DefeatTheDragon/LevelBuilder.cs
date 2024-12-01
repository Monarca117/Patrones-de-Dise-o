using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que construye niveles personalizados utilizando el patrón Builder.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class LevelBuilder
    {
        private Level _level; //!< Instancia del nivel en construcción.

        /// <summary>
        /// Constructor que inicializa un nuevo nivel vacío.
        /// </summary>
        public LevelBuilder()
        {
            _level = new Level();
        }

        /// <summary>
        /// Establece el nombre del nivel.
        /// </summary>
        /// <param name="name">Nombre del nivel.</param>
        /// <returns>El constructor actualizado.</returns>
        public LevelBuilder SetName(string name)
        {
            _level.Name = name;
            return this;
        }

        /// <summary>
        /// Establece la descripción del nivel.
        /// </summary>
        /// <param name="description">Descripción del nivel.</param>
        /// <returns>El constructor actualizado.</returns>
        public LevelBuilder SetDescription(string description)
        {
            _level.Description = description;
            return this;
        }

        /// <summary>
        /// Agrega un enemigo al nivel.
        /// </summary>
        /// <param name="enemy">Enemigo a agregar.</param>
        /// <returns>El constructor actualizado.</returns>
        public LevelBuilder AddEnemy(IEnemy enemy)
        {
            _level.Enemies.Add(enemy);
            return this;
        }

        /// <summary>
        /// Finaliza la construcción del nivel y devuelve el nivel creado.
        /// </summary>
        /// <returns>El nivel construido.</returns>
        public Level Build()
        {
            return _level;
        }
    }
}
