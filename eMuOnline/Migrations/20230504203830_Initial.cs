using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMuOnline.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    IdPersonaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagenURLPersonaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCortoPersonaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreFullPersonaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiografiaPersonaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.IdPersonaje);
                });

            migrationBuilder.CreateTable(
                name: "ItemProductos",
                columns: table => new
                {
                    IdItemProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreItemProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioItemProducto = table.Column<double>(type: "float", nullable: false),
                    DescripcionItemProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenItemProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateItem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateItem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemProductos", x => x.IdItemProducto);
                    table.ForeignKey(
                        name: "FK_ItemProductos_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemProductos_Personajes",
                columns: table => new
                {
                    IdItemProducto = table.Column<int>(type: "int", nullable: false),
                    IdPersonaje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemProductos_Personajes", x => new { x.IdPersonaje, x.IdItemProducto });
                    table.ForeignKey(
                        name: "FK_ItemProductos_Personajes_ItemProductos_IdItemProducto",
                        column: x => x.IdItemProducto,
                        principalTable: "ItemProductos",
                        principalColumn: "IdItemProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemProductos_Personajes_Personajes_IdPersonaje",
                        column: x => x.IdPersonaje,
                        principalTable: "Personajes",
                        principalColumn: "IdPersonaje",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemProductos_IdCategoria",
                table: "ItemProductos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ItemProductos_Personajes_IdItemProducto",
                table: "ItemProductos_Personajes",
                column: "IdItemProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemProductos_Personajes");

            migrationBuilder.DropTable(
                name: "ItemProductos");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
