using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSegundoParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAdaptadorPago adaptadorPago = new CAdaptadorPago();
            IFachadaRestaurante fachada = new CFachadaRestaurante(adaptadorPago);

            while (true)
            {
                Console.WriteLine("BIENVENIDO");
                Console.WriteLine("1. Realizar reserva");
                Console.WriteLine("2. Ver reservas");
                Console.WriteLine("3. Modificar reserva");
                Console.WriteLine("4. Cancelar reserva");
                Console.WriteLine("5. Procesar pago");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese tipo de asiento: ");
                        var tipoAsiento = Console.ReadLine();
                        Console.Write("Ingrese ubicación: ");
                        var ubicacion = Console.ReadLine();
                        fachada.RealizarReserva(tipoAsiento, ubicacion);
                        break;
                    case "2":
                        fachada.VerReservas();
                        break;
                    case "3":
                        fachada.VerReservas(); // Muestra reservas para seleccionar
                        Console.Write("Ingrese el índice de la reserva a modificar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceModificar))
                        {
                            Console.Write("Ingrese nuevo tipo de asiento: ");
                            var nuevoTipo = Console.ReadLine();
                            Console.Write("Ingrese nueva ubicación: ");
                            var nuevaUbicacion = Console.ReadLine();
                            fachada.ModificarReserva(indiceModificar, nuevoTipo, nuevaUbicacion);
                        }
                        break;
                    case "4":
                        fachada.VerReservas(); // Muestra reservas para seleccionar
                        Console.Write("Ingrese el índice de la reserva a cancelar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceCancelar))
                        {
                            fachada.CancelarReserva(indiceCancelar);
                        }
                        break;
                    case "5":
                        Console.Write("Ingrese método de pago: ");
                        var metodoPago = Console.ReadLine();
                        fachada.ProcesarPago(metodoPago);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Desea realizar otra opción? (s/n)");
                if (Console.ReadLine().ToLower() != "s")
                    break;
            }
        }
    }
}
