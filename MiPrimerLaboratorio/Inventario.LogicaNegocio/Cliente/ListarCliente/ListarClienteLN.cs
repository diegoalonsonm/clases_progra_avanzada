using Inventario.Abstracciones.AccessoDatos.Cliente.ListarCliente;
using Inventario.Abstracciones.LogicaNegocio.Cliente.ListarClienteLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Cliente.ListarCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Cliente.ListarCliente
{
    public class ListarClienteLN : IListarClienteLN
    {
        private IListarClienteAD _listarClienteAD;

        public ListarClienteLN()
        {
            _listarClienteAD = new ListarClienteAD();
        }

        public List<ClienteDTO> ListarCliente()
        {
            return _listarClienteAD.ListarCliente();
        }
    }
}
