using Inventario.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.General
{
    public class Fecha : IFecha
    {
        public DateTime FechaPorZona()
        {
            int zonaHoraria = -6;
            return DateTime.UtcNow.AddHours(zonaHoraria);
        }
    }
}
