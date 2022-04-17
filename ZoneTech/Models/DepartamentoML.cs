using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class DepartamentoML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartamentoId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

    }
}
