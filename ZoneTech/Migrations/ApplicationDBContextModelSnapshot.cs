// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZoneTech.Data;

#nullable disable

namespace ZoneTech.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZoneTech.Models.ArticuloML", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticuloId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.ToTable("ArticuloTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.CarritoML", b =>
                {
                    b.Property<int>("CarritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarritoId"), 1L, 1);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CarritoId");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CarritoTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.CategoriaML", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"), 1L, 1);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.HasIndex("EstadoId");

                    b.ToTable("CategoriaTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.ClienteML", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DUI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Residencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoClienteId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("TipoClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ClienteTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.CompraML", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompraId"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CompraId");

                    b.ToTable("CompraTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.DepartamentoML", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("DepartamentoTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.DetalleCompraML", b =>
                {
                    b.Property<int>("DetalleCompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleCompraId"), 1L, 1);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DetalleCompraId");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("CompraId");

                    b.ToTable("DetalleCompraTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.DetalleVentaML", b =>
                {
                    b.Property<int>("DetalleVentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleVentaId"), 1L, 1);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleVentaId");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVentaTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.EstadoML", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("EstadoId");

                    b.ToTable("EstadoTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.InventarioML", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"), 1L, 1);

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.HasKey("ArticuloId");

                    b.ToTable("InventarioTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.MarcaML", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"), 1L, 1);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("MarcaId");

                    b.HasIndex("EstadoId");

                    b.ToTable("MarcaTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.ModeloML", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloId"), 1L, 1);

                    b.Property<int?>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MarcaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ModeloId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("ModeloTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.MunicipioML", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MunicipioId"), 1L, 1);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("MunicipioId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("MunicipioTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.TipoClienteML", b =>
                {
                    b.Property<int>("TipoClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoClienteId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("TipoClienteId");

                    b.ToTable("TipoClienteTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.TipoUsuarioML", b =>
                {
                    b.Property<int>("TipoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoUsuarioId"), 1L, 1);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("TipoUsuarioId");

                    b.HasIndex("EstadoId");

                    b.ToTable("TipoUsuarioTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.UsuarioML", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoClienteId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TipoClienteId");

                    b.ToTable("UsuarioTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.VentaML", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VentaId"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("VentaTBL");
                });

            modelBuilder.Entity("ZoneTech.Models.ArticuloML", b =>
                {
                    b.HasOne("ZoneTech.Models.CategoriaML", "categoria_FK")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.EstadoML", "estado_FK")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.MarcaML", "marca_FK")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.ModeloML", "modelo_FK")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria_FK");

                    b.Navigation("estado_FK");

                    b.Navigation("marca_FK");

                    b.Navigation("modelo_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.CarritoML", b =>
                {
                    b.HasOne("ZoneTech.Models.ArticuloML", "articulo_FK")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.UsuarioML", "usuario_FK")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("articulo_FK");

                    b.Navigation("usuario_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.CategoriaML", b =>
                {
                    b.HasOne("ZoneTech.Models.EstadoML", "estado_FK")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.ClienteML", b =>
                {
                    b.HasOne("ZoneTech.Models.MunicipioML", "municipio_FK")
                        .WithMany()
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.TipoClienteML", "tipoCliente_FK")
                        .WithMany()
                        .HasForeignKey("TipoClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.UsuarioML", "usuario_FK")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("municipio_FK");

                    b.Navigation("tipoCliente_FK");

                    b.Navigation("usuario_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.DetalleCompraML", b =>
                {
                    b.HasOne("ZoneTech.Models.ArticuloML", "articulo_FK")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.CompraML", "compra_FK")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("articulo_FK");

                    b.Navigation("compra_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.DetalleVentaML", b =>
                {
                    b.HasOne("ZoneTech.Models.ArticuloML", "articulo_FK")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.VentaML", "venta_FK")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("articulo_FK");

                    b.Navigation("venta_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.MarcaML", b =>
                {
                    b.HasOne("ZoneTech.Models.EstadoML", "estado_FK")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.ModeloML", b =>
                {
                    b.HasOne("ZoneTech.Models.CategoriaML", "categoria_FK")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.MarcaML", "marca_FK")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria_FK");

                    b.Navigation("marca_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.MunicipioML", b =>
                {
                    b.HasOne("ZoneTech.Models.DepartamentoML", "departamento_FK")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("departamento_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.TipoUsuarioML", b =>
                {
                    b.HasOne("ZoneTech.Models.EstadoML", "estado_FK")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.UsuarioML", b =>
                {
                    b.HasOne("ZoneTech.Models.EstadoML", "estado_FK")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.TipoClienteML", "tipoCliente_FK")
                        .WithMany()
                        .HasForeignKey("TipoClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado_FK");

                    b.Navigation("tipoCliente_FK");
                });

            modelBuilder.Entity("ZoneTech.Models.VentaML", b =>
                {
                    b.HasOne("ZoneTech.Models.ClienteML", "cliente_FK")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZoneTech.Models.UsuarioML", "usuario_FK")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente_FK");

                    b.Navigation("usuario_FK");
                });
#pragma warning restore 612, 618
        }
    }
}
