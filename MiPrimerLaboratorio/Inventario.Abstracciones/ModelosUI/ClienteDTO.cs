using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Abstracciones.ModelosUI
{
    public class ClienteDTO
    {
        public int idCliente { get; set; }

        [DisplayName("Nombre")]        
        [Required]
        public string nombre { get; set; }

        [DisplayName("Primer Apellido")]
        [Required]
        public string primerApellido { get; set; }

        [DisplayName("Segundo Apellido")]
        [Required]
        public string segundoApellido { get; set; }

        [DisplayName("Núm. Cédula")]
        [MinLength(9)]
        [Required]
        public string cedula { get; set; }

        [DisplayName("Correo electrónico")]
        [Required]
        public string correo { get; set; }

        [DisplayName("Teléfono")]
        [Required]
        public string telefono { get; set; }

        public DateTime fechaCreacion { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [DisplayName("Estado")]
        [Required]
        public bool estado { get; set; }
    }   
}
