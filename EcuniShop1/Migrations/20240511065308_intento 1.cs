using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcuniShop1.Migrations
{
    /// <inheritdoc />
    public partial class intento1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    IdUbicacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescuentoUbicacion = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.IdUbicacion);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo",
                columns: table => new
                {
                    IdCatalogo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiltroBusqueda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    ListaProductoIdProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo", x => x.IdCatalogo);
                    table.ForeignKey(
                        name: "FK_Catalogo_Producto_ListaProductoIdProducto",
                        column: x => x.ListaProductoIdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    IdEstudiante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Membresia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUbicacion = table.Column<int>(type: "int", nullable: true),
                    UbicacionEstudianteIdUbicacion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.IdEstudiante);
                    table.ForeignKey(
                        name: "FK_Estudiante_Ubicacion_UbicacionEstudianteIdUbicacion",
                        column: x => x.UbicacionEstudianteIdUbicacion,
                        principalTable: "Ubicacion",
                        principalColumn: "IdUbicacion");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetodoPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descuento = table.Column<float>(type: "real", nullable: false),
                    IdEstudiante = table.Column<int>(type: "int", nullable: true),
                    EspecificacionEstudianteIdEstudiante = table.Column<int>(type: "int", nullable: true),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    EspecificacionProductoIdProducto = table.Column<int>(type: "int", nullable: true),
                    IdUbicacion = table.Column<int>(type: "int", nullable: true),
                    UbicacionIdUbicacion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Compra_Estudiante_EspecificacionEstudianteIdEstudiante",
                        column: x => x.EspecificacionEstudianteIdEstudiante,
                        principalTable: "Estudiante",
                        principalColumn: "IdEstudiante");
                    table.ForeignKey(
                        name: "FK_Compra_Producto_EspecificacionProductoIdProducto",
                        column: x => x.EspecificacionProductoIdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                    table.ForeignKey(
                        name: "FK_Compra_Ubicacion_UbicacionIdUbicacion",
                        column: x => x.UbicacionIdUbicacion,
                        principalTable: "Ubicacion",
                        principalColumn: "IdUbicacion");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catalogo_ListaProductoIdProducto",
                table: "Catalogo",
                column: "ListaProductoIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EspecificacionEstudianteIdEstudiante",
                table: "Compra",
                column: "EspecificacionEstudianteIdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EspecificacionProductoIdProducto",
                table: "Compra",
                column: "EspecificacionProductoIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_UbicacionIdUbicacion",
                table: "Compra",
                column: "UbicacionIdUbicacion");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_UbicacionEstudianteIdUbicacion",
                table: "Estudiante",
                column: "UbicacionEstudianteIdUbicacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogo");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Ubicacion");
        }
    }
}
