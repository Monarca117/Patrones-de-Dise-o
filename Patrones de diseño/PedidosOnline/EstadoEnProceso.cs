using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Estado "En Proceso" de un pedido.
    public class EstadoEnProceso : IPedidoEstado
    {
        public IPedidoEstado Siguiente()
        {
            return new EstadoEnviado();
        }
    }
}
