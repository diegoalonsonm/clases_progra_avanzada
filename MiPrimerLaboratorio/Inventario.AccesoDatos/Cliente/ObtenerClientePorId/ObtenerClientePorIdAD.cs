using Inventario.Abstracciones.AccessoDatos.Cliente.ObtenerClientePorId;
using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Cliente.ObtenerClientePorId
{
    public class ObtenerClientePorIdAD : IObtenerClientePorIdAD
    {
        private Contexto _contexto;
        public ObtenerClientePorIdAD()
        {
            _contexto = new Contexto();
        }
        public ClienteDTO ObtenerPorId(int id)
        {
            ClienteDTO listaDTO = (from cliente in _contexto.cliente where cliente.idCliente == id
                                   select new ClienteDTO
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
                                   }).FirstOrDefault();
            return listaDTO;
        }
    }
}
