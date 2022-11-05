using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiegosDeGuatemala.Entidades.sensores
{
    [Table("RG_TIPO_SENSOR")]
    public class TipoSensor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_TIPO_SENSOR")]
        public int id { get; set; }
        [Column("NOMBRE_TIPO_SENSOR")]
        public string nombreTipoSensor { get; set; }
        [Column("ESTADO_SENSOR")]
        public bool estadoSensor { get; set; }
        [Column("ICONO_TIPO_SENSOR")]
        public string Icono { get; set; }
        [Column("DESCRIPCION_TIPO_SENSOR")]
        public string DescripcionTipoSensor { get; set; }
    }
}
