using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Estado inicial de un pedido: Recibido.
    public class EstadoRecibido : IPedidoEstado
    {
        public IPedidoEstado Siguiente()
        {
            return new EstadoEnProceso();
        }
    }
}
