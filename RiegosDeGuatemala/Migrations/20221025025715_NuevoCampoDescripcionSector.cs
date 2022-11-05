using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class NuevoCampoDescripcionSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCION_SECTOR",
                table: "RG_SECTOR",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPCION_SECTOR",
                table: "RG_SECTOR");
        }
    }
}
