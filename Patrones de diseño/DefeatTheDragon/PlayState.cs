using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase que representa el estado de juego activo.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 01-12-2024
    internal class PlayState : IGameState
    {
        private Player _player;
        private Level _currentLevel;

        /// <summary>
        /// Constructor que inicializa el estado de juego activo con el jugador y nivel actual.
        /// </summary>
        public PlayState(Player player, Level currentLevel)
        {
            _player = player;
            _currentLevel = currentLevel;
        }

        /// <summary>
        /// Maneja la lógica del estado de juego activo.
        /// </summary>
        public void HandleState()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*******************************");
            Console.WriteLine($"** Estás en el nivel: {_currentLevel.Name}  **");
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************************");
            Console.WriteLine("* {0} *", _currentLevel.Description);
            Console.WriteLine("****************************************");
            Console.WriteLine("");


            foreach (var enemy in _currentLevel.Enemies)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"¡Un {enemy.Name} aparece con {enemy.Health} de salud!");
                Combat(enemy);
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Lógica de combate por turnos entre el jugador y el enemigo.
        /// </summary>
        /// <param name="enemy">Enemigo actual en combate.</param>
        private void Combat(IEnemy enemy)
        {
            while (_player.IsAlive && enemy.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Es tu turno. ¿Qué arma usarás? (puños, espada, arco, hacha)");
                Console.WriteLine("Escribe el nombre de tu arma");
                string weapon = Console.ReadLine()?.ToLower();
                int playerDamage = _player.Attack();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Atacas con {weapon} e infliges {playerDamage} de daño.");
                enemy.TakeDamage(playerDamage);

                if (enemy.Health > 0)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El {enemy.Name} te ataca e inflige {enemy.Damage} de daño.");
                    _player.TakeDamage(enemy.Damage);
                }
            }

            if (_player.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"¡Has derrotado al {enemy.Name}!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Has sido derrotado. El juego ha terminado.");
            }
        }
    }
}
