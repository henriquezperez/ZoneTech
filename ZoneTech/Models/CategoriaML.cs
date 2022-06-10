using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class CategoriaML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

        [Required]

        public int EstadoId { get; set; }
        [ForeignKey("EstadoId")]
        public EstadoML estado_FK { get; set; }

        [Required]

        public string RutaImagen { get; set; }

    }
}
