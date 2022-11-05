using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiegosDeGuatemala.Entidades.Usuario
{
    [Table("RG_USUARIO")]
    public class UsuarioEntidad
    {
        [Column("ID_USUARIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string email { get; set; }
        [Required(ErrorMessage = "La constraseña es requerida")]
        [Column("CONTRASENIA")]
        [MinLength(8, ErrorMessage = "El numero minimo de caracteres es 8")]
        public string Contraseña { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; } = true;
        [Column("FECHA_CREACION_USUARIO")]
        public DateTime fechaCreacionToken { get; set; } = DateTime.Now;
    }
}
