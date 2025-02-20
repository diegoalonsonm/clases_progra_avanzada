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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Contexto>(null);
            modelBuilder.Entity<ClienteAD>().HasKey(c => c.idCliente);
            modelBuilder.Entity<InventarioAD>().HasKey(i => i.Id);
        }

        public DbSet<InventarioAD> inventario { get; set; }
        public DbSet<ClienteAD> cliente { get; set; }

        
    }
}
