using Inventario.Abstracciones;
using Inventario.Abstracciones.AccessoDatos.Inventario.CrearInventario;
using Inventario.Abstracciones.LogicaNegocio.Inventario.CrearInventarioLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Inventario.CrearInventario;
using Inventario.LogicaNegocio.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Inventario.CrearInventario
{
    public class CrearInventarioLN : ICrearInventarioLN
    {
        private ICrearInventarioAD _crearInventarioAD;
        private IFecha _fecha;

        public CrearInventarioLN()
        {
            _crearInventarioAD = new CrearInventarioAD();
            _fecha = new Fecha();
        }

        public async Task<int> CrearInventario(InventarioDTO inventario)
        {
            inventario.FechaDeRegistro = _fecha.FechaPorZona();
            inventario.Estado = EstadoInventario.activo;
            return await _crearInventarioAD.crearInventario(inventario);
        }
    }
}
