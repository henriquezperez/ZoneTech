using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class EstadoML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstadoId { get; set; }
        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
    }
}
