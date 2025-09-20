using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.Extensions.Configuration;


namespace Data
{
    public class TPIContext : DbContext
    {
        public DbSet<TipoAnomalia> TipoAnomalias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Zona> Zonas { get; set; }

        internal TPIContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoAnomalia>(entity =>
            {
                entity.HasKey(e => e.Cod_anom);
                
                entity.Property(e => e.Cod_anom).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre_anom).IsRequired().HasMaxLength(100);

                entity.HasIndex(e => e.Nombre_anom).IsUnique();

                entity.Property(e => e.Dif_anom).IsRequired();
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Codigo).IsRequired();

                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);

                entity.HasIndex(e => e.Codigo).IsUnique();

            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LocalidadId)
                    .IsRequired()
                    .HasField("_localidadId");

                entity.Navigation(e => e.Localidad)
                    .HasField("_localidad");

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();

                entity.HasOne(e => e.Localidad)
                    .WithMany()
                    .HasForeignKey(e => e.LocalidadId);

            });

        }

    }
}
