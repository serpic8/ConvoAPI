using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clase3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producto = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clase3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clase4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clase4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clase2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Venta = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clase3_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clase2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clase2_clase3_Clase3_ID",
                        column: x => x.Clase3_ID,
                        principalTable: "clase3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clase1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clase2_ID = table.Column<int>(type: "int", nullable: false),
                    Clase4_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clase1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clase1_clase2_Clase2_ID",
                        column: x => x.Clase2_ID,
                        principalTable: "clase2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clase1_clase4_Clase4_ID",
                        column: x => x.Clase4_ID,
                        principalTable: "clase4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clase1_Clase2_ID",
                table: "clase1",
                column: "Clase2_ID");

            migrationBuilder.CreateIndex(
                name: "IX_clase1_Clase4_ID",
                table: "clase1",
                column: "Clase4_ID");

            migrationBuilder.CreateIndex(
                name: "IX_clase2_Clase3_ID",
                table: "clase2",
                column: "Clase3_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clase1");

            migrationBuilder.DropTable(
                name: "clase2");

            migrationBuilder.DropTable(
                name: "clase4");

            migrationBuilder.DropTable(
                name: "clase3");
        }
    }
}
