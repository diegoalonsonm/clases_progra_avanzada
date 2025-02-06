using Inventario.Abstracciones.AccessoDatos.Inventario.ActualizarInventario;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Inventario.ActualizarInventario
{
    public class ActualizarInventarioAD : IActualizarInventarioAD
    {
        private Contexto _contexto;

        public ActualizarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public int ActualizarInventario(InventarioDTO inventarioParam)
        {
            InventarioAD inventarioBD = _contexto.inventario.Where(inventario => inventario.Id == inventarioParam.Id).FirstOrDefault();
            inventarioBD.CodigoDelRepuesto = inventarioParam.CodigoDelRepuesto;
            inventarioBD.NombreDelRepuesto = inventarioParam.NombreDelRepuesto;

            return _contexto.SaveChanges();
        }
    }
}
