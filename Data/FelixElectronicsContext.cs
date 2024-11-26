using Microsoft.EntityFrameworkCore;
using FelixManagementApp.Models;

namespace FelixManagementApp.Data;

public class FelixElectronicsContext : DbContext
{
    public FelixElectronicsContext(DbContextOptions<FelixElectronicsContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Tecnico> Tecnicos => Set<Tecnico>();
    public DbSet<Orden> Ordenes => Set<Orden>();
    public DbSet<Equipo> Equipos => Set<Equipo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");
            entity.HasKey(e => e.id_cliente);
            entity.Property(e => e.nombre).HasMaxLength(50).IsRequired();
            entity.Property(e => e.apellido_paterno).HasMaxLength(50).IsRequired();
            entity.Property(e => e.apellido_materno).HasMaxLength(50).IsRequired();
            entity.Property(e => e.correo).HasMaxLength(50).IsRequired();
            entity.Property(e => e.telefono).HasMaxLength(15).IsRequired();
        });

        modelBuilder.Entity<Tecnico>(entity =>
        {
            entity.ToTable("Tecnico");
            entity.HasKey(e => e.id_tecnico);
            entity.Property(e => e.nombre).HasMaxLength(50).IsRequired();
            entity.Property(e => e.apellido_paterno).HasMaxLength(50).IsRequired();
            entity.Property(e => e.apellido_materno).HasMaxLength(50).IsRequired();
            entity.Property(e => e.correo).HasMaxLength(50).IsRequired();
            entity.Property(e => e.contrasenia).HasMaxLength(20).IsRequired();
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.ToTable("Orden");
            entity.HasKey(e => e.id_orden);
            entity.Property(e => e.fecha_creacion).IsRequired();
            entity.Property(e => e.total).HasColumnType("decimal(18,2)").IsRequired();
            entity.HasOne(e => e.Cliente)
                  .WithMany()
                  .HasForeignKey(e => e.id_cliente)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.ToTable("Equipo");
            entity.HasKey(e => e.id_equipo);
            entity.Property(e => e.marca).HasMaxLength(20).IsRequired();
            entity.Property(e => e.modelo).HasMaxLength(20).IsRequired();
            entity.Property(e => e.contrasenia_equipo).HasMaxLength(20);
            entity.Property(e => e.accesorios).HasMaxLength(150);
            entity.Property(e => e.problema).HasMaxLength(150).IsRequired();
            entity.Property(e => e.estatus).HasMaxLength(20).IsRequired();

            entity.HasOne(e => e.Orden)
                  .WithMany()
                  .HasForeignKey(e => e.id_orden)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Tecnico)
                  .WithMany()
                  .HasForeignKey(e => e.id_tecnico)
                  .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(e => e.Cliente)
                  .WithMany()
                  .HasForeignKey(e => e.id_cliente)
                  .OnDelete(DeleteBehavior.Restrict);
        });
    }
}