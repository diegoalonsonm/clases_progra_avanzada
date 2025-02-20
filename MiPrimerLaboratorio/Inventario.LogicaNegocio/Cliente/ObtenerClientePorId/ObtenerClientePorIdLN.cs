using Inventario.Abstracciones.AccessoDatos.Cliente.ObtenerClientePorId;
using Inventario.Abstracciones.LogicaNegocio.Cliente.ObtenerClientePorIdLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Cliente.ObtenerClientePorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Cliente.ObtenerClientePorId
{
    public class ObtenerClientePorIdLN : IObtenerClientePorIdLN
    {
        private IObtenerClientePorIdAD _listarCliente;

        public ObtenerClientePorIdLN()
        {
            _listarCliente = new ObtenerClientePorIdAD();
        }

        public ClienteDTO ObtenerPorId(int id)
        {
            return _listarCliente.ObtenerPorId(id);
        }
    }
}
