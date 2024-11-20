using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Servicio real de pedidos que simula el acceso a la base de datos.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.1
    /// Modificación: 04-11-24
    public class RealPedidoService
    {
        /// Simula la obtención de un pedido por su ID.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        /// <param name="pedidoId">Identificador del pedido</param>
        /// <returns>Detalles del pedido</returns>
        public Pedido GetPedido(int pedidoId)
        {
            Console.WriteLine("Simulación de conexión a la base de datos: Conectado");
            return new Pedido("Cliente de ejemplo", new List<string> { "Producto de ejemplo" });
        }
    }
}
