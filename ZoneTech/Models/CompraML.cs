using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class CompraML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompraId { get; set; }

        [Required]
        public string NumFactura { get; set; }
        
        [Required]
        public DateTime Fecha {get; set;}
        
        [Required]
        public decimal Total {get; set;}

        //[Required]
        //[ForeignKey("TipoUsuarioML")]
        //public int TipoUsuarioId {get; set;}

    }
}
