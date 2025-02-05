using Inventario.Abstracciones.AccessoDatos.Inventario;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.ModelosUI;
using Inventario.AccesoDatos.Inventario.ListarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.LogicaNegocio.Inventario.ListarInventario
{
    public class ListarInventarioLN : IListarInventarioLN
    {
        private IListarInventarioAD _listarInventarioAD;
        public ListarInventarioLN() {
            _listarInventarioAD = new ListarInventarioAD();
        }

        public List<InventarioDTO> ListarInventario()
        {
            //List<InventarioDTO> inventario = new List<InventarioDTO>();
            //inventario.Add(ObtenerObjeto());
            
            List<InventarioDTO> inventario = _listarInventarioAD.ListarInventario();
            return inventario;
        }

        private InventarioDTO ObtenerObjeto()
        {
            return new InventarioDTO
            {
                CodigoDelRepuesto = "123",
                NombreDelRepuesto = "Llanta",
                MarcaDelRepuesto = "Michelin",
                Vehiculo = "Toyota",
                Modelo = "Corolla",
                Anio = 2018,
                Cantidad = 4,
                FechaDeRegistro = DateTime.Now,
                FechaDeModificacion = DateTime.Now,
                Estado = true
            };
        }
    }
}
