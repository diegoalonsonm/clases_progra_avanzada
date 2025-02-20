using Inventario.Abstracciones.AccessoDatos.Cliente.CrearCliente;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Cliente.CrearClienteAD
{
    public class CrearClienteAD : ICrearClienteAD
    {
        private Contexto _contexto;

        public CrearClienteAD()
        {
            _contexto = new Contexto();
        }

        public async Task<int> crearCliente(ClienteDTO cliente)
        {
            _contexto.cliente.Add(convertirAD(cliente));
            return await _contexto.SaveChangesAsync();
        }

        public ClienteAD convertirAD(ClienteDTO cliente)
        {
            return new ClienteAD
            {
                idCliente = cliente.idCliente,
                nombre = cliente.nombre,
                primerApellido = cliente.primerApellido,
                segundoApellido = cliente.segundoApellido,
                telefono = cliente.telefono,
                correo = cliente.correo,
                fechaCreacion = cliente.fechaCreacion,
                fechaModificacion = cliente.fechaModificacion,
                estado = cliente.estado
            };
        }
    }
}
