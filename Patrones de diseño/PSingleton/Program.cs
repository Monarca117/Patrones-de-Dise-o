using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener la instancia del logger
            Logger logger = Logger.Instancia; 
            
            // Registrar algunos mensajes
            logger.Log("Inicio del programa"); 
            logger.Log("Realizando alguna tarea"); 
            
            // Obtener la instancia del logger de nuevo
            Logger logger2 = Logger.Instancia;

            // Registrar otro mensaje
            logger2.Log("Finalizando el programa");
        }
    }
}
