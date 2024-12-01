using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Interfaz para la estructura de un mazo de cartas.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal interface IDeckTemplate
    {
        /// Método para preparar el mazo siguiendo un proceso definido.
        void PrepareDeck();

        /// Método para obtener la lista de cartas del mazo.
        List<ICard> GetDeck();
    }
}
