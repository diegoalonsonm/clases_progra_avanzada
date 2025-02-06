using Inventario.Abstracciones.AccessoDatos.Inventario.CrearInventario;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Inventario.CrearInventario
{
    public class CrearInventarioAD : ICrearInventarioAD
    {
        private Contexto _contexto;
        
        public CrearInventarioAD()
        {
            _contexto = new Contexto();
        }

        public async Task<int> crearInventario(InventarioDTO inventario)
        {
            //_contexto.Database.ExecuteSqlCommand("exec proced @parametro1, @parametro2");

            _contexto.inventario.Add(convertirAD(inventario));

            return await _contexto.SaveChangesAsync();       
        }

        private InventarioAD convertirAD(InventarioDTO inventario)
        {
            return new InventarioAD
            {
                Id = inventario.Id,
                CodigoDelRepuesto = inventario.CodigoDelRepuesto,
                NombreDelRepuesto = inventario.NombreDelRepuesto,
                MarcaDelRepuesto = inventario.MarcaDelRepuesto,
                Vehiculo = inventario.Vehiculo,
                Modelo = inventario.Modelo,
                Anio = inventario.Anio,
                Cantidad = inventario.Cantidad,
                FechaDeRegistro = inventario.FechaDeRegistro,
                FechaDeModificacion = inventario.FechaDeModificacion,
                Estado = inventario.Estado
            };
        }
    }
}
