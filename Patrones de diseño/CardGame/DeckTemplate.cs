using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase base para implementar mazos (Patrón Template).
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal abstract class DeckTemplate : IDeckTemplate
    {
        private List<ICard> deck; //!< Lista de cartas en el mazo.

        /// Constructor para inicializar el mazo vacío.
        public DeckTemplate()
        {
            deck = new List<ICard>();
        }

        /// Método para preparar el mazo siguiendo un proceso definido.
        public void PrepareDeck()
        {
            CreateDeck();  // Patrón Template: define los pasos en las subclases.
            ShuffleDeck();
        }

        /// Método abstracto para que las subclases definan la creación del mazo.
        protected abstract void CreateDeck();

        /// Método para barajar las cartas.
        private void ShuffleDeck()
        {
            deck = deck.OrderBy(card => Guid.NewGuid()).ToList();
        }

        /// Método para devolver el mazo de cartas.
        public List<ICard> GetDeck()
        {
            return deck;
        }

        /// Método para agregar cartas al mazo.
        protected void AddCard(ICard card)
        {
            deck.Add(card);
        }
    }
}
