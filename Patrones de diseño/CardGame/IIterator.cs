using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Interfaz para implementar un iterador.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.0.0
    internal interface IIterator<T>
    {
        /// Verifica si hay más elementos.
        bool HasNext();

        /// Devuelve el siguiente elemento.
        T Next();
    }
}
