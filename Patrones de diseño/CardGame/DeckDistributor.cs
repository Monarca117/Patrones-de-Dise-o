using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase para distribuir el mazo entre jugadores.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class DeckDistributor
    {
        /// Método para dividir el mazo entre jugadores.
        /// Autor: Angel Esaú Flores Bonilla
        /// Fecha: 30-11-24
        /// <param name="deck">El mazo de cartas a repartir.</param>
        /// <param name="playerCount">Número de jugadores (2 a 4).</param>
        /// <returns>Una lista de listas de cartas, cada lista representa las cartas de un jugador.</returns>
        public List<List<ICard>> DistributeDeck(List<ICard> deck, int playerCount)
        {
            if (playerCount < 2 || playerCount > 4)
            {
                throw new ArgumentException("El número de jugadores debe estar entre 2 y 4.");
            }

            // Mezclar el mazo antes de repartir.
            var shuffledDeck = deck.OrderBy(card => Guid.NewGuid()).ToList();

            // Crear las listas para los jugadores.
            var players = new List<List<ICard>>();
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new List<ICard>());
            }

            // Repartir las cartas.
            for (int i = 0; i < shuffledDeck.Count; i++)
            {
                players[i % playerCount].Add(shuffledDeck[i]);
            }

            return players;
        }
    }
}
