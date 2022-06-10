using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class DetalleVentaML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }

        [Required]

        public int VentaId { get; set; }
        [ForeignKey("VentaId")]
        public VentaML venta_FK { get; set; }

        [Required]

        public int ArticuloId { get; set; }
        [ForeignKey("ArticuloId")]
        public ArticuloML articulo_FK { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

    }
}
