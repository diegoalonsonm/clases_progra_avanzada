using Inventario.Abstracciones.AccessoDatos.Cliente.EliminarCliente;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Cliente.EliminarCliente
{
    public class EliminarClienteAD : IEliminarClienteAD
    {
        private Contexto _contexto;

        public EliminarClienteAD()
        {
            _contexto = new Contexto();
        }

        public int EliminarCliente(int id)
        {
            ClienteAD clienteBD = _contexto.cliente.Where(cliente => cliente.idCliente == id).FirstOrDefault();
            _contexto.cliente.Remove(clienteBD);

            return _contexto.SaveChanges();
        }
    }
}
