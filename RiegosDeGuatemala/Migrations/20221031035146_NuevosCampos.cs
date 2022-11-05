using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class NuevosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCION_TIPO_SENSOR",
                table: "RG_TIPO_SENSOR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ICONO_TIPO_SENSOR",
                table: "RG_TIPO_SENSOR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FECHA_CREACION",
                table: "RG_SENSORES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ID_SECTOR",
                table: "RG_SENSORES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_USUARIO_CREACION",
                table: "RG_SENSORES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RG_TIPO_SENSOR",
                keyColumn: "ID_TIPO_SENSOR",
                keyValue: 1,
                columns: new[] { "DESCRIPCION_TIPO_SENSOR", "ICONO_TIPO_SENSOR" },
                values: new object[] { "Sensores para la medición de humedad", "water" });

            migrationBuilder.UpdateData(
                table: "RG_TIPO_SENSOR",
                keyColumn: "ID_TIPO_SENSOR",
                keyValue: 2,
                columns: new[] { "DESCRIPCION_TIPO_SENSOR", "ICONO_TIPO_SENSOR" },
                values: new object[] { "Sensores para la medición de humedad", "white-balance-sunny" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPCION_TIPO_SENSOR",
                table: "RG_TIPO_SENSOR");

            migrationBuilder.DropColumn(
                name: "ICONO_TIPO_SENSOR",
                table: "RG_TIPO_SENSOR");

            migrationBuilder.DropColumn(
                name: "FECHA_CREACION",
                table: "RG_SENSORES");

            migrationBuilder.DropColumn(
                name: "ID_SECTOR",
                table: "RG_SENSORES");

            migrationBuilder.DropColumn(
                name: "ID_USUARIO_CREACION",
                table: "RG_SENSORES");
        }
    }
}
