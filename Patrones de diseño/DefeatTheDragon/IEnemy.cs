using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Interfaz que define las operaciones básicas de un enemigo.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal interface IEnemy
    {
        string Name { get; set; } //!< Nombre del enemigo.
        int Health { get; set; } //!< Salud del enemigo.
        int Damage { get; set; } //!< Daño que el enemigo inflige.

        /// <summary>
        /// Recibe daño y reduce la salud del enemigo.
        /// </summary>
        /// <param name="damage">Cantidad de daño recibido.</param>
        void TakeDamage(int damage);

        /// <summary>
        /// Clona el enemigo utilizando el patrón prototipo.
        /// </summary>
        /// <returns>Una copia del enemigo.</returns>
        IEnemy Clone();
    }
}
