using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Inventario.ActualizarInventarioLN
{
    public interface IActualizarInventarioLN
    {
        int ActualizarInventario(InventarioDTO inventarioParam);
    }
}
