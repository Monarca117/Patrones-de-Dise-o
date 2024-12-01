using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeatTheDragon
{
    /// Clase principal que coordina el flujo del juego.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 30-11-2024
    /// Versión: 1.0.0
    /// Modificación: 30-11-2024
    internal class Game
    {
        private Player _player; //!< Instancia del jugador.
        private GameWorld _world; //!< Instancia única del mundo del juego (Singleton).
        private GameContext _context; //!< Contexto de la máquina de estados.
        private List<IGameObserver> _observers; //!< Lista de observadores del juego.
        private List<Level> _levels; //!< Lista de niveles disponibles.

        /// <summary>
        /// Constructor que inicializa el juego y sus componentes.
        /// </summary>
        public Game()
        {
            _player = new Player("Héroe", 100, 20);
            _world = GameWorld.Instance;
            _context = new GameContext();
            _observers = new List<IGameObserver>();
            _levels = BuildLevels();
        }

        /// <summary>
        /// Inicia el flujo del juego desde el estado inicial.
        /// </summary>
        public void Start()
        {
            NotifyObservers("El juego ha comenzado.");
            _context.SetState(new StartState());

            foreach (var level in _levels)
            {
                _context.SetState(new PlayState(_player, level));
                if (!_player.IsAlive)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    NotifyObservers("El jugador ha muerto. Reiniciando el juego...");
                    Console.ResetColor();
                    Restart();
                    return;
                }
            }

            _context.SetState(new EndState());
            Console.ForegroundColor = ConsoleColor.Green;
            NotifyObservers("¡Felicidades! Has completado el juego.");
            Console.ResetColor();
        }

        /// <summary>
        /// Reinicia el juego desde el principio.
        /// </summary>
        private void Restart()
        {
            _player = new Player("Héroe", 100, 20);
            Start();
        }

        /// <summary>
        /// Construye los niveles del juego utilizando el patrón Builder.
        /// </summary>
        /// <returns>Lista de niveles creados.</returns>
        private List<Level> BuildLevels()
        {
            // Aquí creamos enemigos pasando los parámetros correctos
            var enemyPrototype1 = new Enemy("Zombie", 50, 10);
            var enemyPrototype2 = new Enemy("Goblin", 30, 15);
            var enemyPrototype3 = new Enemy("Dragón", 150, 30);

            return new List<Level>
        {
            new LevelBuilder()
                .SetName("Cueva")
                .SetDescription("Una cueva oscura llena de misterios.")
                .AddEnemy(enemyPrototype1.Clone()) // Clonamos el enemigo
                .AddEnemy(enemyPrototype1.Clone()) // Clonamos otro zombie
                .Build(),
            new LevelBuilder()
                .SetName("Bosque")
                .SetDescription("Un bosque lleno de criaturas mágicas.")
                .AddEnemy(enemyPrototype2.Clone()) // Clonamos el goblin
                .AddEnemy(enemyPrototype2.Clone()) // Clonamos otro goblin
                .Build(),
            new LevelBuilder()
                .SetName("Montaña")
                .SetDescription("Una montaña peligrosa donde vive un dragón.")
                .AddEnemy(enemyPrototype3.Clone()) // Clonamos al dragón
                .Build()
        };
        }

        /// <summary>
        /// Agrega un observador a la lista de observadores.
        /// </summary>
        /// <param name="observer">Observador a agregar.</param>
        public void AddObserver(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Notifica a todos los observadores sobre un cambio en el estado del juego.
        /// </summary>
        /// <param name="message">Mensaje que describe el cambio.</param>
        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
