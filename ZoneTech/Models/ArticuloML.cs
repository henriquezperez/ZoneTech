using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class ArticuloML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticuloId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        
        [Required]
        
        public int MarcaId {get; set;}

        [ForeignKey("MarcaId")]
        public MarcaML marca_FK { get; set; }

        [Required]
        
        public int CategoriaId {get; set;}
        [ForeignKey("CategoriaId")]
        public CategoriaML categoria_FK { get; set; }

        [Required]
        
        public int ModeloId {get; set;}
        [ForeignKey("ModeloId")]
        public ModeloML modelo_FK { get; set; }

        [Required]
        public string Descripcion {get; set;}

        [Required]
        public decimal Costo {get; set;}

        [Required]
        public decimal Precio {get; set;}

        [Required]
        public string Garantia {get; set;}

        [Required]
        public string RutaImagen {get; set;}

        [Required]
        
        public int EstadoId {get; set;}
        [ForeignKey("EstadoId")]
        public EstadoML estado_FK { get; set; }

    }
}
