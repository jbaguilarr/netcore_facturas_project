using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Entities
{
    [Table("ADM_Cliente")]
    public class Cliente : Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }


        [Column(TypeName = "VARCHAR(150)")]
        public string Apellidos { get; set; }


        [Column(TypeName = "DATETIME")]
        public DateTime FechaNaciemiento { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        public string Email { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        public string Telefono { get; set; }


        [Column(TypeName = "VARCHAR(MAX)")]
        public NetCore.ValueObject.Direccion Direccion { get; set; }
    }
}
