using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFabricaAbstracta
{
    class CFabricaQuimica: IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new CLecheVaca();
            sabor = new CSaborChocolate();
        }
    }
}
