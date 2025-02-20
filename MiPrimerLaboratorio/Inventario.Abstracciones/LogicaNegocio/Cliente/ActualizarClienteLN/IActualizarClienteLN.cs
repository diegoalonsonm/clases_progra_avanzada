using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Cliente.ActualizarClienteLN
{
    public interface IActualizarClienteLN
    {
        int ActualizarCliente(ClienteDTO clienteParam);
    }
}
