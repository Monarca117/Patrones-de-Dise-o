using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingletonActividad
{
    internal class CBancoProxy: IBanco
    {
        private CBancoSingleton Banco;
        private bool UsuarioAutorizado;

        // Constructor que recibe si el usuario tiene permisos o no.
        public CBancoProxy(bool autorizado)
        {
            UsuarioAutorizado = autorizado;
            Banco = CBancoSingleton.ObtenInstancia();  // Singleton
        }

        public void Depositar(double cantidad)
        {
            if (UsuarioAutorizado)
            {
                Banco.Depositar(cantidad);
            }
            else
            {
                Console.WriteLine("Acceso denegado: No tiene permisos para depositar.");
            }
        }

        public void Retirar(double cantidad)
        {
            if (UsuarioAutorizado)
            {
                Banco.Retirar(cantidad);
            }
            else
            {
                Console.WriteLine("Acceso denegado: No tiene permisos para retirar.");
            }
        }

        public double ConsultarSaldo()
        {
            if (UsuarioAutorizado)
            {
                return Banco.ConsultarSaldo();
            }
            else
            {
                Console.WriteLine("Acceso denegado: No tiene permisos para consultar el saldo.");
                return 0.0;
            }
        }
    }
}
