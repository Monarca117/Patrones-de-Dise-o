using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Implementación de un iterador para recorrer el mazo.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class DeckIterator : IIterator<ICard>
    {
        private List<ICard> deck; //!< Lista de cartas a recorrer.
        private int currentIndex; //!< Índice actual del iterador.

        /// Constructor para inicializar el iterador con un mazo.
        public DeckIterator(List<ICard> deck)
        {
            this.deck = deck;
            this.currentIndex = 0;
        }

        /// Verifica si hay más cartas en el mazo.
        public bool HasNext()
        {
            return currentIndex < deck.Count;
        }

        /// Devuelve la siguiente carta del mazo.
        public ICard Next()
        {
            return deck[currentIndex++];
        }
    }
}
