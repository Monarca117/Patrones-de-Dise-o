using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingleton
{
    internal class CSingleton
    {
        //Se guarda la unica instancia que va a existir
        private static CSingleton instancia;

        //Datos propios de la clase
        private string nombre;
        private int edad;

        // Creamos el constructor privado
        private CSingleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static CSingleton ObtenInstancia()
        {
            //Verificamos si no existe la instancia
            if (instancia == null)
            {
                //Si no existe, instanciamos 
                instancia = new CSingleton();

                Console.WriteLine("--- Instancia creada por primera vez ---");
            }

            //Regresamos la instancia
            return instancia;
        }

        //Métodos propios de la clase
        public override string ToString()
        {
            return string.Format("La persona {0} tiene una edad de {1}", nombre, edad);
        }

        public void PonerDatos(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        //Esto representa cualquier otro objeto
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
        }
    }
}
