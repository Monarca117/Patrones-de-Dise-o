using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ComandoPrenderAlarma: IComando
    {
        Automovil auto;

        public ComandoPrenderAlarma(Automovil pAuto) 
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente en el auto
            auto.ColocarALarma();
        }
    }
}
