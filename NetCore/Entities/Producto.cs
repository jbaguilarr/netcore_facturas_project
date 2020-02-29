using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Entities
{
    [Table("ADM_Producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Stock { get; set; }
    }
}
