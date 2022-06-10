using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class VentaML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }

        [Required]
        public string NumFactura { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public UsuarioML usuario_FK { get; set; }

        [Required]

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public ClienteML cliente_FK { get; set; }


    }
}
