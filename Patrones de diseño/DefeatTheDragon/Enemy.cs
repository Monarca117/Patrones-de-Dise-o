using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa un enemigo en el juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Enemy : IEnemy
    {
        public string Name { get; set; } //!< Nombre del enemigo.
        public int Health { get; set; } //!< Salud del enemigo.
        public int Damage { get; set; } //!< Daño que el enemigo inflige.

        /// <summary>
        /// Constructor para crear un nuevo enemigo con un nombre, salud y daño.
        /// </summary>
        /// <param name="name">Nombre del enemigo.</param>
        /// <param name="health">Salud del enemigo.</param>
        /// <param name="damage">Daño que el enemigo inflige.</param>
        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        /// <summary>
        /// Método que permite al enemigo recibir daño.
        /// </summary>
        /// <param name="damage">Cantidad de daño recibido.</param>
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        /// <summary>
        /// Método para clonar el enemigo (Patrón Prototipo).
        /// </summary>
        /// <returns>Una nueva instancia de enemigo.</returns>
        public IEnemy Clone()
        {
            return new Enemy(Name, Health, Damage);
        }
    }
}
