using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RG_HISTORICO_SECTOR",
                columns: table => new
                {
                    ID_HISTORICO_SECTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SECTOR = table.Column<int>(type: "int", nullable: false),
                    TIEMPO_RIEGO = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD_AGUA = table.Column<int>(type: "int", nullable: false),
                    FECHA_ULTIMA_ACCION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ESTADO_RIEGO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_HISTORICO_SECTOR", x => x.ID_HISTORICO_SECTOR);
                });

            migrationBuilder.CreateTable(
                name: "RG_SECTOR",
                columns: table => new
                {
                    ID_SECTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE_SECTOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HUMEDAD_MINIMA = table.Column<decimal>(name: "HUMEDAD _MINIMA", type: "decimal(18,2)", nullable: false),
                    HUMEDAD_MAXIMA = table.Column<decimal>(name: "HUMEDAD _MAXIMA", type: "decimal(18,2)", nullable: false),
                    TIEMPO_MAXIMA = table.Column<int>(type: "int", nullable: false),
                    RIEGO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    FECHA_ULTIMO_RIEGO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUARIO_CREACION = table.Column<int>(type: "int", nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_SECTOR", x => x.ID_SECTOR);
                });

            migrationBuilder.CreateTable(
                name: "RG_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTRASENIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false),
                    FECHA_CREACION_USUARIO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "RG_USUARIO_TOKEN",
                columns: table => new
                {
                    ID_USUARIO_TOKEN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    TOKEN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FECHA_CREACION_TOKEN = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_USUARIO_TOKEN", x => x.ID_USUARIO_TOKEN);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RG_HISTORICO_SECTOR");

            migrationBuilder.DropTable(
                name: "RG_SECTOR");

            migrationBuilder.DropTable(
                name: "RG_USUARIO");

            migrationBuilder.DropTable(
                name: "RG_USUARIO_TOKEN");
        }
    }
}
