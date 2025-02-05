using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Inventario.ListarInventario
{
    public interface IListarInventarioLN
    {
        List<InventarioDTO> ListarInventario();
    }
}
