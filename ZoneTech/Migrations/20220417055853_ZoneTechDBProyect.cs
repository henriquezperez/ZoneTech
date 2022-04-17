using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZoneTech.Migrations
{
    public partial class ZoneTechDBProyect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompraTBL",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraTBL", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "DepartamentoTBL",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentoTBL", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTBL",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTBL", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "InventarioTBL",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Existencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioTBL", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "TipoClienteTBL",
                columns: table => new
                {
                    TipoClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoClienteTBL", x => x.TipoClienteId);
                });

            migrationBuilder.CreateTable(
                name: "MunicipioTBL",
                columns: table => new
                {
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipioTBL", x => x.MunicipioId);
                    table.ForeignKey(
                        name: "FK_MunicipioTBL_DepartamentoTBL_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "DepartamentoTBL",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaTBL",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    RutaImagen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaTBL", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_CategoriaTBL_EstadoTBL_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoTBL",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MarcaTBL",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaTBL", x => x.MarcaId);
                    table.ForeignKey(
                        name: "FK_MarcaTBL_EstadoTBL_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoTBL",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarioTBL",
                columns: table => new
                {
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarioTBL", x => x.TipoUsuarioId);
                    table.ForeignKey(
                        name: "FK_TipoUsuarioTBL_EstadoTBL_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoTBL",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTBL",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoClienteId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaImagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTBL", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_UsuarioTBL_EstadoTBL_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoTBL",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsuarioTBL_TipoClienteTBL_TipoClienteId",
                        column: x => x.TipoClienteId,
                        principalTable: "TipoClienteTBL",
                        principalColumn: "TipoClienteId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ModeloTBL",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloTBL", x => x.ModeloId);
                    table.ForeignKey(
                        name: "FK_ModeloTBL_CategoriaTBL_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaTBL",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ModeloTBL_MarcaTBL_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "MarcaTBL",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ClienteTBL",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DUI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TipoClienteId = table.Column<int>(type: "int", nullable: false),
                    Residencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteTBL", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_ClienteTBL_MunicipioTBL_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "MunicipioTBL",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ClienteTBL_TipoClienteTBL_TipoClienteId",
                        column: x => x.TipoClienteId,
                        principalTable: "TipoClienteTBL",
                        principalColumn: "TipoClienteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ClienteTBL_UsuarioTBL_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioTBL",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloTBL",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Garantia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaImagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloTBL", x => x.ArticuloId);
                    table.ForeignKey(
                        name: "FK_ArticuloTBL_CategoriaTBL_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaTBL",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ArticuloTBL_EstadoTBL_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoTBL",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ArticuloTBL_MarcaTBL_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "MarcaTBL",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ArticuloTBL_ModeloTBL_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "ModeloTBL",
                        principalColumn: "ModeloId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VentaTBL",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaTBL", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_VentaTBL_ClienteTBL_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "ClienteTBL",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VentaTBL_UsuarioTBL_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioTBL",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarritoTBL",
                columns: table => new
                {
                    CarritoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoTBL", x => x.CarritoId);
                    table.ForeignKey(
                        name: "FK_CarritoTBL_ArticuloTBL_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "ArticuloTBL",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CarritoTBL_UsuarioTBL_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioTBL",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompraTBL",
                columns: table => new
                {
                    DetalleCompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCompraTBL", x => x.DetalleCompraId);
                    table.ForeignKey(
                        name: "FK_DetalleCompraTBL_ArticuloTBL_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "ArticuloTBL",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetalleCompraTBL_CompraTBL_CompraId",
                        column: x => x.CompraId,
                        principalTable: "CompraTBL",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentaTBL",
                columns: table => new
                {
                    DetalleVentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVentaTBL", x => x.DetalleVentaId);
                    table.ForeignKey(
                        name: "FK_DetalleVentaTBL_ArticuloTBL_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "ArticuloTBL",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetalleVentaTBL_VentaTBL_VentaId",
                        column: x => x.VentaId,
                        principalTable: "VentaTBL",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloTBL_CategoriaId",
                table: "ArticuloTBL",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloTBL_EstadoId",
                table: "ArticuloTBL",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloTBL_MarcaId",
                table: "ArticuloTBL",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloTBL_ModeloId",
                table: "ArticuloTBL",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoTBL_ArticuloId",
                table: "CarritoTBL",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoTBL_UsuarioId",
                table: "CarritoTBL",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaTBL_EstadoId",
                table: "CategoriaTBL",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteTBL_MunicipioId",
                table: "ClienteTBL",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteTBL_TipoClienteId",
                table: "ClienteTBL",
                column: "TipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteTBL_UsuarioId",
                table: "ClienteTBL",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraTBL_ArticuloId",
                table: "DetalleCompraTBL",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraTBL_CompraId",
                table: "DetalleCompraTBL",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentaTBL_ArticuloId",
                table: "DetalleVentaTBL",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentaTBL_VentaId",
                table: "DetalleVentaTBL",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaTBL_EstadoId",
                table: "MarcaTBL",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloTBL_CategoriaId",
                table: "ModeloTBL",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloTBL_MarcaId",
                table: "ModeloTBL",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipioTBL_DepartamentoId",
                table: "MunicipioTBL",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUsuarioTBL_EstadoId",
                table: "TipoUsuarioTBL",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTBL_EstadoId",
                table: "UsuarioTBL",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTBL_TipoClienteId",
                table: "UsuarioTBL",
                column: "TipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaTBL_ClienteId",
                table: "VentaTBL",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaTBL_UsuarioId",
                table: "VentaTBL",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoTBL");

            migrationBuilder.DropTable(
                name: "DetalleCompraTBL");

            migrationBuilder.DropTable(
                name: "DetalleVentaTBL");

            migrationBuilder.DropTable(
                name: "InventarioTBL");

            migrationBuilder.DropTable(
                name: "TipoUsuarioTBL");

            migrationBuilder.DropTable(
                name: "CompraTBL");

            migrationBuilder.DropTable(
                name: "ArticuloTBL");

            migrationBuilder.DropTable(
                name: "VentaTBL");

            migrationBuilder.DropTable(
                name: "ModeloTBL");

            migrationBuilder.DropTable(
                name: "ClienteTBL");

            migrationBuilder.DropTable(
                name: "CategoriaTBL");

            migrationBuilder.DropTable(
                name: "MarcaTBL");

            migrationBuilder.DropTable(
                name: "MunicipioTBL");

            migrationBuilder.DropTable(
                name: "UsuarioTBL");

            migrationBuilder.DropTable(
                name: "DepartamentoTBL");

            migrationBuilder.DropTable(
                name: "EstadoTBL");

            migrationBuilder.DropTable(
                name: "TipoClienteTBL");
        }
    }
}
