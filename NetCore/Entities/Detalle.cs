using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Entities
{
    [Table("ADM_Detalle")]
    public class Detalle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("ADM_Factura")]
        [Column(TypeName = "INT")]
        public int IdFactura { get; set; }
        [ForeignKey("ADM_Producto")]
        [Column(TypeName = "INT")]
        public int IdProducto { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "INT")]
        public int Cantidad { get; set; }
    }
}
