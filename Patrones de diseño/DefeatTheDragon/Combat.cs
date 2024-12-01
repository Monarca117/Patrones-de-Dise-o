using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Esta clase maneja el combate entre el jugador y el enemigo.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Combat
    {
        private Player _player; //!< El jugador que pelea.
        private IEnemy _enemy; //!< El enemigo contra el que pelea el jugador.

        /// <summary>
        /// Constructor del combate, inicializa el jugador y el enemigo.
        /// </summary>
        /// <param name="player">El jugador que pelea.</param>
        /// <param name="enemy">El enemigo contra el que pelea el jugador.</param>
        public Combat(Player player, IEnemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        /// <summary>
        /// Realiza un turno de combate entre el jugador y el enemigo.
        /// </summary>
        public void StartCombat()
        {
            Console.WriteLine($"Comienza el combate entre {_player.Name} y {_enemy.Name}.");

            // Mientras ambos estén vivos, el combate continúa
            while (_player.IsAlive && _enemy.Health > 0)
            {
                // Mostrar la vida actual del jugador y el enemigo
                Console.WriteLine($"{_player.Name} tiene {_player.Health} puntos de vida.");
                Console.WriteLine($"{_enemy.Name} tiene {_enemy.Health} puntos de vida.");

                // El jugador elige atacar o defender
                string action = PlayerAction();

                // Si el jugador ataca
                if (action == "atacar")
                {
                    int damageDealt = _player.Attack();
                    Console.WriteLine($"{_player.Name} ataca y causa {damageDealt} puntos de daño.");

                    // El enemigo recibe el daño
                    _enemy.TakeDamage(damageDealt);
                }

                // Si el enemigo está vivo, responde con su turno
                if (_enemy.Health > 0)
                {
                    Random rand = new Random();
                    int damageDealtByEnemy = rand.Next(_enemy.Damage / 2, _enemy.Damage + 1);
                    Console.WriteLine($"{_enemy.Name} ataca y causa {damageDealtByEnemy} puntos de daño.");

                    // El jugador recibe el daño
                    _player.TakeDamage(damageDealtByEnemy);
                }

                // Mostrar las vidas después de cada turno
                Console.WriteLine($"{_player.Name} tiene {_player.Health} puntos de vida.");
                Console.WriteLine($"{_enemy.Name} tiene {_enemy.Health} puntos de vida.");

                // Espera para el siguiente turno
                Console.WriteLine("Presiona cualquier tecla para continuar al siguiente turno...");
                Console.ReadKey();
                Console.Clear();
            }

            // Determinar el resultado
            if (!_player.IsAlive)
            {
                Console.WriteLine($"{_player.Name} ha muerto. ¡El enemigo gana!");
            }
            else
            {
                Console.WriteLine($"{_player.Name} ha derrotado a {_enemy.Name}. ¡Victoria!");
            }
        }

        /// <summary>
        /// Determina la acción del jugador durante el combate (atacar o huir).
        /// </summary>
        /// <returns>Acción seleccionada por el jugador (atacar o huir).</returns>
        private string PlayerAction()
        {
            string action = "";
            while (action != "atacar" && action != "huir")
            {
                Console.WriteLine("¿Qué deseas hacer? (atacar/huir)");
                action = Console.ReadLine().ToLower();
            }
            return action;
        }
    }
}
