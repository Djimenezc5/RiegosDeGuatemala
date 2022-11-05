using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class NuevosCamposLecturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LUMINOSIDAD _MAXIMA",
                table: "RG_SECTOR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LUMINOSIDAD _MINIMA",
                table: "RG_SECTOR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "ULTIMO_HISTORIAL",
                table: "RG_HISTORICO_SECTOR",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ULTIMO_HISTORIAL",
                table: "RG_HISTORIAL_SENSOR",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LUMINOSIDAD _MAXIMA",
                table: "RG_SECTOR");

            migrationBuilder.DropColumn(
                name: "LUMINOSIDAD _MINIMA",
                table: "RG_SECTOR");

            migrationBuilder.DropColumn(
                name: "ULTIMO_HISTORIAL",
                table: "RG_HISTORICO_SECTOR");

            migrationBuilder.DropColumn(
                name: "ULTIMO_HISTORIAL",
                table: "RG_HISTORIAL_SENSOR");
        }
    }
}
