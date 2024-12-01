using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// Clase principal para ejecutar la aplicación.
    /// Autor: Angel Esaú Flores Bonilla
    /// Fecha: 30-11-24
    /// Versión: 1.0.1.0
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Mazos de Cartas");
            Console.WriteLine("1. Crear mazo estándar.");
            Console.WriteLine("2. Ver cartas del mazo.");
            Console.WriteLine("3. Repartir cartas entre jugadores.");
            Console.WriteLine("4. Salir.");

            var deckManager = DeckManager.GetInstance();
            var distributor = new DeckDistributor();

            while (true)
            {
                Console.Write("\nElige una opción: ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Creando mazo estándar...");
                    var builder = new DeckBuilder();
                    var standardDeck = builder.SetBaseDeck(new StandardDeckTemplate()).Build();
                    standardDeck.PrepareDeck();
                    deckManager.SetDeck(standardDeck);
                    Console.WriteLine("¡Mazo estándar creado!");
                }
                else if (option == "2")
                {
                    var deck = deckManager.GetDeck()?.GetDeck();
                    if (deck == null)
                    {
                        Console.WriteLine("No hay un mazo activo.");
                    }
                    else
                    {
                        Console.WriteLine("Cartas en el mazo:");
                        var iterator = new DeckIterator(deck);
                        while (iterator.HasNext())
                        {
                            Console.WriteLine(iterator.Next());
                        }
                    }
                }
                else if (option == "3")
                {
                    var deck = deckManager.GetDeck()?.GetDeck();
                    if (deck == null)
                    {
                        Console.WriteLine("No hay un mazo activo.");
                    }
                    else
                    {
                        Console.Write("Ingresa el número de jugadores (2 a 4): ");
                        if (int.TryParse(Console.ReadLine(), out int playerCount))
                        {
                            try
                            {
                                var distributedDecks = distributor.DistributeDeck(deck, playerCount);
                                for (int i = 0; i < distributedDecks.Count; i++)
                                {
                                    Console.WriteLine($"\nCartas del Jugador {i + 1}:");
                                    foreach (var card in distributedDecks[i])
                                    {
                                        Console.WriteLine(card);
                                    }
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido de jugadores. Intenta de nuevo.");
                        }
                    }
                }
                else if (option == "4")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                }
            }
        }
    }
}
