using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingletonActividad
{
    internal class CBancoSingleton: IBanco
    {
        private static CBancoSingleton instanciaUnica;
        private double saldo;

    // Constructor privado para evitar instancias externas.
    private CBancoSingleton() 
    {
        saldo = 0.0;
    }

        // Método público que devuelve la única instancia de la clase.
        public static CBancoSingleton ObtenInstancia()
        {
            //Verificamos si no existe la instancia
            if (instanciaUnica == null)
            {
                //Si no existe, instanciamos 
                instanciaUnica = new CBancoSingleton();

                Console.WriteLine("--- Instancia creada por primera vez ---");
            }

            //Regresamos la instancia
            return instanciaUnica;
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Se depositaron {cantidad} unidades. Saldo actual: {saldo}");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad} unidades. Saldo actual: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
            }
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }
    }
}
