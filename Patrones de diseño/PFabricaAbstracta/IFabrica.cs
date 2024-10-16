using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    interface IFabrica
    {
        void crearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
    }
}
