using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Interfaz que define las operaciones de una reserva" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public interface IReserva
    {
        string TipoAsiento { get; set; }
        string Ubicacion { get; set; }
        string Estado { get; set; } // Estado de la reserva

        void Confirmar(); // Método para confirmar la reserva
        string MostrarDetalles(); // Mostrar detalles de la reserva
        void Modificar(string nuevoTipoAsiento, string nuevaUbicacion); // Método para modificar la reserva
        void Cancelar(); // Método para cancelar la reserva
    }
}
