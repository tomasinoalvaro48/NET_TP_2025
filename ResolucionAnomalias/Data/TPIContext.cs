using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class TPIContext : DbContext
    {
        public DbSet<TipoAnomalia> TipoAnomalias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PedidoAgregacion> PedidosAgregacion { get; set; }
        public DbSet<PedidoResolucion> PedidosResolucion { get; set; }

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

                entity.HasData(
                    new { ID = 1, Codigo = 2000, Nombre = "Rosario" },
                    new { ID = 2, Codigo = 2001, Nombre = "Bs As" }
                );
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

                entity.HasData(
                    new { Id = 1, Nombre = "Centro", LocalidadId = 1, LocalidadCodigo = "2000", LocalidadNombre = "Rosario" },
                    new { Id = 2, Nombre = "Sur", LocalidadId = 1, LocalidadCodigo = "2000", LocalidadNombre = "Rosario" },
                    new { Id = 3, Nombre = "Norte", LocalidadId = 2, LocalidadCodigo = "2001", LocalidadNombre = "Bs As" }
                );
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

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo_usu)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ZonaId)
                    .HasField("_zonaId")
                    .IsRequired(false);

                entity.Navigation(e => e.Zona)
                    .HasField("_zona");

                entity.HasOne(e => e.Zona)
                    .WithMany()
                    .HasForeignKey(e => e.ZonaId)
                    .IsRequired(false);

                var opUser = new Domain.Model.Usuario("Operador", "operador@gmail.com", "operador", "Operador", 1);
                entity.HasData(new
                {
                    Cod_usu = 1,
                    Nombre_usu = opUser.Nombre_usu,
                    Email_usu = opUser.Email_usu,
                    Passw_usu = opUser.Passw_usu,
                    Salt = opUser.Salt,
                    Tipo_usu = opUser.Tipo_usu,
                    ZonaId = opUser.ZonaId
                });
            });

            modelBuilder.Entity<PedidoAgregacion>(entity =>
            {
                entity.HasKey(e => e.Id_pedido_agreg);
                entity.Property(e => e.Id_pedido_agreg).ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion_pedido_agreg).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Dificultad_pedido_agreg).IsRequired();
                entity.Property(e => e.Estado_pedido_agreg).IsRequired().HasMaxLength(50);
                // Tipo de anomalia OPCIONAL (nullable)
                entity.Property(e => e.TipoAnomaliaId)
                    .HasField("_tipoAnomaliaId")
                    .IsRequired(false);

                entity.Navigation(e => e.TipoAnomalia).HasField("_tipoAnomalia");
            modelBuilder.Entity<PedidoResolucion>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha)
                    .IsRequired();

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500);

                entity.Property(e => e.Dificultad)
                    .IsRequired();

                entity.Property(e => e.ZonaId)
                    .IsRequired()
                    .HasField("_zonaId");

                entity.Navigation(e => e.Zona)
                    .HasField("_zona");

                entity.HasOne(e => e.Zona)
                    .WithMany()
                    .HasForeignKey(e => e.TipoAnomaliaId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                // Cazador OBLIGATORIO
                entity.Property(e => e.CazadorId)
                    .HasField("_cazadorId")
                    .IsRequired(false);

                entity.Navigation(e => e.Cazador)
                    .HasField("_cazador");

                entity.HasOne(e => e.Cazador)
                    .WithMany()
                    .HasForeignKey(e => e.CazadorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.Property(e => e.DenuncianteId)
                    .IsRequired()
                    .HasField("_denuncianteId");
                // Tipo de anomalia OPCIONAL (nullable)
                entity.Property(e => e.TipoAnomaliaId)
                    .HasField("_tipoAnomaliaId")
                    .IsRequired(false);

                entity.Navigation(e => e.TipoAnomalia).HasField("_tipoAnomalia");

                entity.HasOne(e => e.TipoAnomalia)
                    .WithMany()
                    .HasForeignKey(e => e.TipoAnomaliaId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                // Cazador OBLIGATORIO
                entity.Property(e => e.CazadorId)
                    .HasField("_cazadorId")
                    .IsRequired();

                entity.Navigation(e => e.Cazador)
                    .HasField("_cazador");

                entity.HasOne(e => e.Cazador)
                    .WithMany()
                    .HasForeignKey(e => e.CazadorId);
            });

                modelBuilder.Entity<PedidoResolucion>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Fecha).IsRequired();
                entity.Property(e => e.Direccion).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Descripcion).HasMaxLength(500);
                entity.Property(e => e.Estado).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Comentario).HasMaxLength(500);
                entity.Property(e => e.Dificultad).IsRequired();

                entity.Property(e => e.ZonaId).IsRequired().HasField("_zonaId");
                entity.Navigation(e => e.Zona).HasField("_zona");
                entity.HasOne(e => e.Zona).WithMany().HasForeignKey(e => e.ZonaId).OnDelete(DeleteBehavior.Restrict);

                // IMPORTANT: usar el campo privado para materializar la colección
                entity.Navigation(e => e.AnomaliaPedidos)
                      .HasField("_anomaliaPedido")
                      .UsePropertyAccessMode(PropertyAccessMode.Field);

                entity.OwnsMany(e => e.AnomaliaPedidos, anomalia =>
                {
                    anomalia.WithOwner().HasForeignKey(a => a.PedidoId);

                    anomalia.Property(a => a.TipoAnomaliaId)
                        .IsRequired()
                        .HasField("_tipoAnomaliaId");

                    anomalia.Navigation(a => a.TipoAnomalia).HasField("_tipoAnomalia");

                    anomalia.HasOne(a => a.TipoAnomalia)
                        .WithMany()
                        .HasForeignKey(a => a.TipoAnomaliaId)
                        .OnDelete(DeleteBehavior.Restrict);

                    // opcional, explicitar tabla para la owned collection
                    anomalia.ToTable("AnomaliaPedido");
                });
            });
        }
    }
}
