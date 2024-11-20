using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    internal class Program
    {
        /// Punto de entrada principal para la aplicación de gestión de pedidos.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.3
        /// Modificación: 04-11-24
        static async Task Main(string[] args)
        {
            // Configuración global mediante Singleton
            AppConfig config = AppConfig.GetInstance();
            Console.WriteLine(config.DatabaseConnection);

            // Solicitar al usuario que ingrese los detalles del pedido
            Console.Write("Ingrese el nombre del cliente: ");
            string cliente = Console.ReadLine();

            Console.WriteLine("Ingrese los productos para el pedido (escriba 'fin' para terminar):");
            List<string> productos = new List<string>();
            string producto;
            while ((producto = Console.ReadLine())?.ToLower() != "fin")
            {
                productos.Add(producto);
                Console.Write("Producto agregado. Ingrese otro producto o 'fin' para terminar: ");
            }

            // Creación del pedido usando el patrón Builder
            PedidoBuilder builder = new PedidoBuilder();
            Pedido pedido = builder.SetCliente(cliente)
                                   .AddProductos(productos)
                                   .Build();

            Console.WriteLine($"\nPedido creado para: {pedido.Cliente}");
            Console.WriteLine("Productos en el pedido:");
            foreach (var prod in pedido.Productos)
            {
                Console.WriteLine("- " + prod);
            }

            // Gestión y procesamiento del pedido
            PedidoManager pedidoManager = new PedidoManager();
            await pedidoManager.ProcesarPedidoAsync();
        }
    }
}
