using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class LlavesTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RG_USUARIO_TOKEN_ID_USUARIO",
                table: "RG_USUARIO_TOKEN",
                column: "ID_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_RG_SENSORES_ID_TIPO_SENSOR",
                table: "RG_SENSORES",
                column: "ID_TIPO_SENSOR");

            migrationBuilder.CreateIndex(
                name: "IX_RG_SENSORES_ID_USUARIO_CREACION",
                table: "RG_SENSORES",
                column: "ID_USUARIO_CREACION");

            migrationBuilder.CreateIndex(
                name: "IX_RG_SECTOR_USUARIO_CREACION",
                table: "RG_SECTOR",
                column: "USUARIO_CREACION");

            migrationBuilder.CreateIndex(
                name: "IX_RG_HISTORICO_SECTOR_ID_SECTOR",
                table: "RG_HISTORICO_SECTOR",
                column: "ID_SECTOR");

            migrationBuilder.CreateIndex(
                name: "IX_RG_HISTORIAL_SENSOR_RG_ID_SENSOR",
                table: "RG_HISTORIAL_SENSOR",
                column: "RG_ID_SENSOR");

            migrationBuilder.AddForeignKey(
                name: "FK_RG_HISTORIAL_SENSOR_RG_SENSORES_RG_ID_SENSOR",
                table: "RG_HISTORIAL_SENSOR",
                column: "RG_ID_SENSOR",
                principalTable: "RG_SENSORES",
                principalColumn: "ID_SENSOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RG_HISTORICO_SECTOR_RG_SECTOR_ID_SECTOR",
                table: "RG_HISTORICO_SECTOR",
                column: "ID_SECTOR",
                principalTable: "RG_SECTOR",
                principalColumn: "ID_SECTOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RG_SECTOR_RG_USUARIO_USUARIO_CREACION",
                table: "RG_SECTOR",
                column: "USUARIO_CREACION",
                principalTable: "RG_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RG_SENSORES_RG_TIPO_SENSOR_ID_TIPO_SENSOR",
                table: "RG_SENSORES",
                column: "ID_TIPO_SENSOR",
                principalTable: "RG_TIPO_SENSOR",
                principalColumn: "ID_TIPO_SENSOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RG_SENSORES_RG_USUARIO_ID_USUARIO_CREACION",
                table: "RG_SENSORES",
                column: "ID_USUARIO_CREACION",
                principalTable: "RG_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RG_USUARIO_TOKEN_RG_USUARIO_ID_USUARIO",
                table: "RG_USUARIO_TOKEN",
                column: "ID_USUARIO",
                principalTable: "RG_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RG_HISTORIAL_SENSOR_RG_SENSORES_RG_ID_SENSOR",
                table: "RG_HISTORIAL_SENSOR");

            migrationBuilder.DropForeignKey(
                name: "FK_RG_HISTORICO_SECTOR_RG_SECTOR_ID_SECTOR",
                table: "RG_HISTORICO_SECTOR");

            migrationBuilder.DropForeignKey(
                name: "FK_RG_SECTOR_RG_USUARIO_USUARIO_CREACION",
                table: "RG_SECTOR");

            migrationBuilder.DropForeignKey(
                name: "FK_RG_SENSORES_RG_TIPO_SENSOR_ID_TIPO_SENSOR",
                table: "RG_SENSORES");

            migrationBuilder.DropForeignKey(
                name: "FK_RG_SENSORES_RG_USUARIO_ID_USUARIO_CREACION",
                table: "RG_SENSORES");

            migrationBuilder.DropForeignKey(
                name: "FK_RG_USUARIO_TOKEN_RG_USUARIO_ID_USUARIO",
                table: "RG_USUARIO_TOKEN");

            migrationBuilder.DropIndex(
                name: "IX_RG_USUARIO_TOKEN_ID_USUARIO",
                table: "RG_USUARIO_TOKEN");

            migrationBuilder.DropIndex(
                name: "IX_RG_SENSORES_ID_TIPO_SENSOR",
                table: "RG_SENSORES");

            migrationBuilder.DropIndex(
                name: "IX_RG_SENSORES_ID_USUARIO_CREACION",
                table: "RG_SENSORES");

            migrationBuilder.DropIndex(
                name: "IX_RG_SECTOR_USUARIO_CREACION",
                table: "RG_SECTOR");

            migrationBuilder.DropIndex(
                name: "IX_RG_HISTORICO_SECTOR_ID_SECTOR",
                table: "RG_HISTORICO_SECTOR");

            migrationBuilder.DropIndex(
                name: "IX_RG_HISTORIAL_SENSOR_RG_ID_SENSOR",
                table: "RG_HISTORIAL_SENSOR");
        }
    }
}
