using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class DetalleCompraML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleCompraId { get; set; }


        [Required]

        public int CompraId { get; set; }
        [ForeignKey("CompraId")]
        public CompraML compra_FK { get; set; }

        [Required]

        public int ArticuloId { get; set; }
        [ForeignKey("ArticuloId")]
        public ArticuloML articulo_FK {get; set;}

        [Required]
        public int Cantidad {get; set;}

        [Required]
        public decimal PrecioUnitario {get; set;}

        [Required]
        public decimal SubTotal {get; set;}

    }
}
