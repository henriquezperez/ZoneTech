using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class TipoClienteML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoClienteId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

    }
}
