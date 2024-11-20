using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Clase que representa los estados de un pedido.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.2
    /// Modificación: 04-11-24
    public class PedidoState
    {
        public IPedidoEstado EstadoActual { get; private set; }

        public PedidoState()
        {
            EstadoActual = new EstadoRecibido();
        }

        /// Cambia al siguiente estado del pedido.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.2
        /// Modificación: 04-11-24
        public void SiguienteEstado()
        {
            EstadoActual = EstadoActual.Siguiente();
        }
    }
}
