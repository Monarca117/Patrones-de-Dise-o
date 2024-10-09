using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Clase que adapta el método de pago" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public class CAdaptadorPago : IAdaptadorPago
    {
        // Implementación del método Pagar
        public void Pagar(string metodoPago)
        {
            Console.WriteLine($"Pago procesado usando: {metodoPago}");
        }
    }


}
