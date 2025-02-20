using Inventario.Abstracciones;
using Inventario.Abstracciones.AccessoDatos.Inventario.ActualizarInventario;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ActualizarInventarioLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Inventario.ActualizarInventario;
using Inventario.LogicaNegocio.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Inventario.ActualizarInventario
{
    public class ActualizarInventarioLN : IActualizarInventarioLN
    {
        private IActualizarInventarioAD _actualizarInventarioAD;
        private IFecha _fecha;

        public ActualizarInventarioLN()
        {
            _actualizarInventarioAD = new ActualizarInventarioAD();
            _fecha = new Fecha();
        }

        public int ActualizarInventario(InventarioDTO inventarioDTO)
        {
            inventarioDTO.FechaDeModificacion = _fecha.FechaPorZona();

            return _actualizarInventarioAD.ActualizarInventario(inventarioDTO);
        }
    }
}
