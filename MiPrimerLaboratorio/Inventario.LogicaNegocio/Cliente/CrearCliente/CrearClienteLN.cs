using Inventario.Abstracciones;
using Inventario.Abstracciones.AccessoDatos.Cliente.CrearCliente;
using Inventario.Abstracciones.LogicaNegocio.Cliente.CrearClienteLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Cliente.CrearClienteAD;
using Inventario.LogicaNegocio.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Cliente.CrearCliente
{
    public class CrearClienteLN : ICrearClienteLN
    {
        private ICrearClienteAD _crearClienteAD;
        private IFecha _fecha;

        public CrearClienteLN()
        {
            _crearClienteAD = new CrearClienteAD();
            _fecha = new Fecha();
        }

        public async Task<int> crearCliente(ClienteDTO cliente)
        {
            cliente.fechaCreacion = _fecha.FechaPorZona();
            cliente.estado = EstadoInventario.activo;

            return await _crearClienteAD.crearCliente(cliente);
        }
    }
}
