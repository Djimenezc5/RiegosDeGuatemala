using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class TipoSensor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RG_TIPO_SENSOR",
                columns: table => new
                {
                    ID_TIPO_SENSOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE_TIPO_SENSOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESTADO_SENSOR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RG_TIPO_SENSOR", x => x.ID_TIPO_SENSOR);
                });

            migrationBuilder.InsertData(
                table: "RG_TIPO_SENSOR",
                columns: new[] { "ID_TIPO_SENSOR", "ESTADO_SENSOR", "NOMBRE_TIPO_SENSOR" },
                values: new object[] { 1, true, "Sensor humedad" });

            migrationBuilder.InsertData(
                table: "RG_TIPO_SENSOR",
                columns: new[] { "ID_TIPO_SENSOR", "ESTADO_SENSOR", "NOMBRE_TIPO_SENSOR" },
                values: new object[] { 2, true, "Sensor luminosidad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RG_TIPO_SENSOR");
        }
    }
}
