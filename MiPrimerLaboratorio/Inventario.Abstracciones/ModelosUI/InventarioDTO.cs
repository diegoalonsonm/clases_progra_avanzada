using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Inventario.Abstracciones.ModelosUI
{
    public class InventarioDTO
    {
        [DisplayName("Código del Repuesto")]
        [MinLength(4)]
        [Required]
        public string CodigoDelRepuesto { get; set; }

        [DisplayName("Nombre del Repuesto")]
        [Required]
        public string NombreDelRepuesto { get; set; }

        [DisplayName("Marca del Repuesto")]
        [Required]
        public string MarcaDelRepuesto { get; set; }

        [DisplayName("Nombre del Vehiculo")]
        [Required]
        public string Vehiculo { get; set; }

        [Required]
        public string Modelo { get; set; }

        [DisplayName("Año")]
        [Required]
        public int Anio { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [DisplayName("Fecha de Registro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }

        [DisplayName("Fecha de Modificacion")]
        [Required]
        public DateTime? FechaDeModificacion { get; set; }

        [Required]
        public bool Estado { get; set; }

        [DisplayName("Imagen del repuesto")]
        [Required]
        public HttpPostedFileBase archivo { get; set; }
    }
}
