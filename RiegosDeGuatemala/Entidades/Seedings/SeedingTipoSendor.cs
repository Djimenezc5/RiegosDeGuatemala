using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RiegosDeGuatemala.Entidades.sensores;

namespace RiegosDeGuatemala.Entidades.Seedings
{
    public class SeedingTipoSendor
    {
        public static void seed(ModelBuilder modelBuilder) {
            var humedad = new TipoSensor() { id = 1, nombreTipoSensor="Sensor humedad", estadoSensor=true, Icono = "water", DescripcionTipoSensor = "Sensores para la medición de humedad" };
            var luminosidad = new TipoSensor() { id = 2, nombreTipoSensor = "Sensor luminosidad", estadoSensor = true, Icono = "white-balance-sunny", DescripcionTipoSensor= "Sensores para la medición de humedad" };

            modelBuilder.Entity<TipoSensor>().HasData(humedad, luminosidad);
        }
    }
}
