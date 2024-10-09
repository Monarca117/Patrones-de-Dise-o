using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFlyWeight
{
    internal class CFlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {
            //Verificamos si existe
            bool existe = false;

            foreach (IFlyweight f in flyweights)
            {
                if(f.ObtenNombre() == pNombre)
                    existe = true;
            }
        }
    }
}
