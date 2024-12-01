using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Interfaz que define las operaciones básicas de un jugador.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal interface IPlayer
    {
        /// <summary>
        /// Realiza un ataque con un arma específica.
        /// </summary>
        /// <param name="weapon">El arma utilizada para el ataque.</param>
        /// <returns>Daño infligido por el jugador.</returns>
        int Attack(string weapon);

        /// <summary>
        /// Recibe daño y reduce la salud del jugador.
        /// </summary>
        /// <param name="damage">Cantidad de daño recibido.</param>
        void TakeDamage(int damage);

        /// <summary>
        /// Indica si el jugador sigue vivo.
        /// </summary>
        bool IsAlive { get; }
    }
}
