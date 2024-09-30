using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrototipo
{
    class CAdminPrototipo
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipo() 
        {
            //Adicionamos los objetos prototipos con los valores iniciales que nos interesan

            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores   );
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add (pLlave, pPrototipo);
        }

        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
