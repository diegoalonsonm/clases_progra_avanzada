using Inventario.Abstracciones.AccessoDatos.Inventario.EliminarInventarioAD;
using Inventario.Abstracciones.LogicaNegocio.Inventario.EliminarInventarioLN;
using Inventario.AccesoDatos.Inventario.EliminarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Inventario.EliminarInventario
{
    public class EliminarInventarioLN : IEliminarInventarioLN
    {
        private IEliminarInventarioAD _eliminarInventarioAD;
        public EliminarInventarioLN() 
        {
            _eliminarInventarioAD = new EliminarInventarioAD();
        }

        public int EliminarInventario(int id)
        {
            return _eliminarInventarioAD.EliminarInventario(id);
        }
    }
}
