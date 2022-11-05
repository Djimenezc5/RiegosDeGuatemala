using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiegosDeGuatemala.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              CREATE PROCEDURE dbo.SP_RG_CONSUMOS_SECTOR
              AS
              BEGIN
                 SELECT 
                        A.ID_SECTOR,
                        A.NOMBRE_SECTOR,
                 	    ISNULL(SUM(B.TIEMPO_RIEGO),0) AS TIEMPO_RIEGO,
                 	    ISNULL(SUM(B.CANTIDAD_AGUA),0) AS CATIDAD_AGUA
                   FROM RG_SECTOR A
                   LEFT JOIN RG_HISTORICO_SECTOR B
                   ON A.ID_SECTOR = B.ID_SECTOR
                   WHERE A.ESTADO = 1
                   GROUP BY A.ID_SECTOR, A.NOMBRE_SECTOR
              END                
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE dbo.SP_RG_CONSUMOS_SECTOR");
        }
    }
}
