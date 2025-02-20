using Inventario.Abstracciones.AccessoDatos.Inventario;
using Inventario.Abstracciones.AccessoDatos.Inventario.ObtenerInvenstarioPorId;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ObtenerInventarioIdLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Inventario.ListarInventario;
using Inventario.AccesoDatos.Inventario.ObtenerInventarioPorIdAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Inventario.ObtenerInventarioId
{
    public class ObtenerInventarioIdLN : IObtenerInventarioIdLN
    {
        private IObtenerInventarioPorIdAD _listarInventarioIdAD;
        public ObtenerInventarioIdLN()
        {
            _listarInventarioIdAD = new ObtenerInventarioPorIdAD();
        }

        public InventarioDTO ListarInventario(int id)
        {
            InventarioDTO inventario = _listarInventarioIdAD.ObtenerPorId(id);
            return inventario;
        }
    }
}
