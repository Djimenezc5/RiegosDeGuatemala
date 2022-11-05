using RiegosDeGuatemala.Entidades.Usuario;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiegosDeGuatemala.Entidades.sensores
{
    [Table("RG_HISTORIAL_SENSOR")]
    public class HistorialSensor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_HISTORIAL_SENSOR")]
        public int Id { get; set; }
        [Column("RG_ID_SENSOR"), ForeignKey("Sensores")]
        public virtual int idSensor { get; set; }
        [Column("MEDIDA_SENSOR")]
        public decimal medidaSensor { get; set; }
        [Column("FECHA_MEDIDA")]
        public DateTime fechaMedida { get; set; } = DateTime.Now;
        [Column("ULTIMO_HISTORIAL")]
        public bool esUltimo { get; set; } = true;
        public virtual Sensores Sensores { get; set; }
    }
}
