using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.AccessoDatos.Cliente.CrearCliente
{
    public interface ICrearClienteAD
    {
        Task<int> crearCliente(ClienteDTO cliente);
    }
}
