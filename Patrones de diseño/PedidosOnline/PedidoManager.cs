using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Clase que gestiona el pedido y cambia su estado con el tiempo.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.3
    /// Modificación: 04-11-24
    public class PedidoManager
    {
        private PedidoState _estado;

        public PedidoManager()
        {
            _estado = new PedidoState();
        }

        /// Inicia el proceso de cambio de estado del pedido y muestra el mensaje correspondiente.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.3
        /// Modificación: 04-11-24
        public async Task ProcesarPedidoAsync()
        {
            Console.WriteLine("El pedido ha sido creado. Estado inicial: Recibido");

            while (!(_estado.EstadoActual is EstadoEntregado))
            {
                await Task.Delay(3000); // Espera 3 segundos antes de cambiar al siguiente estado.
                _estado.SiguienteEstado();
                Console.WriteLine($"El estado del pedido es: {_estado.EstadoActual.GetType().Name}");
            }

            Console.WriteLine("El pedido ha sido Entregado.");
        }
    }
}
