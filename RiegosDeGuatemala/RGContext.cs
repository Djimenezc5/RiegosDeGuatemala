using Microsoft.EntityFrameworkCore;
using RiegosDeGuatemala.Controllers;
using RiegosDeGuatemala.Entidades.procedures;
using RiegosDeGuatemala.Entidades.sectores;
using RiegosDeGuatemala.Entidades.Seedings;
using RiegosDeGuatemala.Entidades.sensores;
using RiegosDeGuatemala.Entidades.Usuario;
using System.Reflection;

namespace RiegosDeGuatemala
{
    public class RGContext : DbContext
    {
        public RGContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingTipoSendor.seed(modelBuilder);
            modelBuilder.Entity<SP_RG_CONSUMOS_SECTOR>().HasNoKey().ToView(null);
        }
        public DbSet<UsuarioEntidad> Usuario { get; set; }
        public DbSet<TokenUsuario> TokenUsuarios { get; set; }
        public DbSet<sector> sectores { get; set; }
        public DbSet<HistoricoSectores> HistoricoSectores { get; set; }
        public DbSet<TipoSensor> tipoSensores { get; set; }
        public DbSet<Sensores> sensores { get; set; }
        public DbSet<HistorialSensor> historialSensores { get; set; }
        public virtual DbSet<SP_RG_CONSUMOS_SECTOR> SP_RG_CONSUMOS_SECTOR { get; set; }
    }
}
