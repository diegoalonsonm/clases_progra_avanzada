using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.ModelosUI
{
    public static class EstadoInventario
    {
        public static bool activo = true;
        public static bool inactivo = false;
    }

    public enum EstadosInventario
    {
        Activo = 1,
        Inactivo = 2,
        Cancelado = 3,
    }
}
