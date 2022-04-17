using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class CarritoML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoId { get; set; }

        [Required]
        
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public UsuarioML usuario_FK { get; set; }
        
        [Required]
       
        public int ArticuloId {get; set;}
        [ForeignKey("ArticuloId")]
        public ArticuloML articulo_FK { get; set; }

    }
}
