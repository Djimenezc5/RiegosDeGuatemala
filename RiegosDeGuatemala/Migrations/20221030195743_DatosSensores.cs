using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class DatosSensores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RG_HISTORIAL_SENSOR",
                columns: table => new
                {
                    ID_HISTORIAL_SENSOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RG_ID_SENSOR = table.Column<int>(type: "int", nullable: false),
                    MEDIDA_SENSOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FECHA_MEDIDA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_HISTORIAL_SENSOR", x => x.ID_HISTORIAL_SENSOR);
                });

            migrationBuilder.CreateTable(
                name: "RG_SENSORES",
                columns: table => new
                {
                    ID_SENSOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_SENSOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_TIPO_SENSOR = table.Column<int>(type: "int", nullable: false),
                    ESTADO_SENSOR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_SENSORES", x => x.ID_SENSOR);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RG_HISTORIAL_SENSOR");

            migrationBuilder.DropTable(
                name: "RG_SENSORES");
        }
    }
}
