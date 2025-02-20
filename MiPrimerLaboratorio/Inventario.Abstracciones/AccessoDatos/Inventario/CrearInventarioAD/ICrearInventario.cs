using Inventario.Abstracciones.ModelosUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.AccessoDatos.Inventario.CrearInventario
{
    public interface ICrearInventarioAD
    {
        Task<int> crearInventario(InventarioDTO inventario);
    }
}
