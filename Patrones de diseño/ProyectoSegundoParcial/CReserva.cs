using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    /// "Clase que representa una reserva de asientos" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    /// "Clase que representa una reserva" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public class CReserva : IReserva
    {
        public string TipoAsiento { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }

        public CReserva(string tipoAsiento, string ubicacion)
        {
            TipoAsiento = tipoAsiento;
            Ubicacion = ubicacion;
            Estado = "Pendiente"; // Estado inicial
        }

        public void Confirmar()
        {
            Estado = "Confirmada"; // Cambiar el estado a confirmada
        }

        public string MostrarDetalles()
        {
            return $"Reserva: Tipo de Asiento: {TipoAsiento}, Ubicación: {Ubicacion}, Estado: {Estado}";
        }

        public void Modificar(string nuevoTipoAsiento, string nuevaUbicacion)
        {
            TipoAsiento = nuevoTipoAsiento;
            Ubicacion = nuevaUbicacion;
            Console.WriteLine("Reserva modificada con éxito.");
        }

        public void Cancelar()
        {
            Estado = "Cancelada"; // Cambiar el estado a cancelada
            Console.WriteLine("Reserva cancelada.");
        }
    }
}
