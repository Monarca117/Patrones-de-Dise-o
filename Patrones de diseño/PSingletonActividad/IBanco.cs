using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingletonActividad
{
    internal interface IBanco
    {
        void Depositar(double cantidad);
        void Retirar(double cantidad);
        double ConsultarSaldo();
    }
}
