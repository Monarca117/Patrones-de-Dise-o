using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSingleton
{
    internal class Logger
    {
        // Variable privada estática para mantener la única instancia de la clase
        private static Logger instancia = null; 
        
        // Constructor privado para evitar la creación de más instancias
        private Logger() {} 
        
        // Método público estático para obtener la instancia
        public static Logger Instancia 
        { 
            get 
            {
                if (instancia == null) 
                { 
                    instancia = new Logger();
                } 
                return instancia; 
            } 
        } 
        
        // Método para registrar mensajes
        public void Log(string mensaje) 
        {
            Console.WriteLine($"[{DateTime.Now}] {mensaje}"); 
        }
    }
}
