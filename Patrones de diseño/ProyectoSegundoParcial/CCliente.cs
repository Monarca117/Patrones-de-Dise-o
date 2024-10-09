using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Clase que representa un cliente del restaurante" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public class CCliente : ICliente
    {
        private string nombre;
        private bool autorizado;

        public CCliente(string pNombre, bool pAutorizado)
        {
            nombre = pNombre;
            autorizado = pAutorizado;
        }

        /// "Verificar si el cliente está autorizado"
        /// Autor: Miguel Angel Arellano Juárez 
        /// Fecha: 05/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: 05/10/2024
        /// <returns>Verdadero si el cliente está autorizado, falso en caso contrario</returns>
        public bool EsClienteAutorizado()
        {
            return autorizado;
        }
    }

}
