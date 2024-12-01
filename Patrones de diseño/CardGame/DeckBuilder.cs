using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase Builder para configurar y construir mazos.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class DeckBuilder
    {
        private IDeckTemplate deckTemplate; //!< Plantilla de mazo a construir.

        /// Configura el mazo base.
        public DeckBuilder SetBaseDeck(IDeckTemplate deckTemplate)
        {
            this.deckTemplate = deckTemplate;
            return this;
        }

        /// Construye el mazo.
        public IDeckTemplate Build()
        {
            return deckTemplate;
        }
    }
}
