using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Cliente.CrearClienteLN
{
    public interface ICrearClienteLN
    {
        Task<int> crearCliente(ClienteDTO cliente);
    }
}
