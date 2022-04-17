using Microsoft.EntityFrameworkCore;
using ZoneTech.Models;

namespace ZoneTech.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        /*
            Creación de la base de datos (Tablas = NombreTBL)
         */

        public DbSet<EstadoML> EstadoTBL { get; set; }
        public DbSet<TipoClienteML> TipoClienteTBL { get; set; }
        public DbSet<TipoUsuarioML> TipoUsuarioTBL { get; set; }
        public DbSet<UsuarioML> UsuarioTBL { get; set; }
        public DbSet<DepartamentoML> DepartamentoTBL { get; set; }
        public DbSet<MunicipioML> MunicipioTBL { get; set; }
        public DbSet<ClienteML> ClienteTBL { get; set; }
        public DbSet<MarcaML> MarcaTBL { get; set; }
        public DbSet<CategoriaML> CategoriaTBL { get; set; }
        public DbSet<ModeloML> ModeloTBL { get; set; }
        public DbSet<ArticuloML> ArticuloTBL { get; set; }
        public DbSet<CarritoML> CarritoTBL { get; set; }
        public DbSet<VentaML> VentaTBL { get; set; }
        public DbSet<DetalleVentaML> DetalleVentaTBL { get; set; }
        public DbSet<CompraML> CompraTBL { get; set; }
        public DbSet<DetalleCompraML> DetalleCompraTBL { get; set; }
        public DbSet<InventarioML> InventarioTBL { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
