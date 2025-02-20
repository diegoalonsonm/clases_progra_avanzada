using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.AccessoDatos.Cliente.EliminarCliente
{
    public interface IEliminarClienteAD
    {
        int EliminarCliente(int id);
    }
}
