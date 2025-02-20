using Inventario.Abstracciones;
using Inventario.Abstracciones.AccessoDatos.Cliente.ActualizarCliente;
using Inventario.Abstracciones.LogicaNegocio.Cliente.ActualizarClienteLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Cliente.ActualizarCliente;
using Inventario.LogicaNegocio.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Cliente.ActualizarCliente
{
    public class ActualizarClienteLN : IActualizarClienteLN
    {
        private IActualizarClienteAD _actualizarClieteAD;
        private IFecha _fecha;

        public ActualizarClienteLN()
        {
            _actualizarClieteAD = new ActualizarClienteAD();
            _fecha = new Fecha();
        }

        public int ActualizarCliente(ClienteDTO cliente)
        {
            cliente.fechaModificacion = _fecha.FechaPorZona();
            
            return _actualizarClieteAD.ActualizarCliente(cliente);
        }
    }
}
