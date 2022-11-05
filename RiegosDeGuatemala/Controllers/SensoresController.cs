using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiegosDeGuatemala.Entidades;
using RiegosDeGuatemala.Entidades.sensores;

namespace RiegosDeGuatemala.Controllers
{
    [Route("api/Sensores")]
    [ApiController]
    public class SensoresController : ControllerBase
    {
        private RGContext context;
        public SensoresController(RGContext context)
        {
            this.context = context;
        }
        [HttpPost("CreaSensor")]
        public IActionResult CreaSensor(Sensores sensor) {

            sensor.CodigoSendor = Guid.NewGuid();

            context.Add(sensor);
            context.SaveChanges();

            Respuesta respuesta = new Respuesta() { exitoso = true, mensaje = "Sensor creado exitosamente" };

            return Ok(respuesta);
        }

        [HttpGet("ObtieneTipoSensor")]
        public IActionResult ObtieneTipoSensor() {
            Respuesta respuesta = new Respuesta();
            var tipoSensores = context.tipoSensores.Where(x => x.estadoSensor == true).ToList();
            if (tipoSensores?.Count > 0)
            {
                respuesta.exitoso = true;
                respuesta.datos = tipoSensores;
                return Ok(respuesta);
            }
            else
            {
                respuesta.exitoso = false;
                respuesta.mensaje = "No se encontraron tipos de sensores";
                return BadRequest(respuesta);
            }

        }

        [HttpGet("obtieneSensores")]
        public IActionResult ObtieneSensores(int tipoSensor) {
            Respuesta respuesta = new Respuesta();
            var sensores = context.sensores.Where(x => x.estadoSendor == true  && x.IdTipoSensor == tipoSensor)
                                           .Select(x => new
                                           {
                                               idSensor = x.Id,
                                               codigoSensor = x.CodigoSendor,
                                               idSector = x.idSector
                                           }).ToList();

            if (sensores?.Count > 0)
            {
                respuesta.exitoso = true;
                respuesta.datos = sensores;
                return Ok(respuesta);
            }
            else {
                respuesta.exitoso = true;
                respuesta.mensaje = "No se encontraron sensores";
                return BadRequest(respuesta);
            }

        }

        [HttpPut("BajaSensor")]
        public IActionResult BajaSensor(int idSensor)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                var sensor = context.sensores.Find(idSensor);
                sensor.estadoSendor = false;
                context.SaveChanges();
                respuesta.exitoso = true;
                respuesta.mensaje = "El sensor fue dado de baja exitosamente";
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.exitoso = false;
                respuesta.mensaje = $"Ocurrio un problema: {ex}";
                return BadRequest(respuesta);
            }

        }

        [HttpPost("HostorialSensor")]
        public IActionResult HostorialSensor(HistorialSensor sensor) {
            try
            {
                var activosAntiguos = context.historialSensores.Where(x => x.esUltimo == true
                                                      && x.idSensor == sensor.idSensor)
                                               .ToList();

                if (activosAntiguos?.Count > 0)
                {
                    activosAntiguos.ForEach(x => x.esUltimo = false);
                }

                context.historialSensores.Add(sensor);
                context.SaveChanges();

                return Ok(new Respuesta { exitoso = true, mensaje = $"Registro creado exitosamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(new Respuesta { exitoso = false, mensaje = $"Ocurrio un problema: {ex.Message}" });
            }
        
        }
    }
}
