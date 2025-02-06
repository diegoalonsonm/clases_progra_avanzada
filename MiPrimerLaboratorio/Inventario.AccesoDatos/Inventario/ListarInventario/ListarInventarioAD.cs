using Inventario.Abstracciones.AccessoDatos.Inventario;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Inventario.ListarInventario
{
    public class ListarInventarioAD : IListarInventarioAD
    {
        private Contexto _contexto;

        public ListarInventarioAD()
        {
            _contexto = new Contexto();
        }

        public List<InventarioDTO> ListarInventario()
        {
            List<InventarioAD> listaBD = _contexto.inventario.ToList();
            List<InventarioDTO> listaDTO = (from inventario in _contexto.inventario select new InventarioDTO {
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
            }).ToList();
            return listaDTO;
        }       
    }
}
