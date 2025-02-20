using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.AccesoDatos.Modelos
{
    [Table("cliente")]
    public class ClienteAD
    {

        [Column("idCliente")]
        [Key]
        public int idCliente { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("primerApellido")]
        public string primerApellido { get; set; }

        [Column("segundoApellido")]
        public string segundoApellido { get; set; }

        [Column("cedula")]
        public string cedula { get; set; }

        [Column("correo")]
        public string correo { get; set; }

        [Column("telefono")]
        public string telefono { get; set; }

        [Column("fechaCreacion")]
        public DateTime fechaCreacion { get; set; }

        [Column("fechaModificacion")]
        public DateTime? fechaModificacion { get; set; }

        [Column("estado")]
        public bool estado { get; set; }
    }
}
