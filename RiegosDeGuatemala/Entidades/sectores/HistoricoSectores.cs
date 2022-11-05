using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RiegosDeGuatemala.Entidades.sectores
{

    [Table("RG_HISTORICO_SECTOR")]
    public class HistoricoSectores
    {
        [Column("ID_HISTORICO_SECTOR")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ID_SECTOR"), ForeignKey("sector")]
        public virtual int IdSector { get; set; }

        [Column("TIEMPO_RIEGO")]
        public int tiempoRiego { get; set; }

        [Column("CANTIDAD_AGUA")]
        public int cantidadAgua { get; set; }

        [Column("FECHA_ULTIMA_ACCION")]
        public DateTime ultimoAccion { get; set; } = DateTime.Now;

        [Column("ESTADO_RIEGO")]
        public bool riegoActivo { get; set; }
        [Column("ULTIMO_HISTORIAL")]
        public bool esUltimo { get; set; }
        [Column("CODIGO_RIEGO")]
        public Guid codigoRiego { get; set; }
        [NotMapped]
        public bool RequiereNuevoHistorial { get; set; }

        public virtual sector sector { get; set; }
    }
}
