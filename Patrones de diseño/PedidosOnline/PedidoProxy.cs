using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Clase proxy para el acceso a la base de datos de pedidos.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.1
    /// Modificación: 04-11-24
    public class PedidoProxy
    {
        private readonly RealPedidoService _pedidoService;

        public PedidoProxy()
        {
            _pedidoService = new RealPedidoService();
        }

        /// Método para obtener un pedido por su ID, con control de acceso.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        /// <param name="pedidoId">Identificador del pedido</param>
        /// <returns>Detalles del pedido</returns>
        public Pedido GetPedido(int pedidoId)
        {
            // Control de acceso y seguridad aquí
            return _pedidoService.GetPedido(pedidoId);
        }
    }
}
