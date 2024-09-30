﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrototipo
{
    //Simulamos un constructr costoso
    internal class CValores: IPrototipo
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public CValores()
        {


        }

        //Constructor costoo
        public CValores(int pM)
        {
            m = pM;
            int n = 0;
            for (n = 0; n < 90; n++)
                sumatoria += Math.Sin(n * 0.0175);
        }

        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }

        public object Clonar()
        {
            CValores clon = new CValores();
            clon.M = m;
            clon.Sumatoria = sumatoria;

            return clon;
        }
    }
}
