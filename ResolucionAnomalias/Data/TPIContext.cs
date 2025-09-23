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
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Denunciante> Denunciantes { get; set; }

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

                entity.Property(e=> e.ID).ValueGeneratedOnAdd();

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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Cod_usu);

                entity.Property(e => e.Cod_usu)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre_usu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email_usu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Email_usu)
                    .IsUnique();

                entity.Property(e => e.Passw_usu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo_usu)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ZonaId)
                    .IsRequired()
                    .HasField("_zonaId");

                entity.Navigation(e => e.Zona)
                    .HasField("_zona");

                entity.HasOne(e => e.Zona)
                    .WithMany()
                    .HasForeignKey(e => e.ZonaId);
            });

            modelBuilder.Entity<Denunciante>(entity =>
            {
                entity.HasKey(e => e.Cod_den);

                entity.Property(e => e.Cod_den)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre_den)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Direccion_den)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasData(
                    new { Cod_den = 1, Nombre_den = "Juan Pepe", Telefono = "3413123456", Direccion_den = "Corrientes 1400" },
                    new { Cod_den = 2, Nombre_den = "Ana Maria", Telefono = "3415456789", Direccion_den = "Santa Fe 2000" }
                );
            });

        }

    }
}
