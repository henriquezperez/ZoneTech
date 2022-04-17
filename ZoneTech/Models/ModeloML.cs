using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class ModeloML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModeloId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        
        [Required]
        public int? MarcaId {get; set;}
        [ForeignKey("MarcaId")]
        public MarcaML marca_FK {get; set;}

        [Required]
        public int? CategoriaId {get; set;}
        [ForeignKey("CategoriaId")]
        public CategoriaML categoria_FK {get; set; }

    }
}
