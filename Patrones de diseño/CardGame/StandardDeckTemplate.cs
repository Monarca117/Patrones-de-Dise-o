using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase que implementa un mazo estándar de 52 cartas.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class StandardDeckTemplate : DeckTemplate
    {
        /// Método para crear un mazo estándar (Patrón Template).
        protected override void CreateDeck()
        {
            string[] suits = { "Corazones", "Diamantes", "Tréboles", "Picas" };
            string[] ranks = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    AddCard(new Card(suit, rank));  // Patrón Prototipo: crea y añade cartas.
                }
            }
        }
    }
}
