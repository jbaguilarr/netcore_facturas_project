using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Entities
{
    [Table("ADM_Factura")]
    public class Factura
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("ADM_Cliente")]
        [Column(TypeName = "INT")]
        public int IdCliente { get; set; }
        [Column(TypeName ="DATETIME")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "DECIMAL(18,2)")]
        public decimal Importe { get; set; }
        [Column(TypeName = "INT")]
        public int Nit { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Razon_Social { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string Codigo_Control { get; set; }
        [Column(TypeName = "INT")]
        public int Modo_Pago { get; set; }
        [Column(TypeName = "INT")]
        public int Codigo_Tarjeta { get; set; }
    }
}
