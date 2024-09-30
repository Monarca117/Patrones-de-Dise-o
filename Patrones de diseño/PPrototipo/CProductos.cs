using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrototipo
{
    internal class CProductos: IPrototipo
    {
        private string nombre;
        private int costo;
        private string pais;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Costo { get => costo; set => costo = value; }
        public string Pais { get => pais; set => pais = value; }

        public CProductos(string pNombre, int pCosto, string pPais)
        {
            nombre = pNombre;
            costo = pCosto;
            pais = pPais;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", nombre, costo, pais);
        }

        public object Clonar()
        {
            CProductos clon = new CProductos(nombre, costo, pais);

            return clon;
        }
    }
}
