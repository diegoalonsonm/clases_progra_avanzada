using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Modelos
{
    [Table("Inventario")]
    public class InventarioAD
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("codigo_repuesto")]
        public string CodigoDelRepuesto { get; set; }

        [Column("nombre_repuesto")]
        public string NombreDelRepuesto { get; set; }

        [Column("marca_repuesto")]
        public string MarcaDelRepuesto { get; set; }

        [Column("vehiculo")]
        public string Vehiculo { get; set; }

        [Column("modelo")]
        public string Modelo { get; set; }

        [Column("anio")]
        public int Anio { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("fecha_registro")]
        public DateTime FechaDeRegistro { get; set; }

        [Column("fecha_modificacion")]
        public DateTime? FechaDeModificacion { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }
    }
}
