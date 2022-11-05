using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiegosDeGuatemala.Entidades.Usuario;
using RiegosDeGuatemala.Entidades;
using RiegosDeGuatemala.Entidades.sectores;
using RiegosDeGuatemala.Metodos;
using Microsoft.EntityFrameworkCore;

namespace RiegosDeGuatemala.Controllers
{
    [Route("api/sectores")]
    [ApiController]
    public class SectoresController : ControllerBase
    {
        private RGContext context;
        public SectoresController(RGContext context)
        {
            this.context = context;
        }
        [HttpGet, Route("ObtieneSectores")]
        public IActionResult ObtieneSectores()
        {
            var sectores = context.sectores.Where(x => x.Estado == true)
                                           .Select(x => new
            {
                Id = x.Id,
                Nombre = x.Nombre,
                descripcionSector = x.descripcionSector,
                fechaCreacionToken = x.fechaCreacionToken,
                humedadMinima = x.luminosidadMinima,
                humedadMaxima = x.luminosidadMaxima,
                tiempoMaximoRiego = x.tiempoMaximoRiego,
                reigoActivo = x.reigoActivo,
                ultimoRiego = x.ultimoRiego,
                UsuarioCreacion = x.UsuarioCreacion,
                Estado = x.Estado,
                luminosidadMinima = x.luminosidadMinima,
                luminosidadMaxima = x.luminosidadMaxima,
                ultimoHistorial = context.HistoricoSectores.Where(y => y.IdSector == x.Id && y.esUltimo == true).OrderByDescending(x => x.Id).FirstOrDefault(),
            }).ToList();

            if (sectores?.Count > 0)
            {
                return Ok(new Respuesta { exitoso = true, datos = sectores });
            }
            else
            {

                return BadRequest(new Respuesta { exitoso = false, mensaje = "No se han encontrado sectores" });
            }
        }
        [HttpPost, Route("NuevoSector")]
        public IActionResult NuevoSector(sector nuevoSector)
        {
            context.sectores.Add(nuevoSector);
            context.SaveChanges();
            return Ok(new Respuesta { exitoso = true, mensaje = "Sector creado exitosamente" });
        }
        [HttpPost, Route("HistorialSensor")]
        public IActionResult HistorialSensor(HistoricoSectores nuevoRegistro)
        {
            try
            {
                Metodos_genericos Metodos_genericos = new Metodos_genericos();
                var activosAntiguos = context.HistoricoSectores.Where(x => x.esUltimo == true
                                                                      && x.IdSector == nuevoRegistro.IdSector)
                                                               .ToList();

                if (activosAntiguos?.Count > 0)
                {
                    activosAntiguos.ForEach(x => x.esUltimo = false);
                }

                var existeCodigo = context.HistoricoSectores.Where(y => y.codigoRiego == nuevoRegistro.codigoRiego
                                                                   && y.IdSector == nuevoRegistro.IdSector
                                                                   && y.riegoActivo == true)
                                                            .OrderByDescending(x => x.Id).FirstOrDefault();

                if (nuevoRegistro.RequiereNuevoHistorial == true)
                {
                    nuevoRegistro.codigoRiego = Guid.NewGuid();
                    nuevoRegistro.riegoActivo = true;
                    nuevoRegistro.esUltimo = true;
                    context.HistoricoSectores.Add(nuevoRegistro);
                    var actualizacionSector = context.sectores.Find(nuevoRegistro.IdSector);
                }
                else
                {
                    nuevoRegistro.riegoActivo = false;
                    nuevoRegistro.esUltimo = true;
                    nuevoRegistro.tiempoRiego = (int)Math.Ceiling(Metodos_genericos.difereciaMinutos(existeCodigo.ultimoAccion, nuevoRegistro.ultimoAccion));
                    nuevoRegistro.cantidadAgua = (int)Math.Ceiling(1.5 * Metodos_genericos.difereciaMinutos(existeCodigo.ultimoAccion, nuevoRegistro.ultimoAccion));
                    context.HistoricoSectores.Add(nuevoRegistro);
                    var actualizacionSector = context.sectores.Find(nuevoRegistro.IdSector);
                    actualizacionSector.ultimoRiego = DateTime.Now;
                }


                context.SaveChanges();

                return Ok(new Respuesta { exitoso = true, mensaje = "Historial creado exitosamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(new Respuesta { exitoso = false, mensaje = $"Ocurrio un problema: {ex.Message}" });
            }

        }

        [HttpGet("MedidasSectores")]
        public IActionResult MedidasSectores()
        {
            var resultado = context.SP_RG_CONSUMOS_SECTOR.FromSqlRaw("EXEC SP_RG_CONSUMOS_SECTOR").ToList();
            return Ok(new Respuesta { exitoso = true, datos = resultado });
        }
    }
}
