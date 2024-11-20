using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ComandoVirar: IComando
    {
        Avion avion;

        public ComandoVirar(Avion pAvion)
        {
            avion = pAvion;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente en el auto
            avion.Virar();
        }
    }
}
