using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        {
        }

        public DbSet<InventarioAD> inventario { get; set; }
    }
}
