using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Estado "Enviado" de un pedido.
    public class EstadoEnviado : IPedidoEstado
    {
        public IPedidoEstado Siguiente()
        {
            return new EstadoEntregado();
        }
    }
}
