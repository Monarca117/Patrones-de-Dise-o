using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrototipo
{
    internal class CEstudiante: IPrototipo
    {
        private string nombre;
        private int calificacion1;
        private int calificacion2;
        private int calificacion3;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Calificacion1 { get => calificacion1; set => calificacion1 = value; }
        public int Calificacion2 { get => calificacion2; set => calificacion2 = value; }
        public int Calificacion3 { get => calificacion3; set => calificacion3 = value; }

        public CEstudiante(string pNombre, int pCal1, int pCal2, int pCal3)
        {
            nombre = pNombre;
            calificacion1 = pCal1;
            calificacion2 = pCal2;
            calificacion3 = pCal3;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", nombre, calificacion1, calificacion2, calificacion3);
        }

        public object Clonar()
        {
            CEstudiante clon = new CEstudiante(nombre, calificacion1, calificacion2, calificacion3);

            return clon;
        }
    }
}
