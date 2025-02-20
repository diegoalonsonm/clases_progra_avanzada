using Inventario.Abstracciones.AccessoDatos.Cliente.EliminarCliente;
using Inventario.Abstracciones.LogicaNegocio.Cliente.EliminarClienteLN;
using Inventario.AccesoDatos.Cliente.EliminarCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Cliente.EliminarCliente
{
    public class EliminarClienteLN : IEliminarClienteLN
    {
        private IEliminarClienteAD _eliminarClienteAD;

        public EliminarClienteLN()
        {
            _eliminarClienteAD = new EliminarClienteAD();
        }

        public int EliminarCliente(int id)
        {
            return _eliminarClienteAD.EliminarCliente(id);
        }
    }
}
