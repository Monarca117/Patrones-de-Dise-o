using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    using System.Collections.Generic;

    /// "Fachada que simplifica las interacciones del sistema de reservas" 
    /// Autor: Miguel Angel Arellano Juárez 
    /// Fecha: 14-12-15
    /// Versión: 1.0.0.0
    /// Modificación: 05/10/2024
    public class CFachadaRestaurante : IFachadaRestaurante
    {
        private IAdaptadorPago _adaptadorPago;
        private List<IReserva> _reservas; // Usamos una lista para almacenar las reservas

        public CFachadaRestaurante(IAdaptadorPago adaptadorPago)
        {
            _adaptadorPago = adaptadorPago;
            _reservas = new List<IReserva>(); // Inicializamos la lista de reservas
        }

        public void RealizarReserva(string tipoAsiento, string ubicacion)
        {
            IReserva nuevaReserva = new CReserva(tipoAsiento, ubicacion);
            nuevaReserva.Confirmar();
            _reservas.Add(nuevaReserva); // Añadimos la nueva reserva a la lista
            Console.WriteLine("Reserva realizada con éxito.");
        }

        public void ProcesarPago(string metodoPago)
        {
            if (_reservas.Count == 0)
            {
                Console.WriteLine("No hay reservas para procesar el pago.");
                return;
            }

            foreach (var reserva in _reservas)
            {
                if (reserva.Estado == "Pendiente") // Procesar solo las reservas pendientes
                {
                    _adaptadorPago.Pagar(metodoPago);
                    Console.WriteLine($"Pago procesado para la reserva: {reserva.MostrarDetalles()}");
                    return;
                }
            }

            Console.WriteLine("No hay reservas pendientes para procesar el pago.");
        }

        public void VerReservas() // Cambiamos este método para ver todas las reservas
        {
            if (_reservas.Count == 0)
            {
                Console.WriteLine("No hay reservas realizadas.");
                return;
            }

            Console.WriteLine("Reservas realizadas:");
            foreach (var reserva in _reservas)
            {
                Console.WriteLine(reserva.MostrarDetalles());
            }
        }

        public void ModificarReserva(int indice, string nuevoTipoAsiento, string nuevaUbicacion)
        {
            if (indice >= 0 && indice < _reservas.Count)
            {
                _reservas[indice].Modificar(nuevoTipoAsiento, nuevaUbicacion);
            }
            else
            {
                Console.WriteLine("Índice de reserva no válido.");
            }
        }

        public void CancelarReserva(int indice)
        {
            if (indice >= 0 && indice < _reservas.Count)
            {
                _reservas[indice].Cancelar();
                // Podríamos eliminar la reserva de la lista si se desea
                _reservas.RemoveAt(indice); // Opcional: elimina la reserva cancelada
            }
            else
            {
                Console.WriteLine("Índice de reserva no válido.");
            }
        }
    }

}
