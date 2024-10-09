using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFlyWeight
{
    internal interface IFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre();
    }
}
