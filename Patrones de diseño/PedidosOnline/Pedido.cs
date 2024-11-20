using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Clase que representa un pedido en la tienda en línea.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.1
    /// Modificación: 04-11-24
    public class Pedido
    {
        public string Cliente { get; private set; }
        public List<string> Productos { get; private set; }
        public string Estado { get; private set; }

        public Pedido(string cliente, List<string> productos)
        {
            Cliente = cliente;
            Productos = productos;
            Estado = "Recibido";
        }
    }

}
