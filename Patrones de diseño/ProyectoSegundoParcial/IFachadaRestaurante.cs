using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Interfaz que define las operaciones de la fachada del restaurante" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public interface IFachadaRestaurante
    {
        void RealizarReserva(string tipoAsiento, string ubicacion);
        void ProcesarPago(string metodoPago);
        void VerReservas(); // Cambiamos el nombre para reflejar que ahora muestra todas las reservas
        void ModificarReserva(int indice, string nuevoTipoAsiento, string nuevaUbicacion); // Modificación con índice
        void CancelarReserva(int indice); // Cancelar con índice
    }
}
