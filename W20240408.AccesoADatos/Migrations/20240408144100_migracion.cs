using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W20240408.AccesoADatos.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimientoW = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoW = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusW = table.Column<byte>(type: "tinyint", nullable: false),
                    ComentarioW = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
