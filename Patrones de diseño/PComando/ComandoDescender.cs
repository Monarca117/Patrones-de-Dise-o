using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ComandoDescender:IComando
    {
        Avion avion;

        public ComandoDescender(Avion pAvion)
        {
            avion = pAvion;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente en el auto
            avion.Descender();
        }
    }
}
