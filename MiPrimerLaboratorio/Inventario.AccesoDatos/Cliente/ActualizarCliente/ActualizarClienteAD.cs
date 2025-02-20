using Inventario.Abstracciones.AccessoDatos.Cliente.ActualizarCliente;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Cliente.ActualizarCliente
{
    public class ActualizarClienteAD : IActualizarClienteAD
    {
        private Contexto contexto;

        public ActualizarClienteAD()
        {
            contexto = new Contexto();
        }

        public int ActualizarCliente(ClienteDTO clienteParam)
        {
            ClienteAD clienteBD = contexto.cliente.Where(cliente => cliente.idCliente == clienteParam.idCliente).FirstOrDefault();
            clienteBD.nombre = clienteParam.nombre;
            clienteBD.primerApellido = clienteParam.primerApellido;
            clienteBD.segundoApellido = clienteParam.segundoApellido;
            return contexto.SaveChanges();
        }
    }
}
