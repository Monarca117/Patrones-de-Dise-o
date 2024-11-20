using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosOnline
{
    /// Esta clase maneja la configuración global de la aplicación.
    /// Autor: Miguel Angel Arellano Juárez
    /// Fecha: 04-11-24
    /// Versión: 1.0.0.1
    /// Modificación: 04-11-24
    public class AppConfig
    {
        private static AppConfig _instance;

        /// Configuración de conexión a la base de datos.
        public string DatabaseConnection { get; private set; }

        private AppConfig()
        {
            // Mensaje de simulación de conexión
            DatabaseConnection = "Simulación de conexión a la base de datos: Conectado";
        }

        /// Obtiene la instancia única de AppConfig.
        /// Autor: Miguel Angel Arellano Juárez
        /// Fecha: 04-11-24
        /// Versión: 1.0.0.1
        /// Modificación: 04-11-24
        /// <returns>Instancia única de AppConfig</returns>
        public static AppConfig GetInstance()
        {
            if (_instance == null)
                _instance = new AppConfig();
            return _instance;
        }
    }
}
