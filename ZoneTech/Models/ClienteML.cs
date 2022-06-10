using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoneTech.Models
{
    public class ClienteML
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(8)]
        public string DUI { get; set; }

        [Required]

        public int TipoClienteId { get; set; }
        [ForeignKey("TipoClienteId")]
        public TipoClienteML tipoCliente_FK { get; set; }

        [Required]
        public string Residencia { get; set; }

        [Required]

        public int MunicipioId { get; set; }
        [ForeignKey("MunicipioId")]
        public MunicipioML municipio_FK { get; set; }

        //no requerido
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public UsuarioML usuario_FK { get; set; }

    }
}
