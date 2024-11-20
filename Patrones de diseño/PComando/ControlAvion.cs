using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ControlAvion
    {
        private IComando[] comandos = new IComando[6];
        public ControlAvion(Avion pAvion)
        {
            comandos[0] = new ComandoElevarse(pAvion);
            comandos[1] = new ComandoDescender(pAvion);
            comandos[2] = new ComandoAterrizar(pAvion);
            comandos[3] = new ComandoVirar(pAvion);
            comandos[4] = new ComandoVirar2(pAvion);
        }

        public void Boton(int pIndice)
        {
            comandos[pIndice].ejecutar();
        }
    }
}
