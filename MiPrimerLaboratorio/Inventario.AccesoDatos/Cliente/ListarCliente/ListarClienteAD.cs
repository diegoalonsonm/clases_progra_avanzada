using Inventario.Abstracciones.AccessoDatos.Cliente.ListarCliente;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Cliente.ListarCliente
{
    public class ListarClienteAD : IListarClienteAD
    {
        private Contexto _contexto;

        public ListarClienteAD()
        {
            _contexto = new Contexto();
        }

        public List<ClienteDTO> ListarCliente()
        {
            List<ClienteAD> listaBD = _contexto.cliente.ToList();
            List<ClienteDTO> listaDTO = (from cliente in _contexto.cliente
                                         select new ClienteDTO
                                         {
                                             idCliente = cliente.idCliente,
                                             nombre = cliente.nombre,
                                             primerApellido = cliente.primerApellido,
                                             segundoApellido = cliente.segundoApellido,
                                             cedula = cliente.cedula,
                                             telefono = cliente.telefono,
                                             correo = cliente.correo,
                                             fechaCreacion = cliente.fechaCreacion,
                                             fechaModificacion = cliente.fechaModificacion,
                                             estado = cliente.estado
                                         }).ToList();
            return listaDTO;
        }
    }
}
