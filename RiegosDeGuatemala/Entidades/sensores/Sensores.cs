using RiegosDeGuatemala.Entidades.Usuario;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiegosDeGuatemala.Entidades.sensores
{
    [Table("RG_SENSORES")]
    public class Sensores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_SENSOR")]
        public int Id { get; set; }
        [Column("CODIGO_SENSOR")]
        public Guid CodigoSendor { get; set; }
        [Column("ID_TIPO_SENSOR"), ForeignKey("TipoSensor")]
        public virtual int IdTipoSensor { get; set; }
        [Column("ESTADO_SENSOR")]
        public bool estadoSendor { get; set; } = true;
        [Column("FECHA_CREACION")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [Column("ID_SECTOR")]
        public int idSector { get; set; }
        [Column("ID_USUARIO_CREACION"), ForeignKey("UsuarioEntidad")]
        public virtual int idUsarioCreacion { get; set; }
        public virtual UsuarioEntidad UsuarioEntidad { get; set; }
        public virtual TipoSensor TipoSensor { get; set; }
    }
}
