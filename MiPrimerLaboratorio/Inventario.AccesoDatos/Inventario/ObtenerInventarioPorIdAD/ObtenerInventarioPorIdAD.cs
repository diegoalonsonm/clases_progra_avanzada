using Inventario.Abstracciones.AccessoDatos.Inventario.ObtenerInvenstarioPorId;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Inventario.ObtenerInventarioPorIdAD
{
    public class ObtenerInventarioPorIdAD : IObtenerInventarioPorIdAD
    {
        private Contexto _contexto;

        public ObtenerInventarioPorIdAD()
        {
            _contexto = new Contexto();
        }

        public InventarioDTO ObtenerPorId(int id)
        { 
            InventarioDTO listaDTO = (from inventario in _contexto.inventario
                                            where inventario.Id == id
                                            select new InventarioDTO
                                            {
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
                                            }).FirstOrDefault();
            return listaDTO;
        }
    }
}
