using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.LogicaNegocio.Inventario.CrearInventarioLN
{
    public interface ICrearInventarioLN
    {
        Task<int> CrearInventario(InventarioDTO inventario);
    }
}
