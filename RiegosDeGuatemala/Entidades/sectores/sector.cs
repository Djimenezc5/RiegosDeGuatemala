using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RiegosDeGuatemala.Entidades.Usuario;

namespace RiegosDeGuatemala.Entidades.sectores
{
    [Table("RG_SECTOR")]
    public class sector
    {
        [Column("ID_SECTOR")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [Column("NOMBRE_SECTOR")]
        public string Nombre { get; set; }
        [Column("DESCRIPCION_SECTOR")]
        public string descripcionSector { get; set; }
        [Column("FECHA_CREACION")]
        public DateTime fechaCreacionToken { get; set; } = DateTime.Now;
        [Column("HUMEDAD _MINIMA")]
        public decimal humedadMinima { get; set; }
        [Column("HUMEDAD _MAXIMA")]
        public decimal humedadMaxima { get; set; }
        [Column("TIEMPO_MAXIMA")]
        public int tiempoMaximoRiego { get; set; }
        [Column("RIEGO_ACTIVO")]
        public bool reigoActivo { get; set; } = false;
        [Column("FECHA_ULTIMO_RIEGO")]
        public DateTime ultimoRiego { get; set; }
        [Column("USUARIO_CREACION"), ForeignKey("UsuarioEntidad")]
        public virtual int UsuarioCreacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; } = true;
        [Column("LUMINOSIDAD _MINIMA")]
        public decimal luminosidadMinima { get; set; }
        [Column("LUMINOSIDAD _MAXIMA")]
        public decimal luminosidadMaxima { get; set; }
        public virtual UsuarioEntidad UsuarioEntidad { get; set; }
    }
}
