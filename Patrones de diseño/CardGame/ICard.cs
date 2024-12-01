using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Interfaz para representar una carta.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal interface ICard
    {
        /// Método para clonar una carta (Patrón Prototipo).
        ICard Clone();

        /// Método para representar la carta como texto.
        string ToString();
    }
}
