using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using RiegosDeGuatemala.Entidades;
using RiegosDeGuatemala.Entidades.Usuario;

namespace RiegosDeGuatemala.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuariosController: ControllerBase
    {
        private RGContext context;
        public UsuariosController(RGContext context)
        {
            this.context = context;
        }

        [HttpPost, Route("login")]
        public IActionResult loginUsuarioToken(UsuarioDTO usuario) {
            var busquedaUsuario = context.Usuario.Where(x => x.email == usuario.email).FirstOrDefault();

            if (busquedaUsuario == null)
            {
                return BadRequest(new Respuesta { exitoso = false, mensaje = "Usuario no existe" });
            }
            else if (busquedaUsuario.Estado == false || busquedaUsuario.Contraseña != usuario.contrasenia)
            {
                string mensaje = busquedaUsuario.Contraseña != usuario.contrasenia ? "Contraseña incorrecta" 
                                                                                    : "El usuario se encuentra de baja";
                return BadRequest(new Respuesta { exitoso = false, mensaje = mensaje });
            }
            else 
            {
                TokenUsuario nuevoTokenUsuario = new TokenUsuario();
                UsuarioDTO usuarioRetorno = new UsuarioDTO { id = busquedaUsuario.Id, email = busquedaUsuario.email};
                nuevoTokenUsuario.idUsuario = busquedaUsuario.Id;
                nuevoTokenUsuario.token = Guid.NewGuid();

                context.TokenUsuarios.Add( nuevoTokenUsuario);
                context.SaveChanges();

                return Ok(new Respuesta { exitoso = true, mensaje = "Usuario valido", datos = usuarioRetorno, token = nuevoTokenUsuario.token });
            }
            
        }


        [HttpPost, Route("NuevoUsuario")]
        public IActionResult CrearUsuario(UsuarioEntidad nuevoUsuario) {

            var validaEMail = context.Usuario.Where(x => x.email == nuevoUsuario.email).FirstOrDefault();

            if (validaEMail == null)
            {
                context.Usuario.Add(nuevoUsuario);
                context.SaveChanges();
                return Ok(new Respuesta { exitoso = true, mensaje = "Usuario creado exitosamente" });
            }
            else 
            {
                return BadRequest(new Respuesta { exitoso = false, mensaje = "Correo electronico invalido/ya existente en la base de datos" });
            }

        }
    }
}
