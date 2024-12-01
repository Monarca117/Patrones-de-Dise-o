using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase Singleton para manejar un único mazo activo.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal class DeckManager
    {
        private static DeckManager instance; //!< Instancia única del Singleton.
        private IDeckTemplate currentDeck; //!< Mazo actualmente activo.

        /// Constructor privado para evitar instanciación externa.
        private DeckManager() { }

        /// Método para obtener la instancia única del Singleton.
        public static DeckManager GetInstance()
        {
            if (instance == null)
                instance = new DeckManager();
            return instance;
        }

        /// Método para configurar el mazo actual.
        public void SetDeck(IDeckTemplate deck)
        {
            currentDeck = deck;
        }

        /// Método para obtener el mazo actual.
        public IDeckTemplate GetDeck()
        {
            return currentDeck;
        }
    }
}
