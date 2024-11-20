using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ComandoAterrizar: IComando
    {
        Avion avion;

        public ComandoAterrizar(Avion pAvion)
        {
            avion = pAvion;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente en el auto
            avion.Aterrizar();
        }
    }
}
