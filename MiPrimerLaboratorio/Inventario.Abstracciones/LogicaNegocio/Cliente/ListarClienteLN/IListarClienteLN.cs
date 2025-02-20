using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Cliente.ListarClienteLN
{
    public interface IListarClienteLN
    {
        List<ClienteDTO> ListarCliente();
    }
}
