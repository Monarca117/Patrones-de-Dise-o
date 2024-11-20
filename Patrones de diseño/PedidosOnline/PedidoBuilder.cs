using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    using System.Collections.Generic;

    /// Clase que construye un objeto Pedido con los detalles proporcionados.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.3
    /// Modificación: 04-11-24
    public class PedidoBuilder
    {
        private string cliente;
        private List<string> productos = new List<string>();

        /// Establece el cliente para el pedido.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        public PedidoBuilder SetCliente(string cliente)
        {
            this.cliente = cliente;
            return this;
        }

        /// Agrega un producto al pedido.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        public PedidoBuilder AddProducto(string producto)
        {
            productos.Add(producto);
            return this;
        }

        /// Agrega una lista de productos al pedido.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.2
        /// Modificación: 04-11-24
        public PedidoBuilder AddProductos(List<string> productos)
        {
            this.productos.AddRange(productos);
            return this;
        }

        /// Construye el objeto Pedido con los datos establecidos.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        public Pedido Build()
        {
            return new Pedido(cliente, productos);
        }
    }

}
