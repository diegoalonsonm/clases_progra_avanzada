using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Inventario.EliminarInventario
{
    public class EliminarInventarioAD : IEliminarInventarioAD
    {
        private Contexto _contexto;

        public EliminarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public int EliminarInventario(int id)
        {
            InventarioAD inventarioBD = _contexto.inventario.Where(inventario => inventario.Id == id).FirstOrDefault();
            _contexto.inventario.Remove(inventarioBD);

            return _contexto.SaveChanges();
        }
    }
}
