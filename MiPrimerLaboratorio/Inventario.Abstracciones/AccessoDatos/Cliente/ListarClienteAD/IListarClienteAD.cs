using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.AccessoDatos.Cliente.ListarCliente
{
    public interface IListarClienteAD
    {
        List<ClienteDTO> ListarCliente();
    }
}
