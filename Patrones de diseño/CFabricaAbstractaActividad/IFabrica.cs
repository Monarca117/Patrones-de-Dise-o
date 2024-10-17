using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFabricaAbstractaActividad
{
    interface IFabrica
    {
        void crearProductos();

        IProductoProcesador obtenProductoProcesador { get; }
        IProductoRAM obtenProductoRAM { get; }
        IProductoDiscoDuro obtenProductoDiscoDuro { get; }
    }
}
