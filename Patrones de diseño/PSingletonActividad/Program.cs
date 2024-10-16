using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingletonActividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Proxy con permisos
            Console.WriteLine("Usuario con permisos:");
            IBanco bancoAutorizado = new CBancoProxy(true);
            bancoAutorizado.Depositar(1000);
            bancoAutorizado.Retirar(500);
            Console.WriteLine($"Saldo actual: {bancoAutorizado.ConsultarSaldo()}");

            Console.WriteLine();

            // Proxy sin permisos
            Console.WriteLine("Usuario sin permisos:");
            IBanco bancoNoAutorizado = new CBancoProxy(false);
            bancoNoAutorizado.Depositar(500);
            bancoNoAutorizado.Retirar(100);
            bancoNoAutorizado.ConsultarSaldo();

            Console.ReadKey();
        }
    }
}
