using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase que implementa la interfaz `ICard`.
    /// Representa una carta en el mazo.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class Card : ICard
    {
        private string suit; //!< Representa el palo de la carta.
        private string rank; //!< Representa el valor de la carta.

        /// Constructor de la clase `Card`.
        /// Autor: Angel Esaú Flores Bonilla
        /// Fecha: 30-11-24
        /// <param name="suit">El palo de la carta</param>
        /// <param name="rank">El valor de la carta</param>
        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        /// Método para clonar la carta (Patrón Prototipo).
        public ICard Clone()
        {
            return new Card(this.suit, this.rank);
        }

        /// Método para representar la carta como texto.
        public override string ToString()
        {
            return $"{rank} de {suit}";
        }
    }
}
