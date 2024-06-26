using Kiosko_Facturacion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Kiosko_Facturacion.Context
{
    public class ContextDB : DbContext
    {

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones específicas del modelo User
            //modelBuilder.Entity<User>()
            //    .Property(u => u.Nombre)
            //    .HasMaxLength(100)
            //    .IsRequired();

            //modelBuilder.Entity<User>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();



            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("usuario"); // Nombre de la tabla en la base de datos

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsRequired();

                entity.HasIndex(e => e.Email)
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                     .HasColumnName("fecharegistro")
                     .IsRequired();
            });

            base.OnModelCreating(modelBuilder);

        }

    }
}
