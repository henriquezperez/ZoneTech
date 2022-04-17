using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class MunicipioML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MunicipioId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

        [Required]
        
        public int DepartamentoId {get; set;}
        [ForeignKey("DepartamentoId")]
        public DepartamentoML departamento_FK { get; set; }


    }
}
