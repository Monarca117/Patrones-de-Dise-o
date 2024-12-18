﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComando
{
    internal class ControlRemoto
    {
        private IComando[] comandos = new IComando[4];
        
        public ControlRemoto(Automovil pAuto)
        {
            comandos[0] = new ComandoEncender(pAuto);
            comandos[1] = new ComandoApagar(pAuto);
            comandos[2] = new ComandoPrenderAlarma(pAuto);
            comandos[3] = new ComandoApagarAlarma(pAuto);
        }

        public void Boton(int pIndice)
        {
            comandos[pIndice].ejecutar();
        }
    }
}
