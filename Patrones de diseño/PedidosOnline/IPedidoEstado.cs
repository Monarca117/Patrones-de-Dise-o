using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Interfaz para los estados del pedido.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.1
    /// Modificación: 04-11-24
    public interface IPedidoEstado
    {
        IPedidoEstado Siguiente();
    }

}
