using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiegosDeGuatemala.Entidades.Usuario
{
    [Table("RG_USUARIO_TOKEN")]
    public class TokenUsuario
    {
        [Column("ID_USUARIO_TOKEN")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Column("ID_USUARIO"), ForeignKey("UsuarioEntidad")]
        public int idUsuario { get; set; }
        [Column("TOKEN")]
        public Guid token { get; set; }
        [Column("FECHA_CREACION_TOKEN")]
        public DateTime fechaCreacionToken { get; set; } = DateTime.Now;
        public virtual UsuarioEntidad UsuarioEntidad { get; set; }
    }
}
