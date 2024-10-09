using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Clase que representa un asiento del restaurante" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public class CAsiento : IAsiento
    {
        private string tipo;
        private string ubicacion;

        public CAsiento(string tipo, string ubicacion)
        {
            this.tipo = tipo;
            this.ubicacion = ubicacion;
        }

        /// "Obtener la descripción del asiento"
        /// Autor: Miguel Angel Arellano Juárez 
        /// Fecha: 05/10/2024
        /// Versión: 1.0.0.1
        /// Modificación: 05/10/2024
        /// <returns>Descripción del asiento</returns>
        public string ObtenerDescripcion()
        {
            return $"Asiento tipo: {tipo}, Ubicación: {ubicacion}";
        }
    }

}
