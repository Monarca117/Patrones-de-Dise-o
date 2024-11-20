using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Estado final de un pedido: "Entregado".
public class EstadoEntregado : IPedidoEstado
{
    public IPedidoEstado Siguiente()
    {
        return this;
    }
}
}
