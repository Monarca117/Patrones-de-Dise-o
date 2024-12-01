using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Esta clase representa al jugador en el juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Player
    {
        // Atributos de la clase Player
        public string Name { get; private set; } //!< Nombre del jugador.
        public int Health { get; private set; } //!< Salud del jugador.
        public int Damage { get; private set; } //!< Daño del jugador.

        // Propiedad que indica si el jugador está vivo
        public bool IsAlive => Health > 0; //!< Indica si el jugador está vivo.

        /// <summary>
        /// Constructor del jugador.
        /// </summary>
        /// <param name="name">Nombre del jugador.</param>
        /// <param name="health">Salud inicial del jugador.</param>
        /// <param name="damage">Daño del jugador.</param>
        public Player(string name, int health, int damage)
        {
            Name = name; // Asigna el nombre del jugador
            Health = health; // Asigna la salud inicial
            Damage = damage; // Asigna el daño base
        }

        /// <summary>
        /// Método para que el jugador ataque.
        /// </summary>
        /// <returns>El daño que el jugador inflige.</returns>
        public int Attack()
        {
            Random rand = new Random();
            // El daño puede ser aleatorio en un rango de ±10% del daño base
            int attackDamage = (int)(Damage * (1 + rand.NextDouble() * 0.2 - 0.1));
            return attackDamage;
        }

        /// <summary>
        /// Método que permite al jugador recibir daño.
        /// </summary>
        /// <param name="damage">El daño que el jugador recibe.</param>
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0; // Evitar que la salud sea negativa
        }

        /// <summary>
        /// Método para que el jugador se cure (recupere vida).
        /// </summary>
        /// <param name="healAmount">Cantidad de vida que se recupera.</param>
        public void Heal(int healAmount)
        {
            Health += healAmount;
        }
    }
}
