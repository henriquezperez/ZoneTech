using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class UsuarioML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Required]
        
        public int TipoClienteId { get; set; }
        [ForeignKey("TipoClienteId")]
        public TipoClienteML tipoCliente_FK { get; set; }

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        public string Clave {get; set;}

        [Required]
        public string RutaImagen {get; set;}

        [Required]
        
        public int EstadoId {get; set;}
        [ForeignKey("EstadoId")]
        public EstadoML estado_FK { get; set; }
    }
}
